// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class SwitchNetworkRequest : TeaModel {
        /// <summary>
        /// The retention period of the endpoint for the classic network. Valid values: **14**, **30**, **60**, and **120**. Unit: days.
        /// 
        /// > *   This parameter is required when **RetainClassic** is set to **True**.
        /// > *   After you complete the switchover operation, you can also call the [ModifyInstanceNetExpireTime](~~ModifyInstanceNetExpireTime~~) operation to modify the retention period of the endpoint for the classic network.
        /// </summary>
        [NameInMap("ClassicExpiredDays")]
        [Validation(Required=false)]
        public string ClassicExpiredDays { get; set; }

        /// <summary>
        /// The ID of the instance. You can call the [DescribeInstances](~~DescribeInstances~~) operation to query instance IDs.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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
        /// Specifies whether to retain the original endpoint for the classic network after you switch the instance from classic network to VPC. Valid values:
        /// 
        /// *   **True**: retains the original endpoint.
        /// *   **False**: does not retain the original endpoint. This is the default value.
        /// 
        /// >  This parameter can be used only when the network type of the instance is classic network.
        /// </summary>
        [NameInMap("RetainClassic")]
        [Validation(Required=false)]
        public string RetainClassic { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The network type to which you want to switch. Set the value to **VPC**.
        /// </summary>
        [NameInMap("TargetNetworkType")]
        [Validation(Required=false)]
        public string TargetNetworkType { get; set; }

        /// <summary>
        /// The ID of the vSwitch that belongs to the VPC to which you want to switch. You can call the [DescribeVpcs](~~DescribeVpcs~~) operation to query vSwitch IDs.
        /// 
        /// >  The vSwitch and the ApsaraDB for Redis instance must belong to the same zone.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the VPC to which you want to switch. You can call the [DescribeVpcs](~~DescribeVpcs~~) operation to query VPC IDs.
        /// 
        /// > *   The VPC and the ApsaraDB for Redis instance must be deployed in the same region.
        /// > *   After you set this parameter, you must also set the **VSwitchId** parameter.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
