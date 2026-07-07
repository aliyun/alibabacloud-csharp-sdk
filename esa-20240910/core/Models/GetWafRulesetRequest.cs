// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetWafRulesetRequest : TeaModel {
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
        /// 
        /// <b>Example:</b>
        /// <para>http_bot</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>The site ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
