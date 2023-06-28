// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class GetBasicAcceleratorResponseBody : TeaModel {
        /// <summary>
        /// The ID of the basic GA instance.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The bandwidth metering method.
        /// 
        /// *   **BandwidthPackage**: billed based on bandwidth plans.
        /// *   **CDT**: billed by Cloud Data Transfer (CDT) and based on data transfer.
        /// *   **CDT95**: billed by CDT and based on the 95th percentile bandwidth. This bandwidth metering method is available only to users that are included in the whitelist.
        /// </summary>
        [NameInMap("BandwidthBillingType")]
        [Validation(Required=false)]
        public string BandwidthBillingType { get; set; }

        /// <summary>
        /// The details about the basic bandwidth plan that is associated with the basic GA instance.
        /// </summary>
        [NameInMap("BasicBandwidthPackage")]
        [Validation(Required=false)]
        public GetBasicAcceleratorResponseBodyBasicBandwidthPackage BasicBandwidthPackage { get; set; }
        public class GetBasicAcceleratorResponseBodyBasicBandwidthPackage : TeaModel {
            /// <summary>
            /// The bandwidth value of the basic bandwidth plan. Unit: Mbit/s.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// The type of the bandwidth that is provided by the basic bandwidth plan.
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
        /// The ID of the endpoint group.
        /// </summary>
        [NameInMap("BasicEndpointGroupId")]
        [Validation(Required=false)]
        public string BasicEndpointGroupId { get; set; }

        /// <summary>
        /// The ID of the acceleration region.
        /// </summary>
        [NameInMap("BasicIpSetId")]
        [Validation(Required=false)]
        public string BasicIpSetId { get; set; }

        /// <summary>
        /// The ID of the Cloud Enterprise Network (CEN) instance to which the basic GA instance is attached.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// The timestamp that indicates when the basic GA instance is created.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 基础型全球加速实例是否开启跨境线路功能。取值：
        /// 
        /// - **true**：开启跨境线路功能，可以加速跨境线路。
        /// 
        /// - **false**：关闭跨境线路功能，不可以加速跨境线路。
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
        public GetBasicAcceleratorResponseBodyCrossDomainBandwidthPackage CrossDomainBandwidthPackage { get; set; }
        public class GetBasicAcceleratorResponseBodyCrossDomainBandwidthPackage : TeaModel {
            /// <summary>
            /// The bandwidth value of the cross-border acceleration bandwidth plan. Unit: Mbit/s.
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
        /// The description of the basic GA instance.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The timestamp that indicates when the basic GA instance expires.
        /// 
        /// The time follows the UNIX time format. It is the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public long? ExpiredTime { get; set; }

        /// <summary>
        /// The billing method of the basic GA instance. Only **PREPAY** is returned, which indicates the subscription billing method.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The name of the basic GA instance.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the region where the basic GA instance is deployed.
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
        /// The ID of the resource group to which the basic GA instance belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The status of the basic GA instance.
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
        /// The tags of the basic GA instance.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetBasicAcceleratorResponseBodyTags> Tags { get; set; }
        public class GetBasicAcceleratorResponseBodyTags : TeaModel {
            /// <summary>
            /// The tag key of the basic GA instance.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value of the basic GA instance.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
