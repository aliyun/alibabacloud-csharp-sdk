// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class AttachDBInstancesRequest : TeaModel {
        /// <summary>
        /// The mode in which you want to attach the ApsaraDB RDS instance to the scaling group. Valid values:
        /// 
        /// *   SecurityIp: the SecurityIp mode. Auto Scaling automatically adds the private IP addresses of the scaled out instances to the IP address whitelist of the ApsaraDB RDS instance. You can select this mode only when you attach an ApsaraDB RDS instance to a scaling group.
        /// *   SecurityGroup: the security group mode. Auto Scaling adds the security group of the scaling configuration to the security group whitelist for registration and association.
        /// </summary>
        [NameInMap("AttachMode")]
        [Validation(Required=false)]
        public string AttachMode { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that the value is unique among different requests.
        /// 
        /// The token can only contain ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure the idempotence of a request](https://help.aliyun.com/document_detail/25965.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the ApsaraDB RDS instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public List<string> DBInstances { get; set; }

        /// <summary>
        /// Specifies whether to add the private IP addresses of all instances in the scaling group to the IP address whitelist of the ApsaraDB RDS instance. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("ForceAttach")]
        [Validation(Required=false)]
        public bool? ForceAttach { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the scaling group.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The ID of the scaling group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// The type of the database that you want to attach to the scaling group. Valid values:
        /// 
        /// *   ApsaraDB RDS
        /// *   ApsaraDB for Redis
        /// *   ApsaraDB for MongoDB
        /// 
        /// Default value: RDS.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
