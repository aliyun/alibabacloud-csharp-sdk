// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class SwitchDBInstanceVpcRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// 
        /// > 
        /// 
        /// *   The instance must run one of the following database engines:
        /// 
        ///     - MySQL with local SSDs, standard SSDs, or ESSDs
        ///     - SQL Server with standard SSDs or ESSDs
        ///     - MariaDB with standard SSDs or ESSDs
        ///     - PostgreSQL with standard SSDs or ESSDs
        /// 
        /// *   The instance must be in the Running state.
        /// *   The instance must reside in a VPC.
        /// *   The instance cannot be a temporary instance or use an instance type that belongs to the shared instance family.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The private IP address of the instance. The private IP address must be within the CIDR block of the vSwitch that is specified by the **VSwitchId** parameter.
        /// 
        /// > You can call the [DescribeVSwitches](~~35748~~) operation to query the CIDR block of a specified vSwitch.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the VPC.
        /// 
        /// > The VPC must belong to the same region as the instance.
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// The ID of the vSwitch.
        /// 
        /// > The vSwitch must belong to the same zone as the instance.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
