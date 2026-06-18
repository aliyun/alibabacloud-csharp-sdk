// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetWafRulesetResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the WAF ruleset. You can obtain this ID by calling the <a href="https://help.aliyun.com/document_detail/2878359.html">ListWafRulesets</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The ruleset name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The execution phase of the WAF ruleset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>http_whitelist</c>: A whitelist rule</para>
        /// </description></item>
        /// <item><description><para><c>http_custom</c>: A custom rule</para>
        /// </description></item>
        /// <item><description><para><c>http_managed</c>: A managed rule</para>
        /// </description></item>
        /// <item><description><para><c>http_anti_scan</c>: A scan protection rule</para>
        /// </description></item>
        /// <item><description><para><c>http_ratelimit</c>: A rate limit rule</para>
        /// </description></item>
        /// <item><description><para><c>ip_access_rule</c>: An IP access rule</para>
        /// </description></item>
        /// <item><description><para><c>http_bot</c>: A bot rule</para>
        /// </description></item>
        /// <item><description><para><c>http_security_level_rule</c>: A security rule</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http_bot</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

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
        /// <para>The list of rule configurations in the ruleset.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<WafRuleConfig> Rules { get; set; }

        /// <summary>
        /// <para>The shared configuration for rules within the ruleset.</para>
        /// </summary>
        [NameInMap("Shared")]
        [Validation(Required=false)]
        public WafBatchRuleShared Shared { get; set; }

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
        /// <para>The time when the ruleset was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
