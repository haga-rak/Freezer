namespace Gecko.WebIDL
{
    using System;
    
    
    internal class BarProp : WebIDLBase
    {
        
        public BarProp(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool Visible
        {
            get
            {
                return this.GetProperty<bool>("visible");
            }
            set
            {
                this.SetProperty("visible", value);
            }
        }
    }
}
