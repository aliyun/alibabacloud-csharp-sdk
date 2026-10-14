// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyWebAreaBlockSwitchRequest : TeaModel {
        /// <summary>
        /// <para>The status of the Location Blacklist feature (for domain names). This parameter is a string that is converted from a JSON struct. The JSON struct contains the following parameter:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RegionblockEnable</b>: An Integer value that is required. The status of the Location Blacklist feature (for domain names). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: enables the feature.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: disables the feature.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;RegionblockEnable&quot;: 1}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The domain name for which you want to set the Location Blacklist feature.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/91724.html">DescribeDomains</a> to query all domain names that are protected by Anti-DDoS Proxy.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the Anti-DDoS Proxy instance belongs in Resource Management.</para>
        /// <para>If you do not set this parameter, the default resource group is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2pz25js****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
