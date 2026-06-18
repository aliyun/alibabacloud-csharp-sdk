// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetWafRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The rule configuration.</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public WafRuleConfig Config { get; set; }

        /// <summary>
        /// <para>The ID of the WAF rule. You can get this ID by calling the <a href="https://help.aliyun.com/document_detail/2878257.html">ListWafRules</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The execution phase of the WAF rule.</para>
        /// <list type="bullet">
        /// <item><description><para><c>http_whitelist</c>: A whitelist rule</para>
        /// </description></item>
        /// <item><description><para><c>http_custom</c>: A custom rule</para>
        /// </description></item>
        /// <item><description><para><c>http_managed</c>: A managed rule</para>
        /// </description></item>
        /// <item><description><para><c>http_anti_scan</c>: A scan protection rule</para>
        /// </description></item>
        /// <item><description><para><c>http_ratelimit</c>: A rate limiting rule</para>
        /// </description></item>
        /// <item><description><para><c>ip_access_rule</c>: An IP access rule</para>
        /// </description></item>
        /// <item><description><para><c>http_bot</c>: A bot management rule</para>
        /// </description></item>
        /// <item><description><para><c>http_security_level_rule</c>: A security rule</para>
        /// </description></item>
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
        /// <para>The position of the rule in the ruleset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Position")]
        [Validation(Required=false)]
        public long? Position { get; set; }

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
        /// <para>The ID of the WAF ruleset. You can get this ID by calling the <a href="https://help.aliyun.com/document_detail/2878359.html">ListWafRulesets</a> operation.</para>
        /// </summary>
        [NameInMap("RulesetId")]
        [Validation(Required=false)]
        public long? RulesetId { get; set; }

        /// <summary>
        /// <para>The status of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The time the rule was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
