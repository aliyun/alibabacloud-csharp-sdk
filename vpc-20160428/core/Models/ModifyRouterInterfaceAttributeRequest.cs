// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyRouterInterfaceAttributeRequest : TeaModel {
        /// <summary>
        /// Specifies whether to delete the health check IP addresses configured on the router interface. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false** (default): no
        /// </summary>
        [NameInMap("DeleteHealthCheckIp")]
        [Validation(Required=false)]
        public bool? DeleteHealthCheckIp { get; set; }

        /// <summary>
        /// The description of the router interface.
        /// 
        /// The value must be 2 to 256 characters in length. It must start with a letter but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The rate of the heath check. Unit: milliseconds. The recommended value is **2000**. This value specifies the interval at which probe packets are sent during a health check.
        /// 
        /// In this example, **HcThreshold** is set to **8** and **HcRate** is set to **2000**. In this example, probe packets are sent from **HealthCheckSourceIp** (source address) to **HealthCheckTargetIp** (destination address) every 2,000 seconds. If no response is returned for eight consecutive times, the health check fails.
        /// </summary>
        [NameInMap("HcRate")]
        [Validation(Required=false)]
        public int? HcRate { get; set; }

        /// <summary>
        /// The health check threshold. Unit: packets. We recommend that you set the value to **8**. This value specifies the number of probe packets that are sent during a health check.
        /// </summary>
        [NameInMap("HcThreshold")]
        [Validation(Required=false)]
        public int? HcThreshold { get; set; }

        /// <summary>
        /// The source IP address that is used to perform health checks. The source IP address must be an idle IP address of the local virtual private cloud (VPC).
        /// 
        /// >  You can set this parameter if an Express Connect circuit is used.
        /// </summary>
        [NameInMap("HealthCheckSourceIp")]
        [Validation(Required=false)]
        public string HealthCheckSourceIp { get; set; }

        /// <summary>
        /// The destination IP address that is used to perform health checks.
        /// 
        /// >  This parameter is required when the **HealthCheckSourceIp** parameter is set.
        /// </summary>
        [NameInMap("HealthCheckTargetIp")]
        [Validation(Required=false)]
        public string HealthCheckTargetIp { get; set; }

        /// <summary>
        /// The name of the router interface.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the peer router interface.
        /// </summary>
        [NameInMap("OppositeInterfaceId")]
        [Validation(Required=false)]
        public string OppositeInterfaceId { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the peer router interface belongs.
        /// </summary>
        [NameInMap("OppositeInterfaceOwnerId")]
        [Validation(Required=false)]
        public long? OppositeInterfaceOwnerId { get; set; }

        /// <summary>
        /// The ID of the peer router.
        /// </summary>
        [NameInMap("OppositeRouterId")]
        [Validation(Required=false)]
        public string OppositeRouterId { get; set; }

        /// <summary>
        /// The type of router to which the peer router interface belongs. Valid values:
        /// 
        /// *   **VRouter**: vRouter
        /// *   **VBR** (default): virtual border router (VBR)
        /// </summary>
        [NameInMap("OppositeRouterType")]
        [Validation(Required=false)]
        public string OppositeRouterType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region to which the router interface belongs.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the router interface.
        /// </summary>
        [NameInMap("RouterInterfaceId")]
        [Validation(Required=false)]
        public string RouterInterfaceId { get; set; }

    }

}
