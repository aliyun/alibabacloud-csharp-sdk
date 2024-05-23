// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeHostGroupElasticStrategyParametersRequest : TeaModel {
        /// <summary>
        /// The name of the dedicated cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DedicatedHostGroupName")]
        [Validation(Required=false)]
        public string DedicatedHostGroupName { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/26243.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
