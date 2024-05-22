// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateInstanceRequest : TeaModel {
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestDataDisk> DataDisk { get; set; }
        public class CreateInstanceRequestDataDisk : TeaModel {
            /// <summary>
            /// The capacity of the first data disk. Unit: GiB. The capacity is at least 20 GiB and is a multiple of 10 GiB.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

        }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public CreateInstanceRequestSystemDisk SystemDisk { get; set; }
        public class CreateInstanceRequestSystemDisk : TeaModel {
            /// <summary>
            /// The size of the system disk. Unit: GiB. Valid values: **20** and **40**. The value cannot be smaller than the size of the image and must be a multiple of 10 GiB.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

        }

        /// <summary>
        /// Specifies whether to enable the auto-renewal feature. Valid values: **True** and **False**. Default value: False.
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// The auto-renewal period for the instance. This parameter is required when the **AutoRenew** parameter is set to **True**. Valid values: **1** to **12**. Unit: months.
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public string AutoRenewPeriod { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// The hostname of the Elastic Compute Service (ECS) instance. General naming rules: The hostname cannot start or end with a period (.) or hyphen (-). It cannot contain consecutive periods (.) or hyphens (-).
        /// 
        /// Naming rules for specific instances:
        /// 
        /// *   For Windows instances, the hostname must be **2** to **15** characters in length and cannot contain periods (.) or contain only digits. The hostname cannot contain periods (.) or contain only digits.
        /// *   For instances that run one of other operating systems such as Linux, the hostname must be **2** to **64** characters in length. You can use periods (.) to separate the hostname into multiple segments. Each segment can contain letters, digits, and hyphens (-).
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// The ID of the image file that you select when creating the instance.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The name of the instance. The name must conform to the following naming conventions:
        /// 
        /// *   The name must be **2** to **128** characters in length.
        /// *   It must start with a letter but cannot start with http:// or https://.
        /// *   The name can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).
        /// 
        /// If you do not specify this parameter, the instance ID is used as the instance name by default.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The type of the instance.
        /// 
        /// For more information, see [](~~66124~~).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// This parameter is required if you create the instance for the first time. The existing billing method is used by default if you have created an instance. Valid values:
        /// 
        /// *   **BandwidthByDay**: Pay by daily peak bandwidth.
        /// *   **95BandwidthByMonth**: Pay by monthly 95th percentile bandwidth.
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The type of IP address. Valid values:
        /// 
        /// *   **ipv4**: IPv4. This is the default value.
        /// *   **ipv6**: IPv6.
        /// *   **ipv4Andipv6**: IPv4 and IPv6.
        /// </summary>
        [NameInMap("IpType")]
        [Validation(Required=false)]
        public string IpType { get; set; }

        /// <summary>
        /// The name of the key pair. You can specify only one name.
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The password of the instance.
        /// 
        /// The password must be 8 to 30 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters include: ``()`~!@#$%^&*-_+=|{}[]:;\\"<>,.?/``
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies whether to use the preset password of the image. Valid values:
        /// 
        /// - **true**: The password preset in the image is used, and the **Password** parameter must be null. For secure access, make sure that the selected image has a password configured.
        /// 
        /// - **false**: does not use the password preset in the image.
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        /// <summary>
        /// The billing method of the instance. The value is set to Subscription.
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// The subscription period of the instance. Valid values: **1** to **9** and **12**. Unit: months.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The internal IP address. If this parameter is specified, you must specify the vSwitch ID. The vSwitch must be created first. Otherwise, an error is returned.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// Specifies whether a public IP address can be assigned to the specified instance. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("PublicIpIdentification")]
        [Validation(Required=false)]
        public bool? PublicIpIdentification { get; set; }

        /// <summary>
        /// The number of instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public string Quantity { get; set; }

        /// <summary>
        /// Specifies whether to automatically append sequential suffixes to the hostnames specified by the **HostName** parameter and instance names specified by the **InstanceName** parameter. The sequential numbers in the suffix range from **001** to **999**.
        /// 
        /// Examples: **LocalHost001** and **LocalHost002**, and **MyInstance001** and **MyInstance002**.
        /// 
        /// Default value: **false**.
        /// </summary>
        [NameInMap("UniqueSuffix")]
        [Validation(Required=false)]
        public bool? UniqueSuffix { get; set; }

        /// <summary>
        /// Custom data. The data starts with `#!`. The data can be at most 256 characters in length and 16 KB in size. Only custom scripts are supported and cannot be rendered by InstanceMetaData.
        /// 
        /// You can specify custom data. The data is encoded in Base64. The system does not encrypt your custom data when API requests are initiated. We recommend that you do not pass in confidential information such as passwords and private keys in plaintext. If you want to provide sensitive data such as passwords and private keys, encrypt the data and then encode it in Base64. The data is decrypted on the instance in the way it is encrypted.
        /// 
        /// For more information, see [User data formats](https://cloudinit.readthedocs.io/en/latest/topics/format.html).
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// The ID of the vSwitch.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
