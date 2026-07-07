// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWafRulesetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of WAF rulesets used by the instance in this WAF execution phase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InstanceUsage")]
        [Validation(Required=false)]
        public long? InstanceUsage { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36af3fcc-43d0-441c-86b1-428951dc8225</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of rulesets, including detailed information about each ruleset.</para>
        /// </summary>
        [NameInMap("Rulesets")]
        [Validation(Required=false)]
        public List<ListWafRulesetsResponseBodyRulesets> Rulesets { get; set; }
        public class ListWafRulesetsResponseBodyRulesets : TeaModel {
            /// <summary>
            /// <para>The list of match objects.</para>
            /// </summary>
            [NameInMap("Fields")]
            [Validation(Required=false)]
            public List<string> Fields { get; set; }

            /// <summary>
            /// <para>The ID of the WAF ruleset. You can call the <a href="https://help.aliyun.com/document_detail/2878359.html">ListWafRulesets</a> operation to obtain the ruleset ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The ruleset name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

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
            /// <para>The ruleset status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The protection target type in http_bot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>web</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <para>The list of rule types.</para>
            /// </summary>
            [NameInMap("Types")]
            [Validation(Required=false)]
            public List<string> Types { get; set; }

            /// <summary>
            /// <para>The last modification time of the ruleset.</para>
            /// <para>Format: RFC 3339 / ISO 8601, UTC time zone (ending with Z).</para>
            /// <para>Example: 2026-06-10T14:23:45Z</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The number of WAF rulesets used by the site in this WAF execution phase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SiteUsage")]
        [Validation(Required=false)]
        public long? SiteUsage { get; set; }

        /// <summary>
        /// <para>The total number of records after filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
