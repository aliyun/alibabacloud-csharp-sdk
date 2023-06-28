// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListAcceleratorsResponseBody : TeaModel {
        /// <summary>
        /// The GA instances.
        /// </summary>
        [NameInMap("Accelerators")]
        [Validation(Required=false)]
        public List<ListAcceleratorsResponseBodyAccelerators> Accelerators { get; set; }
        public class ListAcceleratorsResponseBodyAccelerators : TeaModel {
            /// <summary>
            /// The ID of the GA instance.
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// The bandwidth value of the GA instance. Unit: Mbit/s.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// The bandwidth metering method.
            /// 
            /// *   **BandwidthPackage**: billed based on bandwidth plans.
            /// *   **CDT**: billed based on data transfer.
            /// </summary>
            [NameInMap("BandwidthBillingType")]
            [Validation(Required=false)]
            public string BandwidthBillingType { get; set; }

            /// <summary>
            /// The details about the basic bandwidth plan that is associated with the GA instance.
            /// </summary>
            [NameInMap("BasicBandwidthPackage")]
            [Validation(Required=false)]
            public ListAcceleratorsResponseBodyAcceleratorsBasicBandwidthPackage BasicBandwidthPackage { get; set; }
            public class ListAcceleratorsResponseBodyAcceleratorsBasicBandwidthPackage : TeaModel {
                /// <summary>
                /// The bandwidth value of the basic bandwidth plan. Unit: Mbit/s.
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                /// <summary>
                /// The type of the bandwidth that is provided by the basic bandwidth plan. Valid values:
                /// 
                /// *   **Basic**: basic
                /// *   **Enhanced**: enhanced
                /// *   **Advanced**: premium
                /// </summary>
                [NameInMap("BandwidthType")]
                [Validation(Required=false)]
                public string BandwidthType { get; set; }

                /// <summary>
                /// The ID of the basic bandwidth plan.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

            /// <summary>
            /// The ID of the Cloud Enterprise Network (CEN) instance that is associated with the GA instance.
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// The timestamp that indicates when the GA instance is created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The type of cross-border acceleration. This parameter is returned for GA instances whose bandwidth metering method is pay-by-data-transfer.
            /// 
            /// **bpgPro** is returned, which indicates BGP (Multi-ISP) Pro lines.
            /// </summary>
            [NameInMap("CrossBorderMode")]
            [Validation(Required=false)]
            public string CrossBorderMode { get; set; }

            /// <summary>
            /// Indicates whether cross-border acceleration is enabled.
            /// - **true**: yes
            /// - **false**: no
            /// </summary>
            [NameInMap("CrossBorderStatus")]
            [Validation(Required=false)]
            public bool? CrossBorderStatus { get; set; }

            /// <summary>
            /// The details about the cross-border acceleration bandwidth plan that is associated with the GA instance.
            /// 
            /// This array is returned only for GA instances that are created on the international site (alibabacloud.com).
            /// </summary>
            [NameInMap("CrossDomainBandwidthPackage")]
            [Validation(Required=false)]
            public ListAcceleratorsResponseBodyAcceleratorsCrossDomainBandwidthPackage CrossDomainBandwidthPackage { get; set; }
            public class ListAcceleratorsResponseBodyAcceleratorsCrossDomainBandwidthPackage : TeaModel {
                /// <summary>
                /// The bandwidth that is provided by the cross-border acceleration bandwidth plan. Unit: Mbit/s.
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                /// <summary>
                /// The ID of the cross-border acceleration bandwidth plan.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

            /// <summary>
            /// The ID of the Anti-DDoS Pro/Premium instance that is associated with the GA instance.
            /// </summary>
            [NameInMap("DdosId")]
            [Validation(Required=false)]
            public string DdosId { get; set; }

            /// <summary>
            /// The description of the GA instance.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The canonical name (CNAME) that is assigned to the GA instance.
            /// </summary>
            [NameInMap("DnsName")]
            [Validation(Required=false)]
            public string DnsName { get; set; }

            /// <summary>
            /// The timestamp that indicates when the GA instance expires.
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public long? ExpiredTime { get; set; }

            /// <summary>
            /// The billing method of the GA instance. Only **PREPAY** is returned. This value indicates the subscription billing method.
            /// </summary>
            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            /// <summary>
            /// The configurations of the acceleration area.
            /// </summary>
            [NameInMap("IpSetConfig")]
            [Validation(Required=false)]
            public ListAcceleratorsResponseBodyAcceleratorsIpSetConfig IpSetConfig { get; set; }
            public class ListAcceleratorsResponseBodyAcceleratorsIpSetConfig : TeaModel {
                /// <summary>
                /// The access mode of the acceleration area. Valid values:
                /// 
                /// *   **UserDefine**: custom nearby access mode. You can select acceleration areas and regions based on your business requirements. GA allocates a separate elastic IP address (EIP) to each acceleration region.
                /// *   **Anycast**: automatic nearby access mode. You do not need to specify an acceleration area. GA allocates an Anycast EIP to multiple regions across the globe. Users can connect to the nearest access point of the Alibaba Cloud global transmission network by sending requests to the Anycast EIP.
                /// </summary>
                [NameInMap("AccessMode")]
                [Validation(Required=false)]
                public string AccessMode { get; set; }

            }

            /// <summary>
            /// The name of the GA instance.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the region where the GA instance is deployed. Set the value to **cn-hangzhou**.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The CNAME that is used to associate the GA instance with an Anti-DDoS Pro/Premium instance.
            /// </summary>
            [NameInMap("SecondDnsName")]
            [Validation(Required=false)]
            public string SecondDnsName { get; set; }

            /// <summary>
            /// The specification of the GA instance. Valid values:
            /// 
            /// *   **1**: Small Ⅰ
            /// *   **2**: Small Ⅱ
            /// *   **3**: Small Ⅲ
            /// *   **5**: Medium Ⅰ
            /// *   **8**: Medium Ⅱ
            /// *   **10**: Medium Ⅲ
            /// *   **20**: Large Ⅰ
            /// *   **30**: Large Ⅱ
            /// *   **40**: Large Ⅲ
            /// *   **50**: Large Ⅳ
            /// *   **60**: Large Ⅴ
            /// *   **70**: Large Ⅵ
            /// *   **80**: Large VⅡ
            /// *   **90**: Large VⅢ
            /// *   **100**: Super Large Ⅰ
            /// *   **200**: Super Large Ⅱ
            /// 
            /// >  The Large Ⅲ specification and higher specifications are available only to users that are added to the whitelist. To use these specifications, contact your Alibaba Cloud account manager.
            /// 
            /// Different specifications provide different capabilities. For more information, see [Instance specifications](~~153127~~).
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            /// <summary>
            /// The status of the GA instance. Valid values:
            /// 
            /// *   **init**: The GA instance is being initialized.
            /// *   **active**: The GA instance is available.
            /// *   **configuring**: The GA instance is being configured.
            /// *   **binding**: The GA instance is being associated.
            /// *   **unbinding**: The GA instance is being disassociated.
            /// *   **deleting**: The GA instance is being deleted.
            /// *   **finacialLocked**: The GA instance is locked due to overdue payments.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The tags of the GA instance.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListAcceleratorsResponseBodyAcceleratorsTags> Tags { get; set; }
            public class ListAcceleratorsResponseBodyAcceleratorsTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// An invalid parameter.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// Indicates the upgradable state of the GA instance.
            /// - **notUpgradable**: The GA instance can not be upgraded
            /// - **upgradable**: The GA instance can be upgraded
            /// - **upgradeFailed**: The GA instance has been upgraded and failed
            /// </summary>
            [NameInMap("UpgradableStatus")]
            [Validation(Required=false)]
            public string UpgradableStatus { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
