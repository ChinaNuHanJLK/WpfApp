using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MyControl
{

        /// <summary>
        /// 自定义按钮的分部类
        /// </summary>
        public partial class UserButton : UserControl
        {
            #region 正常状态下显示的背景图片
            public ImageSource ImageSourceNormal
            {
                get { return (ImageSource)GetValue(ImageSourceNormalProperty); }
                set { SetValue(ImageSourceNormalProperty, value); }
            }

            public static readonly DependencyProperty ImageSourceNormalProperty =
                DependencyProperty.Register("ImageSourceNormal", typeof(ImageSource), typeof(UserButton),
                new PropertyMetadata(new BitmapImage(new Uri("pack://application:,,,/MyControl;component/Images/1.bmp"))));
            #endregion

            #region 鼠标经过时显示的背景图片
            public ImageSource ImageSourceMouseOver
            {
                get { return (ImageSource)GetValue(ImageSourceMouseOverProperty); }
                set { SetValue(ImageSourceMouseOverProperty, value); }
            }

            public static readonly DependencyProperty ImageSourceMouseOverProperty =
                DependencyProperty.Register("ImageSourceMouseOver", typeof(ImageSource), typeof(UserButton),
                new PropertyMetadata(new BitmapImage(new Uri("pack://application:,,,/MyControl;component/Images/2.bmp"))));
            #endregion

            #region 鼠标按下时显示的背景图片
            public ImageSource ImageSourcePress
            {
                get { return (ImageSource)GetValue(ImageSourcePressProperty); }
                set { SetValue(ImageSourcePressProperty, value); }
            }

            public static readonly DependencyProperty ImageSourcePressProperty =
                DependencyProperty.Register("ImageSourcePress", typeof(ImageSource), typeof(UserButton),
                new PropertyMetadata(new BitmapImage(new Uri("pack://application:,,,/MyControl;component/Images/3.bmp"))));
            #endregion
        }
    
}
