﻿using StUtil.UI.Components.ObjectState.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StUtil.UI.Components.ObjectState
{
    public class StateEvent : ComponentChildItem<StateItem>
    {
        [Editor(typeof(StateEventListDropDownEditor), typeof(UITypeEditor))]
        [Category("General")]
        public string Event { get; set; }

        [Category("General")]
        [DefaultValue(true)]
        public bool Enabled { get; set; }

        [Category("General")]
        [DefaultValue(true)]
        public string RequiredState { get; set; }

        [Category("General")]
        [DefaultValue(typeof(string[]))]
        public string[] StateList { get; set; }

        private StateEventProperties props;

        [Editor(typeof(StateEventPropertiesEditor), typeof(UITypeEditor))]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Category("General")]
        public StateEventProperties Properties
        {
            get
            {
                return props;
            }
            set
            {
                props = value;
                props.Parent = this;
            }
        }

        public StateEvent()
        {
            Properties = new StateEventProperties();
            Enabled = true;
        }

        public override string ToString()
        {
            return string.IsNullOrEmpty(Event) ? "{Not Set}" : (Event.ToString() + " x" + Properties.Properties.Count);
        }
    }
}
