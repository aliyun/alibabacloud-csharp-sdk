// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListMarketplaceAppPluginsRequest : TeaModel {
        /// <summary>
        /// <para>Filters the results by category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;CateName\&quot;: u\&quot;\u57fa\u7840\u533b\u5b66\u7efc\u5408\&quot;, \&quot;CateId\&quot;: 1000675720, \&quot;Level\&quot;: 2, \&quot;Type\&quot;: \&quot;default\&quot;, \&quot;ParentId\&quot;: 1000675713}</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The search keyword.</para>
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

        /// <summary>
        /// <para>Filters the results by platform. Valid values: web and miniprogram.</para>
        /// 
        /// <b>Example:</b>
        /// <para>linux/amd64</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

    }

}
