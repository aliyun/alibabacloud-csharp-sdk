// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class EnableCenVbrHealthCheckRequest : TeaModel {
        /// <summary>
        /// The ID of the Cloud Enterprise Network (CEN) instance.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The time interval at which probe packets are sent during a health check. Unit: seconds. Default value: **2**. Valid values: **2 to 3**.
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// Specifies whether to enable probing during the health check. Valid values:
        /// 
        /// *   **true**: yes
        /// 
        ///         If you enable probing, the system does not switch to another route if the detected route is not reachable. 
        /// 
        ///           Make sure that a redundant route is available. Otherwise, network disconnections may occur. 
        /// 
        /// *   **false** (default): no
        /// 
        ///         Probing is disabled by default. If a redundant route is specified, the system switches to the redundant route if the detected route is not reachable.
        /// </summary>
        [NameInMap("HealthCheckOnly")]
        [Validation(Required=false)]
        public bool? HealthCheckOnly { get; set; }

        /// <summary>
        /// The source IP address for the health check. You can set the source IP address in the following ways:
        /// 
        /// *   **Automatic IP Address** (recommended): The system automatically assigns an IP address from the 100.96.0.0/16 CIDR block.
        /// *   **Custom IP Address**: You must specify an idle IP address from the 10.0.0.0/8, 192.168.0.0/16, or 172.16.0.0/12 CIDR block. The specified IP address cannot be the IP address of the VBR on the Alibaba Cloud side, the IP address of the VBR on the customer side, or other IP addresses with which the VBR communicates through the CEN instance.
        /// </summary>
        [NameInMap("HealthCheckSourceIp")]
        [Validation(Required=false)]
        public string HealthCheckSourceIp { get; set; }

        /// <summary>
        /// The destination IP address for the health check.
        /// 
        /// Set the destination IP address to the IP address of the VBR on the customer side.
        /// </summary>
        [NameInMap("HealthCheckTargetIp")]
        [Validation(Required=false)]
        public string HealthCheckTargetIp { get; set; }

        /// <summary>
        /// The number of probe packets that are sent during a health check. Unit: packets. Valid values: **3 to 8**. Default value: **8**.
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the VBR.
        /// </summary>
        [NameInMap("VbrInstanceId")]
        [Validation(Required=false)]
        public string VbrInstanceId { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the VBR belongs.
        /// 
        /// > This parameter is required if the VBR and the CEN instance belong to different Alibaba Cloud accounts.
        /// </summary>
        [NameInMap("VbrInstanceOwnerId")]
        [Validation(Required=false)]
        public long? VbrInstanceOwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the VBR is deployed.
        /// 
        /// You can call the [DescribeChildInstanceRegions](~~132080~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("VbrInstanceRegionId")]
        [Validation(Required=false)]
        public string VbrInstanceRegionId { get; set; }

    }

}
