// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeDdosThresholdRequest : TeaModel {
        /// <summary>
        /// The region ID of the asset.
        /// 
        /// > You can call the [DescribeRegions](https://help.aliyun.com/document_detail/353250.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DdosRegionId")]
        [Validation(Required=false)]
        public string DdosRegionId { get; set; }

        /// <summary>
        /// The type of the threshold. Valid values:
        /// 
        /// *   **defense**: traffic scrubbing threshold
        /// *   **blackhole**: DDoS mitigation threshold
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DdosType")]
        [Validation(Required=false)]
        public string DdosType { get; set; }

        /// <summary>
        /// The ID of asset N to query.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// The type of the asset. Valid values:
        /// 
        /// *   **ecs**: ECS instance
        /// *   **slb**: SLB instance
        /// *   **eip**: EIP
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

    }

}
