// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class SwitchNetworkRequest : TeaModel {
        /// <summary>
        /// The retention period of the classic network endpoint. Valid values: **14**, **30**, **60**, and **120**. Unit: days.
        /// 
        /// > 
        /// 
        /// *   This parameter is available and required only when the **RetainClassic** parameter is set to **True**.
        /// 
        /// *   After you complete the switchover operation, you can also call the [ModifyInstanceNetExpireTime](https://help.aliyun.com/document_detail/61010.html) operation to modify the retention period of the classic network endpoint.
        /// </summary>
        [NameInMap("ClassicExpiredDays")]
        [Validation(Required=false)]
        public string ClassicExpiredDays { get; set; }

        /// <summary>
        /// The ID of the instance. You can call the [DescribeInstances](https://help.aliyun.com/document_detail/60933.html) operation to query the ID of the instance.
        /// 
        /// This parameter is required.
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
        /// Specifies whether to retain the original classic network endpoint after you switch the instance from classic network to VPC. Default value: False. Valid values:
        /// 
        /// *   **True**: retains the classic network endpoint.
        /// *   **False**: does not retain the classic network endpoint.
        /// 
        /// > This parameter is available only when the network type of the instance is classic network.
        /// </summary>
        [NameInMap("RetainClassic")]
        [Validation(Required=false)]
        public string RetainClassic { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The network type to which you want to switch. If you want to switch to VPC network, Set the value to **VPC**.
        /// </summary>
        [NameInMap("TargetNetworkType")]
        [Validation(Required=false)]
        public string TargetNetworkType { get; set; }

        /// <summary>
        /// The ID of the vSwitch that belongs to the VPC to which you want to switch. You can call the [DescribeVpcs](https://help.aliyun.com/document_detail/35739.html) operation to query the VPC ID.
        /// 
        /// > The vSwitch and the ApsaraDB for Redis instance must be deployed in the same zone.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the VPC to which you want to switch. You can call the [DescribeVpcs](https://help.aliyun.com/document_detail/35739.html) operation to query the VPC ID.
        /// 
        /// > 
        /// 
        /// *   The VPC and the ApsaraDB for Redis instance must be deployed in the same region.
        /// 
        /// *   After you set this parameter, you must also set the **VSwitchId** parameter.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
