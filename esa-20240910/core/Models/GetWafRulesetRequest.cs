// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetWafRulesetRequest : TeaModel {
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
        /// 
        /// <b>Example:</b>
        /// <para>http_bot</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>The site ID. You can obtain this ID by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
