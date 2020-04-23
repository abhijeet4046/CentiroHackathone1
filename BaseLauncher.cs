using System.ComponentModel;
using System;
using System.Threading;
using System.Threading.Tasks;
using PuppeteerSharp;

namespace ClassLibrary1
{
    public class BaseLauncher
    {
        public bool IsHeadless { get; set; }
        public BaseLauncher(bool isHeadless)
        {
            IsHeadless = isHeadless;
            DownloadChromium();
        }

        public async void DownloadChromium()
        {
            await new BrowserFetcher().DownloadAsync(BrowserFetcher.DefaultRevision);
        }

        public async Task<Page> LoadPage(string url)
        {
            Browser browser = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                //Devtools = true,
                ExecutablePath = @"C:\HackathoneDemo\resources\chrome-win\chrome.exe",
                Headless = false
            });

            // Create a new page and go to Bing Maps
            Page page = await browser.NewPageAsync();
            await page.GoToAsync(url);
            await page.WaitForSelectorAsync("#username");
            await page.FocusAsync("#username");
            await page.Keyboard.TypeAsync("dp@nike.com");
            await page.WaitForSelectorAsync("#password");
            await page.FocusAsync("#password");
            await page.Keyboard.TypeAsync("DPNike2018!");
            //var timeout = TimeSpan.FromSeconds(6).Milliseconds;
            //var opitions = new NavigationOptions();
            //opitions.WaitUntil = new[] { WaitUntilNavigation.Networkidle0 };
            //opitions.Timeout = 4000;
            
            await page.ClickAsync("#btnLogin");

             page.WaitForNavigationAsync();
            //await page.WaitForNavigationAsync(opitions);
            //await page.WaitForTimeoutAsync(timeout);

            // WaitUntilNavigation
            new NavigationOptions().WaitUntil = new[]
            {
                WaitUntilNavigation.Load,
                WaitUntilNavigation.DOMContentLoaded,
                WaitUntilNavigation.Networkidle0,
                WaitUntilNavigation.Networkidle2
            };
            return page;
        }
    }
}
