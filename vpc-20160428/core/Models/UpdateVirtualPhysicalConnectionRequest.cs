// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UpdateVirtualPhysicalConnectionRequest : TeaModel {
        /// <summary>
        /// The region ID of the hosted connection.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("ExpectSpec")]
        [Validation(Required=false)]
        public string ExpectSpec { get; set; }

        /// <summary>
        /// Specifies whether to check the request without performing the operation. Valid values:
        /// 
        /// *   **true**: checks the request without performing the operation. The VLAN ID of the hosted connection is not changed. The system checks the required parameters, request syntax, and instance status. If the check fails, the corresponding error message is returned. If the request passes the check, the system returns the ID of the request.
        /// *   **false** (default): sends the request. If the request passes the check, the VLAN ID of the hosted connection is changed.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Indicates whether the VLAN ID of the hosted connection is changed. Valid values:
        /// 
        /// *   **true**: The VLAN ID of the hosted connection is changed.
        /// *   **false**: The VLAN ID of the hosted connection is not changed.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The estimated bandwidth value of the hosted connection. The estimated bandwidth value takes effect after the payment is completed.
        /// 
        /// Valid values: **50M**, **100M**, **200M**, **300M**, **400M**, **500M**, **1G**, **2G**, **5G**, **8G**, and **10G**.
        /// 
        /// >  By default, the values of **2G**, **5G**, **8G**, and **10G** are unavailable. If you want to specify these values, contact your customer manager.
        /// 
        /// **M** indicates Mbit/s and **G** indicates Gbit/s.
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among all requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses **RequestId** as **ClientToken**. The value of **RequestId** in each API request may be different.
        /// </summary>
        [NameInMap("VlanId")]
        [Validation(Required=false)]
        public long? VlanId { get; set; }

    }

}
