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
        /// The bandwidth billing method. Valid values:
        /// 
        /// *   **BandwidthPackage**: billed based on bandwidth plans.
        /// *   **CDT**: billed based on data transfer.
        /// </summary>
        [NameInMap("BandwidthBillingType")]
        [Validation(Required=false)]
        public string BandwidthBillingType { get; set; }

        /// <summary>
        /// Details about the basic bandwidth plan that is associated with the basic GA instance.
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
        /// The ID of the endpoint group that is associated with the basic GA instance.
        /// </summary>
        [NameInMap("BasicEndpointGroupId")]
        [Validation(Required=false)]
        public string BasicEndpointGroupId { get; set; }

        /// <summary>
        /// The ID of the region where the basic GA instance is deployed.
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
        /// The timestamp that indicates when the basic GA instance was created.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// Details about the cross-region acceleration bandwidth plan that is associated with the GA instance.
        /// 
        /// This parameter is returned only when you call this operation on the International site (alibabacloud.com).
        /// </summary>
        [NameInMap("CrossDomainBandwidthPackage")]
        [Validation(Required=false)]
        public GetBasicAcceleratorResponseBodyCrossDomainBandwidthPackage CrossDomainBandwidthPackage { get; set; }
        public class GetBasicAcceleratorResponseBodyCrossDomainBandwidthPackage : TeaModel {
            /// <summary>
            /// The bandwidth value of the cross-region acceleration bandwidth plan. Unit: Mbit/s.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// The ID of the cross-region acceleration bandwidth plan.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// Indicates whether China Unicom cross-border communication is enabled.
        /// 
        /// *   **true**: China Unicom cross-border communication is enabled.
        /// *   **false**: China Unicom cross-border communication is disabled.
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

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The state of the basic GA instance. Valid values:
        /// 
        /// *   **init**: The basic GA instance is being initialized.
        /// *   **active**: The basic GA instance is available.
        /// *   **configuring**: The basic GA instance is being configured.
        /// *   **binding**: The basic GA instance is being associated.
        /// *   **unbinding**: The basic GA instance is being disassociated.
        /// *   **deleting**: The basic GA instance is being deleted.
        /// *   **finacialLocked**: The basic GA instance is locked due to overdue payments.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetBasicAcceleratorResponseBodyTags> Tags { get; set; }
        public class GetBasicAcceleratorResponseBodyTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
