// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListUserWafRulesetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance usage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InstanceUsage")]
        [Validation(Required=false)]
        public long? InstanceUsage { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
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
        /// <para>A list of WAF ruleset objects.</para>
        /// </summary>
        [NameInMap("Rulesets")]
        [Validation(Required=false)]
        public List<ListUserWafRulesetsResponseBodyRulesets> Rulesets { get; set; }
        public class ListUserWafRulesetsResponseBodyRulesets : TeaModel {
            /// <summary>
            /// <para>The WAF ruleset description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The WAF ruleset ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The WAF ruleset name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The WAF rule execution phase. Possible values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>http_whitelist</c>: Whitelist rule</para>
            /// </description></item>
            /// <item><description><para><c>http_custom</c>: Custom rule</para>
            /// </description></item>
            /// <item><description><para><c>http_managed</c>: Managed rule</para>
            /// </description></item>
            /// <item><description><para><c>http_anti_scan</c>: Scan protection rule</para>
            /// </description></item>
            /// <item><description><para><c>http_ratelimit</c>: Rate limit rule</para>
            /// </description></item>
            /// <item><description><para><c>ip_access_rule</c>: IP access rule</para>
            /// </description></item>
            /// <item><description><para><c>http_bot</c>: Bot rule</para>
            /// </description></item>
            /// <item><description><para><c>http_security_level_rule</c>: Security rule</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>http_custom</para>
            /// </summary>
            [NameInMap("Phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            /// <summary>
            /// <para>The WAF ruleset position.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Position")]
            [Validation(Required=false)]
            public long? Position { get; set; }

            /// <summary>
            /// <para>The WAF ruleset status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

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
