// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetWafRulesetResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the WAF ruleset. You can call the <a href="https://help.aliyun.com/document_detail/2878359.html">ListWafRulesets</a> operation to obtain the ID.</para>
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
        /// <para>The WAF rule execution phase. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>http_whitelist: whitelist rules</description></item>
        /// <item><description>http_custom: custom rules</description></item>
        /// <item><description>http_managed: managed rules</description></item>
        /// <item><description>http_anti_scan: scan protection rules</description></item>
        /// <item><description>http_ratelimit: rate limiting rules</description></item>
        /// <item><description>ip_access_rule: IP access rules</description></item>
        /// <item><description>http_bot: advanced mode bots</description></item>
        /// <item><description>http_security_level_rule: security rules</description></item>
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
        /// <para>The shared configuration of rules in the ruleset.</para>
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

}
