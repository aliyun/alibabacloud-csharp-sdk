// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceAttributeRequest : TeaModel {
        /// <summary>
        /// The performance mode of the burstable instance. Valid values:
        /// 
        /// *   Standard: standard mode
        /// *   Unlimited: unlimited mode
        /// 
        /// For more information about the performance modes of burstable instances, see [Burstable instances](~~59977~~).
        /// </summary>
        [NameInMap("CreditSpecification")]
        [Validation(Required=false)]
        public string CreditSpecification { get; set; }

        /// <summary>
        /// The release protection attribute of the instance. This parameter specifies whether you can use the ECS console or call the [DeleteInstance](~~25507~~) operation to release the instance.
        /// 
        /// > This parameter is applicable to only pay-as-you-go instances. It can protect instances against manual releases, but not against automatic releases.
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// The instance description. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
        /// 
        /// This parameter is empty by default.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 实例MTU是否开启Jumbo frame通信模式，取值范围：
        /// 
        /// -true：开启。
        /// 
        /// -false：不开启。
        /// 
        /// 目前仅部分规格支持开启Jumbo frame，更多详情，请参见[ECS实例MTU](~~200512~~)。
        /// </summary>
        [NameInMap("EnableJumboFrame")]
        [Validation(Required=false)]
        public bool? EnableJumboFrame { get; set; }

        /// <summary>
        /// The hostname of the instance. Take note of the following items:
        /// 
        /// *   When you modify the hostname of an instance, the instance must not be in the Creating (Pending) or Starting (Starting) state. Otherwise, the new hostname and the configurations in `/etc/hosts` cannot take effect. You can call the [DescribeInstances](~~25506~~) operation to query the state of the instance.
        /// *   After the hostname is modified, you must call the [RebootInstance](~~25502~~) operation for the new hostname to take effect.
        /// 
        /// The following limits apply to the hostnames of instances that run different operating systems:
        /// 
        /// *   For Windows Server, the hostname must be 2 to 15 characters in length and can contain letters, digits, and hyphens (-). It cannot start or end with a hyphen (-), contain consecutive hyphens (-), or contain only digits.
        /// *   For other operating systems such as Linux, the hostname must be 2 to 64 characters in length. You can use periods (.) to separate a hostname into multiple segments. Each segment can contain letters, digits, and hyphens (-). The hostname cannot contain consecutive periods (.) or hyphens (-). It cannot start or end with a period (.) or a hyphen (-).
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The instance name. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with `http://` or `https://`. It can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The number of queues supported by the primary ENI.
        /// </summary>
        [NameInMap("NetworkInterfaceQueueNumber")]
        [Validation(Required=false)]
        public int? NetworkInterfaceQueueNumber { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The password of the instance. The password must be 8 to 30 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters include:
        /// 
        ///     ()`~!@#$%^&*-_+=|{}[]:;\"<>,.?/
        /// 
        /// For Windows instances, passwords cannot start with a forward slash (/).
        /// 
        /// > If the `Password` parameter is specified, we recommend that you send requests over HTTPS to prevent password leaks.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// > This parameter is in invitational preview and is not publicly available.
        /// </summary>
        [NameInMap("Recyclable")]
        [Validation(Required=false)]
        public bool? Recyclable { get; set; }

        /// <summary>
        /// > This parameter is in invitational preview and is not publicly available.
        /// </summary>
        [NameInMap("RemoteConnectionOptions")]
        [Validation(Required=false)]
        public ModifyInstanceAttributeRequestRemoteConnectionOptions RemoteConnectionOptions { get; set; }
        public class ModifyInstanceAttributeRequestRemoteConnectionOptions : TeaModel {
            /// <summary>
            /// > This parameter is in invitational preview and is not publicly available.
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// > This parameter is in invitational preview and is not publicly available.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The IDs of replacement security groups.
        /// 
        /// *   All security group IDs must be unique.
        /// *   The instance is moved from the current security groups to the replacement security groups. If you want the instance to remain in the current security groups, you must add the IDs of the current security groups to the list.
        /// *   You can move the instance to security groups of a different type. However, the list cannot contain the IDs of both basic and advanced security groups.
        /// *   The specified security group and instance must belong to the same virtual private cloud (VPC).
        /// *   The valid values of N are based on the maximum number of security groups to which the instance can belong. For more information, see [Limits](~~25412#SecurityGroupQuota1~~).
        /// *   New security groups become valid for corresponding instances after a short latency.
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// The user data of the instance. User data must be encoded in Base64.
        /// 
        /// The size of the user data must be no greater than 16 KB before it is encoded in Base64. We recommend that you do not pass in confidential information such as passwords and private keys in the plaintext format. If you must pass in confidential information, we recommend that you encrypt and Base64-encode the information before you pass it in. Then you can decode and decrypt the information in the same way within the instance.
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
