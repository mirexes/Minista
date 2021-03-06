﻿using System;
using InstagramApiSharp.Classes.Models;
using Windows.UI.Xaml.Data;
using System.Linq;

namespace Minista.Converters
{
    internal class MediaTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null) return "";
            if (value is InstaMediaType data)
            {
                switch(data)
                {
                    case InstaMediaType.Carousel:
                        return "Album";
                    case InstaMediaType.Image:
                        return "Photo";
                    case InstaMediaType.Video:
                        return "Video";
                }
            }
            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
