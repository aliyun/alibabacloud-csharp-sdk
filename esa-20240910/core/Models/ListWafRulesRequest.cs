// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWafRulesRequest : TeaModel {
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
        /// <para>The page size for pagination.</para>
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
        /// <item><description>http_whitelist: whitelist rule</description></item>
        /// <item><description>http_custom: custom rule</description></item>
        /// <item><description>http_managed: managed rule</description></item>
        /// <item><description>http_anti_scan: scan protection rule</description></item>
        /// <item><description>http_ratelimit: frequency control rule</description></item>
        /// <item><description>ip_access_rule: IP access rule</description></item>
        /// <item><description>http_bot: advanced mode bots</description></item>
        /// <item><description>http_security_level_rule: security rule</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http_custom</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>The query filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http_custom</para>
        /// </summary>
        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public ListWafRulesRequestQueryArgs QueryArgs { get; set; }
        public class ListWafRulesRequestQueryArgs : TeaModel {
            /// <summary>
            /// <para>The value in IP access control for fuzzy match.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.1</para>
            /// </summary>
            [NameInMap("ConfigValueLike")]
            [Validation(Required=false)]
            public string ConfigValueLike { get; set; }

            /// <summary>
            /// <para>Specifies whether to reverse the sort order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public bool? Desc { get; set; }

            /// <summary>
            /// <para>The WAF rule ID for exact match.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20000001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The WAF rule ID or name for fuzzy match.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("IdNameLike")]
            [Validation(Required=false)]
            public string IdNameLike { get; set; }

            /// <summary>
            /// <para>The WAF rule name for fuzzy match.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("NameLike")]
            [Validation(Required=false)]
            public string NameLike { get; set; }

            /// <summary>
            /// <para>Sorts the returned list by a specified column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>position</para>
            /// </summary>
            [NameInMap("OrderBy")]
            [Validation(Required=false)]
            public string OrderBy { get; set; }

            /// <summary>
            /// <para>The WAF rule status for exact match.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the WAF ruleset. You can call the <a href="https://help.aliyun.com/document_detail/2878359.html">ListWafRulesets</a> operation to obtain the ruleset ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000001</para>
        /// </summary>
        [NameInMap("RulesetId")]
        [Validation(Required=false)]
        public long? RulesetId { get; set; }

        /// <summary>
        /// <para>The site ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The version number of the site configuration. For sites with version management enabled, you can use this parameter to specify the site version for which the configuration takes effect. The default value is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
