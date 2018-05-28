﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Pagination
{
    [HtmlTargetElement("abp-paginator")]
    public class AbpPaginationTagHelper : AbpTagHelper<AbpPaginationTagHelper, AbpPaginationTagHelperService>
    {
        public PagerModel Model { get; set; }

        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public AbpPaginationTagHelper(AbpPaginationTagHelperService tagHelperService)
            : base(tagHelperService)
        {

        }
    }
}