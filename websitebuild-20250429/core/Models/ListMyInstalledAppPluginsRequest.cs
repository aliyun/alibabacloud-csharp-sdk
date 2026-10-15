// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListMyInstalledAppPluginsRequest : TeaModel {
        /// <summary>
        /// <para>Filters results by category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Status\&quot;: 0, \&quot;Name\&quot;: \&quot;UELBNUP\&quot;, \&quot;BizCode\&quot;: \&quot;\&quot;, \&quot;CategoryId\&quot;: 30000655368, \&quot;ParentCategoryId\&quot;: 30000655367}</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The search keyword. Matches against name or description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>${\&quot;wget JiexJPWT.popscan.xaliyun.com\&quot;}</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
