// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class SwitchNetworkRequest : TeaModel {
        /// <summary>
        /// The operation that you want to perform. Set the value to **SwitchNetwork**.
        /// </summary>
        [NameInMap("ClassicExpiredDays")]
        [Validation(Required=false)]
        public string ClassicExpiredDays { get; set; }

        /// <summary>
        /// The ID of the task.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RetainClassic")]
        [Validation(Required=false)]
        public string RetainClassic { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The ID of the VPC to which you want to switch. You can call the [DescribeVpcs](~~35739~~) operation to query VPC IDs.
        /// 
        /// > 
        /// *   The VPC and the ApsaraDB for Redis instance must be deployed in the same region.
        /// *   After you set this parameter, you must also set the **VSwitchId** parameter.
        /// </summary>
        [NameInMap("TargetNetworkType")]
        [Validation(Required=false)]
        public string TargetNetworkType { get; set; }

        /// <summary>
        /// The ID of the instance. You can call the [DescribeInstances](~~60933~~) operation to query instance IDs.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the vSwitch that belongs to the VPC to which you want to switch. You can call the [DescribeVpcs](~~35739~~) operation to query vSwitch IDs.
        /// 
        /// >  The vSwitch and the ApsaraDB for Redis instance must belong to the same zone.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
