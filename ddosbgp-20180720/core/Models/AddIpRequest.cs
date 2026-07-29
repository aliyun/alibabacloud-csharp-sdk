// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class AddIpRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Anti-DDoS Origin instance to manage.</para>
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
        /// <para>The list of IP addresses to add to the Anti-DDoS Origin instance for protection. The value is a string that is converted from a JSON array. Each element in the JSON array is a struct that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ip</b>: The IP address to add. This parameter is of the String type and is required.</para>
        /// </description></item>
        /// <item><description><para><b>member_uid</b>: The ID of the member account that owns the asset. This parameter is of the String type and is optional. Specify this parameter only when you add an asset that belongs to a member account. For example: [{&quot;ip&quot;:&quot;121.41.XX.XX&quot;,&quot;member_uid&quot;:&quot;120100811162\<em>\</em>\<em>\</em>&quot;}]</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ip&quot;:&quot;121.41.XX.XX&quot;},{&quot;ip&quot;:&quot;121.42.XX.XX&quot;}]</para>
        /// </summary>
        [NameInMap("IpList")]
        [Validation(Required=false)]
        public string IpList { get; set; }

        /// <summary>
        /// <para>The region ID of the Anti-DDoS Origin instance.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/118703.html">DescribeRegions</a> to query information about all regions that Anti-DDoS Origin supports.</para>
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
        /// <para>The ID of the resource group in Resource Management to which the Anti-DDoS Origin instance belongs. If you leave this parameter empty, the instance is added to the default resource group.</para>
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
