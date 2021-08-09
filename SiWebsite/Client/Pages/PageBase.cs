using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiWebsite.Client.Pages
{
    public class PageBase : LayoutComponentBase
    {
        [Inject]
        public IJSRuntime JS { get; set; }

        public async Task<bool> IsMobileCheck()
        {
           return await JS.InvokeAsync<bool>("isMobile");
        }

        public bool IsMobile { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {

            await base.OnAfterRenderAsync(firstRender);

            if (firstRender)
            {
                this.IsMobile = await this.IsMobileCheck();
                this.StateHasChanged();
            }
        }

    }
}
