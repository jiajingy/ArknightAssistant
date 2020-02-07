using Arknight.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Arknight.Views
{
    /// <summary>
    /// Interaction logic for Recruit.xaml
    /// </summary>
    public partial class RecruitView : UserControl
    {
        public RecruitView()
        {
            InitializeComponent();

            InitializeCustom();
        }

        private void InitializeCustom()
        {
            IntializeTagDropdowns();
        }

        private void IntializeTagDropdowns()
        {
            RecruitmentTags recruitmentTags = new RecruitmentTags();

            List<ComboBox> TagsCombobox = CreateDropdownList();
            foreach (var tagsBox in TagsCombobox)
                tagsBox.ItemsSource = recruitmentTags.Tags;

        }

        private List<ComboBox> CreateDropdownList()
        {
            List<ComboBox> TagsCombobox = new List<ComboBox>();
            TagsCombobox.Add(tag1);
            TagsCombobox.Add(tag2);
            TagsCombobox.Add(tag3);
            TagsCombobox.Add(tag4);
            TagsCombobox.Add(tag5);
            TagsCombobox.Add(tag6);

            return TagsCombobox;
        }
    }
}
