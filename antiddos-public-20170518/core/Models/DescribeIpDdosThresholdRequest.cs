// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeIpDdosThresholdRequest : TeaModel {
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
        /// The ID of the asset.
        /// 
        /// > You can call the [DescribeInstanceIpAddress](https://help.aliyun.com/document_detail/429562.html) operation to query the IDs of ECS instances, SLB instances, and EIPs within the current Alibaba Cloud account.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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

        /// <summary>
        /// The IP address of the asset.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InternetIp")]
        [Validation(Required=false)]
        public string InternetIp { get; set; }

    }

}
