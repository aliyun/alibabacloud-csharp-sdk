// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DeleteIpRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Anti-DDoS Origin instance.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/118698.html">DescribeInstanceList</a> to query the IDs of all Anti-DDoS Origin instances.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddosbgp-cn-npk1z7t9****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>A list of IP addresses to remove from the protected objects of the Anti-DDoS Origin instance. Specify the list as a string that is a JSON array. Each element in the array is a struct that contains the following field:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ip</b>: The IP address to remove. This parameter is a string and is required.</para>
        /// <remarks>
        /// <para>The IP address must be in the protection list of the Anti-DDoS Origin instance.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ip&quot;:&quot;1.XX.XX.1&quot;},{&quot;ip&quot;:&quot;2.XX.XX.2&quot;}]</para>
        /// </summary>
        [NameInMap("IpList")]
        [Validation(Required=false)]
        public string IpList { get; set; }

        /// <summary>
        /// <para>The region ID of the Anti-DDoS Origin instance.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/118703.html">DescribeRegions</a> to query all regions that Anti-DDoS Origin supports.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the resource group to which the Anti-DDoS Origin instance belongs in Resource Management. If you leave this parameter empty, the instance belongs to the default resource group.</para>
        /// <para>For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/94485.html">Create a resource group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2pz25js****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        [Obsolete]
        public string ResourceGroupId { get; set; }

    }

}
