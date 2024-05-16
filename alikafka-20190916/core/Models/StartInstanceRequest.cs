// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class StartInstanceRequest : TeaModel {
        /// <summary>
        /// The initial configurations of ApsaraMQ for Kafka. The value must be a valid JSON string.
        /// 
        /// If you do not specify this parameter, it is left empty.
        /// 
        /// The following parameters can be configured for **Config**:
        /// 
        /// *   **enable.vpc_sasl_ssl**: specifies whether to enable VPC transmission encryption. Valid values:
        /// 
        ///     *   **true**: enables VPC transmission encryption. If you enable VPC transmission encryption, you must also enable access control list (ACL).
        ///     *   **false**: disables VPC transmission encryption. By default, VPC transmission encryption is disabled.
        /// 
        /// *   **enable.acl**: specifies whether to enable ACL. Valid values:
        /// 
        ///     *   **true**: enables ACL.
        ///     *   **false**: disables ACL. By default, ACL is disabled.
        /// 
        /// *   **kafka.log.retention.hours**: the maximum message retention period when the disk capacity is sufficient. Unit: hours. Valid values: 24 to 480. Default value: **72**. When the disk usage reaches 85%, the disk capacity is considered insufficient and the system deletes messages in the order in which they are stored to ensure service availability.
        /// 
        /// *   **kafka.message.max.bytes**: the maximum size of messages that ApsaraMQ for Kafka can send and receive. Unit: bytes. Valid values: 1048576 to 10485760. Default value: **1048576**. Before you change the value of this parameter, make sure that the new value matches the corresponding configurations on the producers and consumers.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// Specifies whether cross-zone deployment is required. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: true.
        /// </summary>
        [NameInMap("CrossZone")]
        [Validation(Required=false)]
        public bool? CrossZone { get; set; }

        /// <summary>
        /// The deployment mode of the instance. Valid values:
        /// 
        /// *   **vpc**: deploys the instance that allows access only from a VPC.
        /// *   **eip**: deploys the instance that allows access from the Internet and a VPC.
        /// 
        /// The deployment mode of the instance must match the type of the instance. If the instance allows access only from a VPC, set the value to **vpc**. If the instance allows access from the Internet and a VPC, set the value to **eip**.
        /// </summary>
        [NameInMap("DeployModule")]
        [Validation(Required=false)]
        public string DeployModule { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Specifies whether the instance supports elastic IP addresses (EIPs). Valid values:
        /// 
        /// *   **true**: supports EIPs and allows access from the Internet and a VPC.
        /// *   **false**: does not support EIPs and allows access only from a VPC.
        /// 
        /// The value of this parameter must match the type of the instance. For example, if the instance allows access only from a VPC, set this parameter to **false**.
        /// </summary>
        [NameInMap("IsEipInner")]
        [Validation(Required=false)]
        public bool? IsEipInner { get; set; }

        /// <summary>
        /// Specifies whether to forcibly deploy the instance in the selected zones.
        /// </summary>
        [NameInMap("IsForceSelectedZones")]
        [Validation(Required=false)]
        public bool? IsForceSelectedZones { get; set; }

        /// <summary>
        /// Specifies whether to set a new username and password. Valid values:
        /// 
        /// *   **true**: sets a new username and password.
        /// *   **false**: does not set a new username or password.
        /// 
        /// This parameter is available only if you deploy an instance that allows access from the Internet and a VPC.
        /// </summary>
        [NameInMap("IsSetUserAndPassword")]
        [Validation(Required=false)]
        public bool? IsSetUserAndPassword { get; set; }

        /// <summary>
        /// The ID of the key that is used for disk encryption in the region where the instance is deployed. You can obtain the ID of the key in the [Key Management Service (KMS) console](https://kms.console.aliyun.com/?spm=a2c4g.11186623.2.5.336745b8hfiU21) or create a key. For more information, see [Manage CMKs](https://help.aliyun.com/document_detail/181610.html).
        /// 
        /// If this parameter is configured, disk encryption is enabled for the instance. You cannot disable disk encryption after disk encryption is enabled. When you call this operation, the system checks whether the AliyunServiceRoleForAlikafkaInstanceEncryption service-linked role is created. If the role is not created, the system automatically creates the role. For more information, see [Service-linked roles](https://help.aliyun.com/document_detail/190460.html).
        /// </summary>
        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        /// <summary>
        /// The name of the instance.
        /// 
        /// >  If you specify a value for this parameter, make sure that the specified value is unique in the region of the instance.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The alert contact.
        /// </summary>
        [NameInMap("Notifier")]
        [Validation(Required=false)]
        public string Notifier { get; set; }

        /// <summary>
        /// The password that corresponds to the username.
        /// 
        /// This parameter is available only if you deploy an instance that allows access from the Internet and a VPC.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The security group of the instance.
        /// 
        /// If you do not specify this parameter, ApsaraMQ for Kafka automatically configures a security group for your instance. If you specify this parameter, you must create a security group in advance. For more information, see [Create a security group](https://help.aliyun.com/document_detail/25468.html).
        /// </summary>
        [NameInMap("SecurityGroup")]
        [Validation(Required=false)]
        public string SecurityGroup { get; set; }

        /// <summary>
        /// The two-dimensional arrays that consist of the candidate set for primary zones and the candidate set for secondary zones.
        /// 
        /// *   If you set CrossZone to true and specify Zone H and Zone F as the candidate set for primary zones and Zone K as the candidate set for secondary zones, set this parameter to `[[\\"zoneh\\",\\"zonef\\"],[\\"zonek\\"]]`.
        /// 
        ///     **
        /// 
        ///     **Note** If you specify multiple zones as the primary or secondary zones, the system deploys the instance in one of the zones without prioritizing them. For example, if you set this parameter to `[[\\"zoneh\\",\\"zonef\\"],[\\"zonek\\"]]`, the primary zone in which the instance is deployed can be Zone H or Zone F, and the secondary zone is Zone K.
        /// 
        /// *   If you set CrossZone to false and want to deploy the instance in Zone K, set this parameter to `[[\\"zonek\\"],[]]`. In this case, the value of this parameter must still be two-dimensional arrays, but the array that specifies the candidate for secondary zones is left empty.
        /// </summary>
        [NameInMap("SelectedZones")]
        [Validation(Required=false)]
        public string SelectedZones { get; set; }

        /// <summary>
        /// The version of ApsaraMQ for Kafka. Valid values: 0.10.2 and 2.2.0.
        /// </summary>
        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        /// <summary>
        /// The mobile phone number of the alert contact.
        /// </summary>
        [NameInMap("UserPhoneNum")]
        [Validation(Required=false)]
        public string UserPhoneNum { get; set; }

        /// <summary>
        /// The username that is used to access the instance.
        /// 
        /// This parameter is available only if you deploy an instance that allows access from the Internet and a VPC.
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// The ID of the vSwitch to which you want to connect the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The vSwitch IDs.
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) in which you want to deploy the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The ID of the zone where you want to deploy the ApsaraMQ for Kafka instance.
        /// 
        /// *   The zone ID of the ApsaraMQ for Kafka instance must be the same as that of the vSwitch.
        /// *   The value must be in the zoneX or Region ID-X format. Examples: zonea and cn-hangzhou-k.
        /// 
        /// >  If resources in the specified zone is insufficient, the instance may be deployed in another zone.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
