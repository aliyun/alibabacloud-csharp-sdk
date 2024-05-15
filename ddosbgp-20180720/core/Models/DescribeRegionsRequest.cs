// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// The region ID to query. The default value is **cn-hangzhou**, which indicates that the regions of cloud assets that are supported by an Anti-DDoS Origin instance in the China (Hangzhou) region are queried.
        /// 
        /// For more information about the IDs of other regions, see [Regions and zones](https://help.aliyun.com/document_detail/40654.html).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the Anti-DDoS Origin instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.
        /// 
        /// For more information about resource groups, see [Create a resource group](https://help.aliyun.com/document_detail/94485.html).
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
