// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class ModifyIpDefenseThresholdRequest : TeaModel {
        /// <summary>
        /// Specifies the traffic scrubbing threshold. Unit: Mbit/s. The traffic scrubbing threshold cannot exceed the peak inbound or outbound Internet traffic, whichever is larger, of the asset.
        /// 
        /// You can use the monitoring tool that is provided by the asset to query the Internet traffic of the asset:
        /// 
        /// *   For more information about how to query the Internet traffic of an ECS instance, see [Query monitoring information of an instance](https://help.aliyun.com/document_detail/25482.html).
        /// *   For more information about how to query the number of packets of an SLB instance, see [View monitoring data in the console](https://help.aliyun.com/document_detail/85982.html).
        /// </summary>
        [NameInMap("Bps")]
        [Validation(Required=false)]
        public int? Bps { get; set; }

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
        /// The ID of the asset.
        /// 
        /// > You can call the [DescribeInstance](https://help.aliyun.com/document_detail/354191.html) operation to query the IDs of ECS instances, SLB instances, and EIPs within the current Alibaba Cloud account.
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

        /// <summary>
        /// Specifies whether to automatically adjust the scrubbing threshold based on the traffic load on the asset. Valid values:
        /// 
        /// *   **true**: automatically adjusts the scrubbing threshold. You do not need to configure the **Bps** and **Pps** parameters.
        /// *   **false**: The scrubbing threshold is not automatically adjusted. You must configure the **Bps** and **Pps** parameters. This is the default value.
        /// </summary>
        [NameInMap("IsAuto")]
        [Validation(Required=false)]
        public bool? IsAuto { get; set; }

        /// <summary>
        /// Specifies the packet scrubbing threshold. Unit: packets per second (pps).
        /// 
        /// The packet scrubbing threshold cannot exceed the peak number of inbound or outbound packets, whichever is larger, of the asset. You can use the monitoring tool that is provided by the asset to query the number of packets of the asset:
        /// 
        /// *   For more information about how to query the number of packets of an ECS instance, see [Query monitoring information of an instance](https://help.aliyun.com/document_detail/25482.html).
        /// *   For more information about how to query the number of packets of an SLB instance, see [View monitoring data in the console](https://help.aliyun.com/document_detail/85982.html).
        /// </summary>
        [NameInMap("Pps")]
        [Validation(Required=false)]
        public int? Pps { get; set; }

    }

}
