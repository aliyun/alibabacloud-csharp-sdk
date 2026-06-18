// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateWafRulesetRequest : TeaModel {
        /// <summary>
        /// <para>The name of the WAF ruleset.</para>
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
        /// <item><description><para>http_whitelist</para>
        /// </description></item>
        /// <item><description><para>http_custom</para>
        /// </description></item>
        /// <item><description><para>http_managed</para>
        /// </description></item>
        /// <item><description><para>http_anti_scan</para>
        /// </description></item>
        /// <item><description><para>http_ratelimit</para>
        /// </description></item>
        /// <item><description><para>ip_access_rule</para>
        /// </description></item>
        /// <item><description><para>http_bot</para>
        /// </description></item>
        /// <item><description><para>http_security_level_rule</para>
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
        /// <para>The site ID. To get this ID, call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The site configuration version. This parameter applies only if versioning is enabled for the site. The default is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
