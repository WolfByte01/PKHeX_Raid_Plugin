﻿namespace PKHeX_Raid_Plugin
{
    public class ComboboxItem
    {
        public string Text { get; }
        public object Value { get; }

        public ComboboxItem(string text, object value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString() => Text;
    }
}