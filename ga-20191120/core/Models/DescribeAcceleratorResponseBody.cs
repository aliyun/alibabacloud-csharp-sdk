// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeAcceleratorResponseBody : TeaModel {
        /// <summary>
        /// The ID of the GA instance.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The bandwidth metering method. Valid values:
        /// 
        /// *   **BandwidthPackage:** billed based on bandwidth plans.
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
        public DescribeAcceleratorResponseBodyBasicBandwidthPackage BasicBandwidthPackage { get; set; }
        public class DescribeAcceleratorResponseBodyBasicBandwidthPackage : TeaModel {
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
        /// The ID of the Cloud Enterprise Network (CEN) instance with which the GA instance is associated.
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
        /// The type of cross-border acceleration. This parameter is returned for GA instances whose bandwidth metering method is pay-by-data-transfer (CDT).
        /// 
        /// Only **bpgPro** may be returned, which indicates BGP (Multi-ISP) Pro lines.
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
        public DescribeAcceleratorResponseBodyCrossDomainBandwidthPackage CrossDomainBandwidthPackage { get; set; }
        public class DescribeAcceleratorResponseBodyCrossDomainBandwidthPackage : TeaModel {
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
        /// Indicates whether cross-border acceleration is enabled.
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("CrossPrivateState")]
        [Validation(Required=false)]
        public string CrossPrivateState { get; set; }

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
        /// The billing method of the GA instance.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The configurations of the acceleration area.
        /// </summary>
        [NameInMap("IpSetConfig")]
        [Validation(Required=false)]
        public DescribeAcceleratorResponseBodyIpSetConfig IpSetConfig { get; set; }
        public class DescribeAcceleratorResponseBodyIpSetConfig : TeaModel {
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
        /// The region ID of the GA instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The CNAME that is used to integrate the GA instance with the Anti-DDoS service.
        /// </summary>
        [NameInMap("SecondDnsName")]
        [Validation(Required=false)]
        public string SecondDnsName { get; set; }

        /// <summary>
        /// The ID of the service that manages the GA instance.
        /// 
        /// >  This parameter is returned only if the value of **ServiceManaged** is **true**.
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Indicates whether the GA instance is managed. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// The actions that you can perform on the managed instance.
        /// 
        /// >  * This parameter is returned only if the value of **ServiceManaged** is **true**.
        /// >*   You can perform only specific actions on a managed instance.
        /// </summary>
        [NameInMap("ServiceManagedInfos")]
        [Validation(Required=false)]
        public List<DescribeAcceleratorResponseBodyServiceManagedInfos> ServiceManagedInfos { get; set; }
        public class DescribeAcceleratorResponseBodyServiceManagedInfos : TeaModel {
            /// <summary>
            /// The name of the action performed on the managed instance. Valid values:
            /// 
            /// *   **Create**
            /// *   **Update**
            /// *   **Delete**
            /// *   **Associate**
            /// *   **UserUnmanaged**
            /// *   **CreateChild**
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// The type of the child resource. Valid values:
            /// 
            /// *   **Listener**: a listener.
            /// *   **IpSet**: an acceleration region.
            /// *   **EndpointGroup**: an endpoint group.
            /// *   **ForwardingRule**: a forwarding rule.
            /// *   **Endpoint**: an endpoint.
            /// *   **EndpointGroupDestination**: a protocol mapping of an endpoint group associated with a custom routing listener.
            /// *   **EndpointPolicy**: a traffic policy of an endpoint associated with a custom routing listener.
            /// 
            /// >  This parameter is returned only if the value of **Action** is **CreateChild**.
            /// </summary>
            [NameInMap("ChildType")]
            [Validation(Required=false)]
            public string ChildType { get; set; }

            /// <summary>
            /// Indicates whether the specified actions are managed. Valid values:
            /// 
            /// *   **true**: The specified actions are managed, and you cannot perform the specified actions on the managed instance.
            /// *   **false**: The specified actions are not managed, and you can perform the specified actions on the managed instance.
            /// </summary>
            [NameInMap("IsManaged")]
            [Validation(Required=false)]
            public bool? IsManaged { get; set; }

        }

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
        /// Different specifications provide different capabilities. For more information, see [Instance specifications](https://help.aliyun.com/document_detail/153127.html).
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
        public List<DescribeAcceleratorResponseBodyTags> Tags { get; set; }
        public class DescribeAcceleratorResponseBodyTags : TeaModel {
            /// <summary>
            /// The key of tag N that is added to the GA instance.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N that is added to the GA instance.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// Indicates whether the GA instance can be upgraded. Valid values:
        /// 
        /// *   **notUpgradable:** The GA instance does not need to be upgraded.
        /// *   **upgradable:** The GA instance can be upgraded to the latest version.
        /// *   **upgradeFailed:** The GA instance failed to be upgraded.
        /// </summary>
        [NameInMap("UpgradableStatus")]
        [Validation(Required=false)]
        public string UpgradableStatus { get; set; }

    }

}
