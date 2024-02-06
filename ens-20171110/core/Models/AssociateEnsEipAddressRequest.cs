// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AssociateEnsEipAddressRequest : TeaModel {
        /// <summary>
        /// The ID of the EIP.
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

        /// <summary>
        /// The ID of the cloud service with which you want to associate the EIP.
        /// 
        /// >  IDs of Edge Load Balancer (ELB) are supported.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The type of instance with which you want to associate the EIP. Valid values:
        /// 
        /// *   **Nat**: a NAT gateway.
        /// *   **SlbInstance**: an ELB instance.
        /// *   **NetworkInterface**: a secondary ENI.
        /// *   **NatSlbInstance**: If you want to associate multiple EIPs to an ELB instance, you need to set the parameter to this value.
        /// *   **EnsInstance** (default): an ENS instance.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Specifies whether the EIP is a secondary EIP. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Standby")]
        [Validation(Required=false)]
        public bool? Standby { get; set; }

    }

}
