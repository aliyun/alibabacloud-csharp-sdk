// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListBandwidthackagesResponseBody : TeaModel {
        /// <summary>
        /// The details of the bandwidth plans.
        /// </summary>
        [NameInMap("BandwidthPackages")]
        [Validation(Required=false)]
        public List<ListBandwidthackagesResponseBodyBandwidthPackages> BandwidthPackages { get; set; }
        public class ListBandwidthackagesResponseBodyBandwidthPackages : TeaModel {
            /// <summary>
            /// The IDs of the GA instances that are associated with the bandwidth plans.
            /// </summary>
            [NameInMap("Accelerators")]
            [Validation(Required=false)]
            public List<string> Accelerators { get; set; }

            /// <summary>
            /// The bandwidth of the bandwidth plan. Unit: Mbit/s.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// The ID of the bandwidth plan.
            /// </summary>
            [NameInMap("BandwidthPackageId")]
            [Validation(Required=false)]
            public string BandwidthPackageId { get; set; }

            /// <summary>
            /// The billing method of the bandwidth plan. Valid values:
            /// 
            /// *   **PREPAY**: subscription. This is the default value.
            /// *   **POSTPAY**: pay-as-you-go.
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// The time when the bandwidth plan was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The description of the bandwidth plan.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The expiration time of the bandwidth plan.
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// The name of the GA instance.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The request ID.
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
            /// The status of the bandwidth plan. Valid values:
            /// 
            /// *   **init:** The bandwidth plan is being initialized.
            /// *   **active:** The bandwidth plan is available.
            /// *   **binded:** The bandwidth plan is associated with a GA instance.
            /// *   **binding:** The bandwidth plan is being associated with a GA instance.
            /// *   **unbinding:** The bandwidth plan is being disassociated from a GA instance.
            /// *   **updating:** The bandwidth plan is being updated.
            /// *   **finacialLocked:** The bandwidth plan is locked due to overdue payments.
            /// *   **locked:** The bandwidth plan is locked.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The tag of the bandwidth plan.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListBandwidthackagesResponseBodyBandwidthPackagesTags> Tags { get; set; }
            public class ListBandwidthackagesResponseBodyBandwidthPackagesTags : TeaModel {
                /// <summary>
                /// The tag key of the bandwidth plan.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value of the bandwidth plan.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

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
