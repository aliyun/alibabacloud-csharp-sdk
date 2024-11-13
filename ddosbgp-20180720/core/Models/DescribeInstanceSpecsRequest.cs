// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeInstanceSpecsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Anti-DDoS Origin instance. This parameter is a string that consists of JSON arrays. Each element in a JSON array indicates an instance ID. If you want to query more than one instance, separate instance IDs with commas (,).</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/118698.html">DescribeInstanceList</a> operation to query the IDs of all Anti-DDoS Origin instances in a specific region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ddosbgp-cn-n6w1r7nz****&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIdList")]
        [Validation(Required=false)]
        public string InstanceIdList { get; set; }

        /// <summary>
        /// <para>The region ID of the Anti-DDoS Origin instance. Default value: <b>cn-hangzhou</b>, which indicates the China (Hangzhou) region.</para>
        /// <remarks>
        /// <para> If your instance does not reside in the China (Hangzhou) region, you must set this parameter to the region ID of your instance. You can call the <a href="https://help.aliyun.com/document_detail/118703.html">DescribeRegions</a> operation to query the regions of assets that can be protected by Anti-DDoS Origin in a specific region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the Anti-DDoS Origin instance belongs in Resource Management. This parameter is empty by default, which indicates that the Anti-DDoS Origin instance belongs to the default resource group.</para>
        /// <para>For information about resource groups, see <a href="https://help.aliyun.com/document_detail/94485.html">Create a resource group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2pz25js****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
