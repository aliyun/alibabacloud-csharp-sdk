// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceAttributeRequest : TeaModel {
        [NameInMap("CpuOptions")]
        [Validation(Required=false)]
        public ModifyInstanceAttributeRequestCpuOptions CpuOptions { get; set; }
        public class ModifyInstanceAttributeRequestCpuOptions : TeaModel {
            /// <summary>
            /// The CPU topology type of the instance. Valid values:
            /// 
            /// *   `ContinuousCoreToHTMapping`: The Hyper-Threading (HT) technology allows continuous threads to run on the same core in the CPU topology of the instance.
            /// *   `DiscreteCoreToHTMapping`: The HT technology allows discrete threads to run on the same core in the CPU topology of the instance.
            /// 
            /// By default, this parameter is left empty.
            /// 
            /// > 
            /// 
            /// *   This parameter is supported only by specific instance families. For information about the supported instance families, see [View and modify CPU topologies](https://help.aliyun.com/document_detail/2636059.html).
            /// 
            /// *   Before you specify this parameter, make sure that the instance is in the Stopped (`Stopped`) state.
            /// </summary>
            [NameInMap("TopologyType")]
            [Validation(Required=false)]
            public string TopologyType { get; set; }

        }

        /// <summary>
        /// The performance mode of the burstable instance. Valid values:
        /// 
        /// *   Standard
        /// *   Unlimited
        /// 
        /// For more information about the performance modes of burstable instances, see [Overview](https://help.aliyun.com/document_detail/59977.html).
        /// </summary>
        [NameInMap("CreditSpecification")]
        [Validation(Required=false)]
        public string CreditSpecification { get; set; }

        /// <summary>
        /// The release protection attribute of the instance. This parameter specifies whether you can use the ECS console or call the [DeleteInstance](https://help.aliyun.com/document_detail/25507.html) operation to release the instance.
        /// 
        /// >  This parameter is applicable only to pay-as-you-go instances. The release protection attribute can protect instances against manual releases, but not against automatic releases.
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// The description of the instance. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to enable the Jumbo Frames feature for the instance. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// You can enable the Jumbo Frames feature only for specific instance types. For more information, see [MTU and jumbo frames](https://help.aliyun.com/document_detail/200512.html).
        /// </summary>
        [NameInMap("EnableJumboFrame")]
        [Validation(Required=false)]
        public bool? EnableJumboFrame { get; set; }

        /// <summary>
        /// The hostname of the instance. Take note of the following items:
        /// 
        /// *   When you change the hostname of the instance, the instance cannot be in the Creating (`Pending`) or Starting (`Starting`) state. Otherwise, the new hostname and the configurations in `/etc/hosts` may not take effect. You can call the [DescribeInstances](https://help.aliyun.com/document_detail/25506.html) operation to query the status of the instance.
        /// *   After you change the hostname, you must call the [RebootInstance](https://help.aliyun.com/document_detail/25502.html) operation for the new hostname to take effect.
        /// 
        /// The following limits apply to the hostnames of instances that run different operating systems:
        /// 
        /// *   For Windows Server, the hostname must be 2 to 15 characters in length and can contain letters, digits, and hyphens (-). The hostname cannot start or end with a hyphen (-), contain consecutive hyphens (-), or contain only digits.
        /// *   For other operating systems such as Linux, the hostname must be 2 to 64 characters in length. You can use periods (.) to separate a hostname into multiple segments. Each segment can contain letters, digits, and hyphens (-). The hostname cannot contain consecutive periods (.) or hyphens (-). The hostname cannot start or end with a period (.) or a hyphen (-).
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the instance. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with `http://` or `https://`. The name can contain letters, digits, colons (:), underscores (_), and hyphens (-).
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
        /// The password of the instance. The password must be 8 to 30 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The following special characters are supported:
        /// 
        ///     ( ) ` ~ ! @ # $ % ^ & * - _ + = | { } [ ] : ; \\" < > , . ? /
        /// 
        /// The password of a Windows instance cannot start with a forward slash (/).
        /// 
        /// >  For security reasons, we recommend that you use HTTPS to send requests if `Password` is specified.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// >  This parameter is in invitational preview and is not publicly available.
        /// </summary>
        [NameInMap("PrivateDnsNameOptions")]
        [Validation(Required=false)]
        public ModifyInstanceAttributeRequestPrivateDnsNameOptions PrivateDnsNameOptions { get; set; }
        public class ModifyInstanceAttributeRequestPrivateDnsNameOptions : TeaModel {
            /// <summary>
            /// >  This parameter is in invitational preview and is not publicly available.
            /// </summary>
            [NameInMap("EnableInstanceIdDnsAAAARecord")]
            [Validation(Required=false)]
            public bool? EnableInstanceIdDnsAAAARecord { get; set; }

            /// <summary>
            /// >  This parameter is in invitational preview and is not publicly available.
            /// </summary>
            [NameInMap("EnableInstanceIdDnsARecord")]
            [Validation(Required=false)]
            public bool? EnableInstanceIdDnsARecord { get; set; }

            /// <summary>
            /// >  This parameter is in invitational preview and is not publicly available.
            /// </summary>
            [NameInMap("EnableIpDnsARecord")]
            [Validation(Required=false)]
            public bool? EnableIpDnsARecord { get; set; }

            /// <summary>
            /// >  This parameter is in invitational preview and is not publicly available.
            /// </summary>
            [NameInMap("EnableIpDnsPtrRecord")]
            [Validation(Required=false)]
            public bool? EnableIpDnsPtrRecord { get; set; }

            /// <summary>
            /// >  This parameter is in invitational preview and is not publicly available.
            /// </summary>
            [NameInMap("HostnameType")]
            [Validation(Required=false)]
            public string HostnameType { get; set; }

        }

        /// <summary>
        /// >  This parameter is in invitational preview and is not publicly available.
        /// </summary>
        [NameInMap("Recyclable")]
        [Validation(Required=false)]
        public bool? Recyclable { get; set; }

        /// <summary>
        /// >  This parameter is in invitational preview and is not publicly available.
        /// </summary>
        [NameInMap("RemoteConnectionOptions")]
        [Validation(Required=false)]
        public ModifyInstanceAttributeRequestRemoteConnectionOptions RemoteConnectionOptions { get; set; }
        public class ModifyInstanceAttributeRequestRemoteConnectionOptions : TeaModel {
            /// <summary>
            /// >  This parameter is in invitational preview and is not publicly available.
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// >  This parameter is in invitational preview and is not publicly available.
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
        /// *   The instance is moved from the current security groups to the replacement security groups. If you want the instance to remain in the current security groups, add the IDs of the current security groups to the list.
        /// *   You can move the instance to security groups of a different type. However, the list cannot contain the IDs of both basic and advanced security groups.
        /// *   The security groups and the instance must belong to the same VPC.
        /// *   The valid values of N vary based on the maximum number of security groups to which the instance can belong. For more information, see the [Security group limits](~~25412#SecurityGroupQuota1~~) section in the "Limits and quotas" topic.
        /// *   New security groups become valid for the instance after a short delay.
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// The user data of the instance. The user data must be encoded in Base64.
        /// 
        /// The maximum size of the raw data before encoding is 32 KB. We recommend that you do not pass in confidential information such as passwords and private keys in plaintext. If you must pass in confidential information, we recommend that you encrypt and Base64-encode the information before you pass it in. Then, you can decode and decrypt the information in the same way within the instance.
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
