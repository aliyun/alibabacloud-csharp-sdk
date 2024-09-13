// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RunInstancesRequest : TeaModel {
        /// <summary>
        /// The number of instances that you want to create. Valid values: 1 to 100.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public long? Amount { get; set; }

        /// <summary>
        /// The time when to automatically release the pay-as-you-go instance. Specify the time in the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the `yyyy-MM-ddTHH:mm:ssZ` format. The time must be in Coordinated Universal Time (UTC).
        /// 
        /// *   If the value of `ss` is not `00`, the start time is automatically rounded down to the nearest minute based on the value of `mm`.
        /// *   The specified time must be at least one hour later than the current time.
        /// 
        /// Use the UTC time format: yyyy-MM-ddTHH:mmZ
        /// </summary>
        [NameInMap("AutoReleaseTime")]
        [Validation(Required=false)]
        public string AutoReleaseTime { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-renewal. Valid values:
        /// 
        /// *   **true**.
        /// *   **false** (default).
        /// 
        /// >  This parameter is not available when InstanceChargeType is set to PostPaid.
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// Specifies whether to use coupons. Default value: true.
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public string AutoUseCoupon { get; set; }

        /// <summary>
        /// The billing cycle of computing resources of the instance. Only pay-as-you-go instances are supported. Valid values:
        /// 
        /// *   **Day**.
        /// *   **Month**.
        /// </summary>
        [NameInMap("BillingCycle")]
        [Validation(Required=false)]
        public string BillingCycle { get; set; }

        /// <summary>
        /// The Internet service provider (ISP).
        /// 
        /// >  This parameter is not available if ScheduleAreaLevel is set to Region and is required if ScheduleAreaLevel is set to other values.
        /// </summary>
        [NameInMap("Carrier")]
        [Validation(Required=false)]
        public string Carrier { get; set; }

        /// <summary>
        /// The specifications of data disks.
        /// </summary>
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<RunInstancesRequestDataDisk> DataDisk { get; set; }
        public class RunInstancesRequestDataDisk : TeaModel {
            /// <summary>
            /// The category of the disk. Valid values:
            /// 
            /// *   **cloud_efficiency**: ultra disk.
            /// *   **cloud_ssd**: all-flash disk.
            /// *   **local_hdd**: local HDD.
            /// *   **local_ssd**: local SSD.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// Indicates whether the cloud disk is encrypted. Valid values:
            /// 
            /// *   true.
            /// *   false (default).
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public bool? Encrypted { get; set; }

            /// <summary>
            /// The ID of the Key Management Service (KMS) key that is used for the disk. Valid values:
            /// 
            /// *   true.
            /// *   false (default).
            /// 
            /// >  If you set the Encrypted parameter to true, the default service key is used when the KMSKeyId parameter is empty.
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// The size of a data disk. Unit: GiB.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

        /// <summary>
        /// The ID of the node.
        /// 
        /// >  This parameter is required if ScheduleAreaLevel is set to Region and is not available if ScheduleAreaLevel is set to other values.
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// The name of the host.
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// The ID of the image. For ARM PCB-based server instances, leave this parameter empty. For other instances, this parameter is required.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The billing policy of the instance. Valid values:
        /// 
        /// *   **instance**: Bills are generated based on instances.
        /// *   If you do not specify this parameter, bills are generated based on users.
        /// </summary>
        [NameInMap("InstanceChargeStrategy")]
        [Validation(Required=false)]
        public string InstanceChargeStrategy { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   **PrePaid**: subscription.
        /// *   **PostPaid**: pay-as-you-go.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The name of the instance. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with `http://` or `https://`. It can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).
        /// 
        /// The default value of this parameter is the value of the InstanceId parameter.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The instance type.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The bandwidth billing method. Valid values:
        /// 
        /// *   **BandwidthByDay**: pay by daily peak bandwidth
        /// *   **95BandwidthByMonth**: pay by monthly 95th percentile bandwidth
        /// 
        /// >  This parameter is required if you purchase an ENS instance for the first time. The value that you specified is used as the default value for subsequent purchases.
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The maximum public bandwidth. If the value of this parameter is greater than 0, a public IP address is assigned to the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public long? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// The type of the IP address. Valid values:
        /// 
        /// *   **ipv4** (default).
        /// *   **ipv6**.
        /// *   **ipv4Andipv6**.
        /// </summary>
        [NameInMap("IpType")]
        [Validation(Required=false)]
        public string IpType { get; set; }

        /// <summary>
        /// The name of the key pair.
        /// 
        /// >  You need to specify at least one of **Password**, **KeyPairName**, and **PasswordInherit**.
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// The code of the region.
        /// 
        /// >  This parameter is not available if ScheduleAreaLevel is set to Region and is required if ScheduleAreaLevel is set to other values.
        /// </summary>
        [NameInMap("NetDistrictCode")]
        [Validation(Required=false)]
        public string NetDistrictCode { get; set; }

        /// <summary>
        /// The ID of the network.
        /// 
        /// >  This parameter is available only if ScheduleAreaLevel is set to Region and cannot be configured if ScheduleAreaLevel is set to other values. Otherwise, an error occurs.
        /// </summary>
        [NameInMap("NetWorkId")]
        [Validation(Required=false)]
        public string NetWorkId { get; set; }

        /// <summary>
        /// The password that is used to connect to the instance.
        /// 
        /// >  You need to specify at least one of **Password**, **KeyPairName**, and **PasswordInherit**.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies whether to use the preset password of the image. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// >  You need to specify at least one of **Password**, **KeyPairName**, and **PasswordInherit**.
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        /// <summary>
        /// The unit of the subscription period.
        /// 
        /// *   If **PeriodUnit** is set to **Day**, **Period** can only be set to **3**.
        /// *   If **PeriodUnit** is **Month**, **Period** can be set to **1 to 9** or **12**.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// The unit of the subscription period. Valid values:
        /// 
        /// *   **Month** (default).
        /// *   **Day**.
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The private IP address.
        /// 
        /// >  This parameter is available only if ScheduleAreaLevel is set to Region and cannot be configured if ScheduleAreaLevel is set to other values. Otherwise, an error occurs. If you specify a private IP address, the number of instances must be 1. The private IP address takes effect only when the private IP address and the vSwitch ID are not empty.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// Specifies whether to enable public IP address identification. Valid values: true and false. Default value: false.
        /// </summary>
        [NameInMap("PublicIpIdentification")]
        [Validation(Required=false)]
        public bool? PublicIpIdentification { get; set; }

        /// <summary>
        /// The scheduling level. This parameter specifies area-level scheduling or node-level scheduling. Valid values:
        /// 
        /// *   **Big**: greater area
        /// *   **Middle**: province
        /// *   **Small**: city
        /// *   **Region**: node
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScheduleAreaLevel")]
        [Validation(Required=false)]
        public string ScheduleAreaLevel { get; set; }

        /// <summary>
        /// The scheduling price policy. Valid values:
        /// 
        /// *   **PriceHighPriority**: The high price prevails.
        /// *   **PriceLowPriority**: The low price prevails.
        /// </summary>
        [NameInMap("SchedulingPriceStrategy")]
        [Validation(Required=false)]
        public string SchedulingPriceStrategy { get; set; }

        /// <summary>
        /// The scheduling policy of the taint. Valid values:
        /// 
        /// *   **Concentrate**
        /// *   **Disperse**
        /// 
        /// >  If ScheduleAreaLevel is set to Region, set this parameter to **Concentrate**. If ScheduleAreaLevel is set to other values, set this parameter to Concentrate or Disperse based on your business requirements.
        /// </summary>
        [NameInMap("SchedulingStrategy")]
        [Validation(Required=false)]
        public string SchedulingStrategy { get; set; }

        /// <summary>
        /// The ID of security group.
        /// </summary>
        [NameInMap("SecurityId")]
        [Validation(Required=false)]
        public string SecurityId { get; set; }

        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// The bidding policy for the pay-as-you-go instance. This parameter is valid only when the `InstanceChargeType` parameter is set to `PostPaid`. Valid values:
        /// 
        /// *   NoSpot: The instance is created as a regular pay-as-you-go instance.
        /// *   SpotAsPriceGo: The instance is a preemptible instance for which the market price at the time of purchase is automatically used as the bidding price.
        /// 
        /// Default value: NoSpot.
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// The specification of the system disk.
        /// </summary>
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public RunInstancesRequestSystemDisk SystemDisk { get; set; }
        public class RunInstancesRequestSystemDisk : TeaModel {
            /// <summary>
            /// The category of the system disk.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The size of the system disk. Unit: GiB.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<RunInstancesRequestTag> Tag { get; set; }
        public class RunInstancesRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// Specifies whether to append sequential suffixes to the hostname specified by the **HostName** parameter and to the instance name specified by the **InstanceName** parameter. The sequential suffixes range from 001 to 999.
        /// </summary>
        [NameInMap("UniqueSuffix")]
        [Validation(Required=false)]
        public bool? UniqueSuffix { get; set; }

        /// <summary>
        /// The custom data. The maximum data size is 16 KB. You can specify **UserData**. **UserData** must be Base64-encoded.
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// The ID of the vSwitch.
        /// 
        /// >  This parameter is available only if ScheduleAreaLevel is set to Region and cannot be configured if ScheduleAreaLevel is set to other values. Otherwise, an error occurs.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
