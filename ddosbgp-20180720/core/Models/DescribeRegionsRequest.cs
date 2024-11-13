// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the region. The default value is <b>cn-hangzhou</b>. If the default value is used, the regions of cloud assets that can be protected by Anti-DDoS Origin in the China (Hangzhou) region are queried.</para>
        /// <para>If you want to specify another value for <b>RegionId</b>, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and Zones</a>.</para>
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
