﻿using System.Collections.Specialized;
using System.Globalization;
using System.Windows.Forms;
using CometUI.Properties;

namespace CometUI
{
    public partial class ModificationSettingsControl : UserControl
    {
        public StringCollection VarMods { get; set; }
        private new Form Parent { get; set; }

        public StringCollection StaticMods { get; set; }


        public ModificationSettingsControl(Form parent)
        {
            InitializeComponent();

            Parent = parent;
                 
            InitializeFromDefaultSettings();

            foreach (var row in VarMods)
            {
                string[] cells = row.Split(',');
                varModsDataGridView.Rows.Add(cells);
            }

            foreach (var row in StaticMods)
            {
                string[] cells = row.Split(',');
                staticModsDataGridView.Rows.Add(cells);
            }
        }

        private void InitializeFromDefaultSettings()
        {
            VarMods = new StringCollection();
            foreach (var item in Settings.Default.VariableMods)
            {
                VarMods.Add(item);
            }

            variableNTerminusTextBox.Text = Settings.Default.VariableNTerminus.ToString(CultureInfo.InvariantCulture);
            variableCTerminusTextBox.Text = Settings.Default.VariableCTerminus.ToString(CultureInfo.InvariantCulture);
            variableNTerminusDistTextBox.Text = Settings.Default.VariableNTermDistance.ToString(CultureInfo.InvariantCulture);
            variableCTerminusDistTextBox.Text = Settings.Default.VariableCTermDistance.ToString(CultureInfo.InvariantCulture);

            maxModsInPeptideTextBox.Text = Settings.Default.MaxVarModsInPeptide.ToString(CultureInfo.InvariantCulture);            

            StaticMods = new StringCollection();
            foreach (var item in Settings.Default.StaticMods)
            {
                StaticMods.Add(item);
            }
        }
    }
}
