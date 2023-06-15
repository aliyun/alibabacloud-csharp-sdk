// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceNetworkTypeRequest : TeaModel {
        /// <summary>
        /// The number of days for which you want to retain the classic network endpoint. Valid values: **1 to 120**. Default value: **7**.
        /// 
        /// > If you set the **RetainClassic** parameter to **True**, you must also specify this parameter.
        /// </summary>
        [NameInMap("ClassicExpiredDays")]
        [Validation(Required=false)]
        public string ClassicExpiredDays { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The network type after the modification. Set the value to **VPC**.
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The internal IP address of the instance. The internal IP address must be within the CIDR block supported by the specified vSwitch. ApsaraDB RDS automatically assigns an internal IP address to the instance based on the values of the **VPCId** and **VSwitchId** parameters.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// The number of days for which you want to retain the read/write splitting endpoint of the classic network type. Valid values: **1 to 120**. Default value: **7**.
        /// 
        /// > This parameter takes effect only when a read/write splitting endpoint of the classic network type exists and the **RetainClassic** parameter is set to **True**.
        /// </summary>
        [NameInMap("ReadWriteSplittingClassicExpiredDays")]
        [Validation(Required=false)]
        public int? ReadWriteSplittingClassicExpiredDays { get; set; }

        /// <summary>
        /// The internal IP address that corresponds to the read/write splitting endpoint of the instance. The internal IP address must be within the CIDR block supported by the specified vSwitch. The system automatically assigns an internal IP address to the read-only instance based on the values of the **VPCId** and **VSwitchId** parameters.
        /// 
        /// > This value is valid when a read/write splitting endpoint of the classic network type exists.
        /// </summary>
        [NameInMap("ReadWriteSplittingPrivateIpAddress")]
        [Validation(Required=false)]
        public string ReadWriteSplittingPrivateIpAddress { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// Specifies whether to retain the classic network endpoint. Valid values:
        /// 
        /// *   **True**: retains the classic network endpoint.
        /// *   **False**: does not retain the classic network endpoint.
        /// 
        /// Default value: **False**.
        /// </summary>
        [NameInMap("RetainClassic")]
        [Validation(Required=false)]
        public string RetainClassic { get; set; }

        /// <summary>
        /// The ID of the VPC.
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// The ID of the vSwitch. This parameter is required if the **VPCId** parameter is specified.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
