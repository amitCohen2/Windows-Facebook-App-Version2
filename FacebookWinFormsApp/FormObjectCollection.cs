using FacebookLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormObjectCollection<T> : Form
    {
        private BindingList<T> m_Items;
        private readonly FacebookObjectCollection<T> r_Collection;
        private readonly FilterContextCollection<T> r_FilterContextCollection;
        private readonly Dictionary<string, IFilterStrategy<T>> r_FiltersStrategy;
        private readonly string r_Name;

        public T SelectedItemList 
        { 
            get 
            {
                int selectedIdx = listBoxCollectionItemsNames.SelectedIndex;
                if (selectedIdx != -1)
                {
                    return m_Items[selectedIdx];
                } 
                else
                {
                    return default(T);
                }
            } 
        }     
        public FormObjectCollection(FacebookObjectCollection<T> i_Collection)
        {
            r_Collection = i_Collection;
            r_FilterContextCollection = new FilterContextCollection<T>(r_Collection);
            r_Name = typeof(T).Name;
            m_Items = new BindingList<T>();
            r_FiltersStrategy = new Dictionary<string, IFilterStrategy<T>>();
            InitializeComponent();
            initialComponent();
            listBoxCollectionItemsNames.DataSource = m_Items;
            listBoxCollectionItemsNames.DisplayMember = "Name";
            listBoxCollectionItemsNames.Format += (sender, e) =>
                e.Value = typeof(T).GetProperty("Name").GetValue(e.ListItem) ?? "No Name for " + typeof(T).Name;
        }


        private void initialComponent()
        {
            foreach (T item in r_Collection)
            {
                m_Items.Add(item);
            }

            buttonShowPictures.Visible = typeof(T) == typeof(Album);
        }


        protected virtual void listBoxCollectionItemsNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                labelName.Text = typeof(T).GetProperty("Name").GetValue(m_Items[listBoxCollectionItemsNames.SelectedIndex]) as string;
                initalMainPictureValue(listBoxCollectionItemsNames.SelectedIndex);
                initialDescriptionValue(listBoxCollectionItemsNames.SelectedIndex);
            } catch { }

        }

        private void initalMainPictureValue(int i_SelectedIndex)
        {
            PropertyInfo pictureProperty = typeof(T).GetProperty("PictureNormalURL");

            if (pictureProperty != null)
            {
                roundPictureBox.LoadAsync(
                    pictureProperty.GetValue(m_Items[i_SelectedIndex]) as string);
            }
        }

        private void initialDescriptionValue(int i_indexInList)
        {
            PropertyInfo descriptionProperty = typeof(T).GetProperty("Description");

            if (descriptionProperty != null)
            {
                textBoxDescription.Text = descriptionProperty.GetValue(m_Items[i_indexInList]) as string;
            }
            else
            {
                textBoxDescription.Text = string.Empty;
            }
        }


        private void buttonShowPictures_Click(object sender, EventArgs e)
        {
            if (listBoxCollectionItemsNames.SelectedIndex != -1)
            {
                new FormObjectCollection<Photo>((m_Items[listBoxCollectionItemsNames.SelectedIndex] as Album).Photos).ShowDialog();
            }
        }


        private void textBoxSearchByName_Leave(object sender, EventArgs e)
        {
            TextBox textBoxSearch = sender as TextBox;

            if (textBoxSearch != null && textBoxSearch.Text == string.Empty)
            {
                textBoxSearch.Text = "search by name";
            }
        }

        private void textBoxSearchByName_Enter(object sender, EventArgs e)
        {
            TextBox textBoxSearch = sender as TextBox;

            if (textBoxSearch != null && textBoxSearch.Text.Equals("search by name"))
            {
                textBoxSearch.Text = string.Empty;
            } 
        }

        private void FormCollectionItem_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            m_Items.Clear();
            new Thread(() => filterSearch()).Start();
        }

        private void filterSearch()
        {
            bool isEmptySearch = true;
            if (textBoxSearchByName != null && textBoxSearchByName.Text != "search by name")
            {
                if (!r_FiltersStrategy.ContainsKey("FilterBySubName"))
                {
                    r_FiltersStrategy.Add("FilterBySubName", new FilterBySubName<T>());
                }
                r_FiltersStrategy["FilterBySubName"].FilterString = textBoxSearchByName.Text;
                r_FilterContextCollection.FilterStrategy = r_FiltersStrategy["FilterBySubName"];
                addCollectionToListBox();
                isEmptySearch = false;
            }

            if (imageCheckBox.Checked)
            {
                if (!r_FiltersStrategy.ContainsKey("FilterByImage"))
                {
                    r_FiltersStrategy.Add("FilterByImage", new FilterByImage<T>());
                }
                r_FilterContextCollection.FilterStrategy = r_FiltersStrategy["FilterByImage"];
                addCollectionToListBox();
                isEmptySearch = false;
            }

            if (DescriptionCheckBox.Checked)
            {
                if (!r_FiltersStrategy.ContainsKey("FilterByDescription"))
                {
                    r_FiltersStrategy.Add("FilterByDescription", new FilterByDescription<T>());
                }
                r_FiltersStrategy["FilterByDescription"].FilterString = textBoxSearchByName.Text;
                r_FilterContextCollection.FilterStrategy = r_FiltersStrategy["FilterByDescription"];
                addCollectionToListBox();
                isEmptySearch = false;
            }

            if (isEmptyFilter(isEmptySearch))
            {
                resetListBox();
            }
        }

        private void resetListBox()
        {
            foreach (T item in r_Collection)
            {
                listBoxCollectionItemsNames.Invoke(new Action(() => m_Items.Add(item)));
            }
        }

        private bool isEmptyFilter(bool i_IsEmptySearch)
        {
            return !imageCheckBox.Checked && !DescriptionCheckBox.Checked && i_IsEmptySearch;
        }

        private void addCollectionToListBox()
        {
            foreach (T item in r_FilterContextCollection)
            {
                listBoxCollectionItemsNames.Invoke(new Action(() => m_Items.Add(item)));
            }
        }
    }
}
