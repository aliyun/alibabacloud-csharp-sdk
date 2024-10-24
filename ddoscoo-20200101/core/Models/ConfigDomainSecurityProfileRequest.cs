// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigDomainSecurityProfileRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is unavailable.</para>
        /// </summary>
        [NameInMap("Cluster")]
        [Validation(Required=false)]
        public string Cluster { get; set; }

        /// <summary>
        /// <para>The configurations for the global mitigation policy feature. The configurations include the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>global_rule_mode</b>: optional. The mode for the global mitigation policy feature. Data type: string. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>weak</b>: loose.</description></item>
        /// <item><description><b>default</b>: normal.</description></item>
        /// <item><description><b>hard</b>: strict.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>global_rule_enable</b>: optional. Specifies whether to enable the global mitigation policy feature. Data type: string. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disabled.</description></item>
        /// <item><description><b>1</b>: enabled.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;global_rule_mode\&quot;:\&quot;hard\&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The domain name of the website.</para>
        /// <remarks>
        /// <para> A forwarding rule must be configured for the domain name. You can call the <a href="https://help.aliyun.com/document_detail/91724.html">DescribeDomains</a> operation to query all domain names.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>live.abcde.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

    }

}
