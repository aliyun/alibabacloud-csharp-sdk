// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWafRulesetsRequest : TeaModel {
        /// <summary>
        /// <para>The page number for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The execution phase for WAF rules.</para>
        /// <list type="bullet">
        /// <item><description><para><c>http_whitelist</c>: whitelist rule</para>
        /// </description></item>
        /// <item><description><para><c>http_custom</c>: custom rule</para>
        /// </description></item>
        /// <item><description><para><c>http_managed</c>: managed rule</para>
        /// </description></item>
        /// <item><description><para><c>http_anti_scan</c>: scan protection rule</para>
        /// </description></item>
        /// <item><description><para><c>http_ratelimit</c>: rate-limiting rule</para>
        /// </description></item>
        /// <item><description><para><c>ip_access_rule</c>: IP access rule</para>
        /// </description></item>
        /// <item><description><para><c>http_bot</c>: bot rule</para>
        /// </description></item>
        /// <item><description><para><c>http_security_level_rule</c>: security rule</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>http_bot</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>A JSON object containing query parameters for filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http_bot</para>
        /// </summary>
        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public ListWafRulesetsRequestQueryArgs QueryArgs { get; set; }
        public class ListWafRulesetsRequestQueryArgs : TeaModel {
            /// <summary>
            /// <para>A keyword for a fuzzy search on the ID or name of a ruleset or rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("AnyLike")]
            [Validation(Required=false)]
            public string AnyLike { get; set; }

            /// <summary>
            /// <para>Specifies whether to sort in descending order.</para>
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public bool? Desc { get; set; }

            /// <summary>
            /// <para>A keyword for a fuzzy search on ruleset names.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("NameLike")]
            [Validation(Required=false)]
            public string NameLike { get; set; }

            /// <summary>
            /// <para>Specifies the field for sorting the results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("OrderBy")]
            [Validation(Required=false)]
            public string OrderBy { get; set; }

        }

        /// <summary>
        /// <para>The ID of the site. Get this ID by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The site\&quot;s configuration version. For sites with configuration version management enabled, use this parameter to specify the version. The default is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
