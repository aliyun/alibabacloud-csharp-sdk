// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class StartInstanceRequest : TeaModel {
        /// <summary>
        /// The initial configuration of the instance. The value must be a valid JSON string.
        /// 
        /// If you do not specify a value for this parameter, the value is left empty by default.
        /// 
        /// The following parameters can be configured for **Config**:
        /// 
        /// *   **enable.vpc_sasl_ssl**: specifies whether to enable VPC transmission encryption. Valid values:
        /// 
        ///     *   **true**: enables VPC transmission encryption. If VPC transmission encryption is enabled, you must also enable the access control list (ACL) feature.
        ///     *   **false**: disables VPC transmission encryption. This is the default value.
        /// 
        /// *   **enable.acl**: specifies whether to enable ACL. Valid values:
        /// 
        ///     *   **true**: enables the ACL feature.
        ///     *   **false**: disables the ACL feature. This is the default value.
        /// 
        /// *   **kafka.log.retention.hours**: the maximum period for which messages can be retained when the remaining disk space is sufficient. Unit: hours. Valid values: 24 to 480. Default value: **72**. When the disk usage reaches 85%, the system deletes messages in the order in which they are stored, starting from the earliest stored message. This ensures that the performance of the service is not degraded.
        /// 
        /// *   **kafka.message.max.bytes**: the maximum size of messages that Message Queue for Apache Kafka can send and receive. Unit: bytes. Valid values: 1048576 to 10485760. Default value: **1048576**. Before you change the maximum message size to a new value, make sure that the new value matches the configuration on the producers and consumers in the instance.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

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
        /// The ID of the key that is used for disk encryption in the region where the instance is deployed. You can obtain the ID of the key in the [Key Management Service (KMS) console](https://kms.console.aliyun.com/?spm=a2c4g.11186623.2.5.336745b8hfiU21) or create a key. For more information, see [Manage CMKs](~~181610~~).
        /// 
        /// If this parameter is configured, disk encryption is enabled for the instance. You cannot disable disk encryption after disk encryption is enabled. When you call this operation, the system checks whether the AliyunServiceRoleForAlikafkaInstanceEncryption service-linked role is created. If the role is not created, the system automatically creates the role. For more information, see [Service-linked roles](~~190460~~).
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
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The security group of the instance.
        /// 
        /// If you do not configure this parameter, Message Queue for Apache Kafka automatically configures a security group for the instance. If you want to configure this parameter, you must create a security group for the instance in advance. For more information, see [Create a security group](~~25468~~).
        /// </summary>
        [NameInMap("SecurityGroup")]
        [Validation(Required=false)]
        public string SecurityGroup { get; set; }

        /// <summary>
        /// The zones among which you want to deploy the instance.
        /// </summary>
        [NameInMap("SelectedZones")]
        [Validation(Required=false)]
        public string SelectedZones { get; set; }

        /// <summary>
        /// The version number of the instance. Valid values: 0.10.2 and 2.2.0.
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
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) in which you want to deploy the instance.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The ID of the zone in which you want to deploy the instance.
        /// 
        /// *   The zone ID of the instance must be the same as that of the vSwitch.
        /// *   The value must be in the format of zoneX or Region ID-X. For example, you can set this parameter to zonea or cn-hangzhou-k.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
