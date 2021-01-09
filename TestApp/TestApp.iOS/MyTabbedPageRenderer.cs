using System;
using CoreGraphics;
using TestApp;
using TestApp.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MainPage), typeof(MyTabbedPageRenderer))]
namespace TestApp.iOS
{
    public class MyTabbedPageRenderer : TabbedRenderer
    {
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            if (TabBar?.Items == null) return;

            //Setting the Icons
            TabBar.Items[0].Image = GetTabIcon(UITabBarSystemItem.Search);
            TabBar.Items[1].Image = GetTabIcon(UITabBarSystemItem.Downloads);
            TabBar.Items[2].Image = GetTabIcon(UITabBarSystemItem.Bookmarks);
        }

        private UIImage GetTabIcon(UITabBarSystemItem systemItem)
        {
            //Convert UITabBarItem to UIImage
            UITabBarItem item = new UITabBarItem(systemItem, 0);

            return UIImage.FromImage(item.SelectedImage.CGImage, item.SelectedImage.CurrentScale, item.SelectedImage.Orientation);
        }
    }
}