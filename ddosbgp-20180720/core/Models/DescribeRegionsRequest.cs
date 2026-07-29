// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// <para>The region ID to query. Default value: <b>ap-southeast-1</b>, which indicates that the regions of cloud assets that can be protected by the Anti-DDoS Origin instance in the China (Hangzhou) region are queried.</para>
        /// <para>To query other region IDs, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a> to obtain the corresponding <b>RegionId</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the Anti-DDoS Origin instance belongs in Resource Management. By default, this parameter is empty, which indicates that the instance belongs to the default resource group.</para>
        /// <para>For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/94485.html">Create a resource group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2pz25js****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
