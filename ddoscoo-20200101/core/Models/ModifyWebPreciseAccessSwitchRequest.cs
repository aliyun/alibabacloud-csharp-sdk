// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyWebPreciseAccessSwitchRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the Accurate Access Control policy. This parameter is a JSON string. The string contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PreciseRuleEnable</b>: the status of the Accurate Access Control policy. This field is required and must be of the INTEGER type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disables the policy.</description></item>
        /// <item><description><b>1</b>: enables the policy.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;PreciseRuleEnable&quot;:0}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The domain name of the website.</para>
        /// <remarks>
        /// <para>A forwarding rule must be configured for a domain name. You can call the <a href="https://help.aliyun.com/document_detail/91724.html">DescribeDomains</a> operation to query all domain names.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
