// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeCapRequest : TeaModel {
        /// <summary>
        /// The start time of the DDoS attack event. The value is a UNIX timestamp. Unit: milliseconds.
        /// 
        /// > You can call the [DescribeDdosEventList](https://help.aliyun.com/document_detail/354236.html) operation to query the start time of each DDoS attack event that occurred on an asset.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BegTime")]
        [Validation(Required=false)]
        public long? BegTime { get; set; }

        /// <summary>
        /// The region ID of the asset that is under DDoS attacks. The asset is assigned a public IP address.
        /// 
        /// > You can call the [DescribeRegions](https://help.aliyun.com/document_detail/353250.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DdosRegionId")]
        [Validation(Required=false)]
        public string DdosRegionId { get; set; }

        /// <summary>
        /// The ID of the asset that is under DDoS attacks.
        /// 
        /// > You can call the [DescribeInstance](https://help.aliyun.com/document_detail/354191.html) operation to query the IDs of ECS instances, SLB instances, and EIPs within the current Alibaba Cloud account.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The type of the asset that is under DDoS attacks. Valid values:
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
        /// The public IP address of the asset that is under DDoS attacks.
        /// </summary>
        [NameInMap("InternetIp")]
        [Validation(Required=false)]
        public string InternetIp { get; set; }

    }

}
