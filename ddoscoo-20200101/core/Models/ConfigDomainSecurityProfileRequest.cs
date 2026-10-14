// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigDomainSecurityProfileRequest : TeaModel {
        /// <summary>
        /// <para>Not in use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Cluster")]
        [Validation(Required=false)]
        public string Cluster { get; set; }

        /// <summary>
        /// <para>The Anti-DDoS Global Mitigation Policy for Protection for Website Services. The structure is as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>global_rule_mode</b>: String type. Optional. The protection level of the DDoS global mitigation feature. Valid values:<list type="bullet">
        /// <item><description><b>weak</b>: Loose.</description></item>
        /// <item><description><b>default</b>: Normal.</description></item>
        /// <item><description><b>hard</b>: Strict.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>global_rule_enable</b>: Integer type. Optional. The switch of the DDoS global mitigation feature. Valid values:<list type="bullet">
        /// <item><description><b>0</b>: Shutdown.</description></item>
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>The Blacklist/Whitelist feature of the custom mitigation policies for Protection for Website Services. The structure is as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>bwlist_enable</b>: Integer type. Optional. The switch of the custom mitigation policy blacklist/whitelist. Valid values:<list type="bullet">
        /// <item><description><b>0</b>: Shutdown.</description></item>
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;global_rule_mode&quot;:&quot;hard&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The domain name of the website service.</para>
        /// <remarks>
        /// <para>The domain name must have a website forwarding rule configured. You can call <a href="https://help.aliyun.com/document_detail/91724.html">DescribeDomains</a> to query all domain names.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

    }

}
