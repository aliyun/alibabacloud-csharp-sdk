// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWafRulesetsRequest : TeaModel {
        /// <summary>
        /// <para>The page number. Specifies the current page number for paging queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size. Specifies the number of records per page for paging queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The WAF rule execution phase. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>http_whitelist: whitelist rules</description></item>
        /// <item><description>http_custom: custom rules</description></item>
        /// <item><description>http_managed: managed rules</description></item>
        /// <item><description>http_anti_scan: scan protection rules</description></item>
        /// <item><description>http_ratelimit: frequency control rules</description></item>
        /// <item><description>ip_access_rule: IP access rules</description></item>
        /// <item><description>http_bot: advanced mode bots</description></item>
        /// <item><description>http_security_level_rule: security rules</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>http_bot</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>The query parameters, passed in JSON format, including various filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http_bot</para>
        /// </summary>
        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public ListWafRulesetsRequestQueryArgs QueryArgs { get; set; }
        public class ListWafRulesetsRequestQueryArgs : TeaModel {
            /// <summary>
            /// <para>The fuzzy match string for the ruleset ID, ruleset name, rule ID, or rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("AnyLike")]
            [Validation(Required=false)]
            public string AnyLike { get; set; }

            /// <summary>
            /// <para>Specifies whether to sort the results in descending order.</para>
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public bool? Desc { get; set; }

            /// <summary>
            /// <para>The fuzzy match string for the ruleset name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("NameLike")]
            [Validation(Required=false)]
            public string NameLike { get; set; }

            /// <summary>
            /// <para>The column by which to sort the results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("OrderBy")]
            [Validation(Required=false)]
            public string OrderBy { get; set; }

        }

        /// <summary>
        /// <para>The site ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the site ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The version number of the site configuration. For sites with configuration version management enabled, you can use this parameter to specify the site version for which the configuration takes effect. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
