using System;
using System.Collections.Generic;
using System.Text;

namespace ÔneSend.Models
{
  public  class Category
    {
        public string description { get; set; }
        public int numberItems { get; set; }
        public string image { get; set; }

        public string _backgroundColor;

        public string backgroundColor
        {
            get { return _backgroundColor; }
            set { SetProperty(ref _backgroundColor, value); }
        }

        private string _textColor;
        public string textColor
        {
            get { return _textColor; }
            set { SetProperty(ref _textColor, value); }
        }

        private bool _selected;

        public bool selected
        {
            get { return _selected; }
            set => setproperty(ref _selected, value);
        }

        private void setproperty(ref bool selected, bool value)
        {
            throw new NotImplementedException();
        }

        private void SetProperty(ref string backgroundColor, string value)
        {
            throw new NotImplementedException();
        }
    }
}
