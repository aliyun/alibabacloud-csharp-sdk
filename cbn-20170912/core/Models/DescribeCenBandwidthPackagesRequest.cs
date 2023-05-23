// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenBandwidthPackagesRequest : TeaModel {
        /// <summary>
        /// The description of the bandwidth plan.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeCenBandwidthPackagesRequestFilter> Filter { get; set; }
        public class DescribeCenBandwidthPackagesRequestFilter : TeaModel {
            /// <summary>
            /// The operation that you want to perform. Set the value to **DescribeCenBandwidthPackages**.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The status of the bandwidth plan. Valid values:
            /// 
            /// *   **Normal**: normal
            /// *   **FinancialLocked**: locked due to overdue payments
            /// *   **SecurityLocked**: locked due to security reasons
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// Specifies whether to include renewal data. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("IncludeReservationData")]
        [Validation(Required=false)]
        public bool? IncludeReservationData { get; set; }

        /// <summary>
        /// The ID of the other connected area of the bandwidth plan. Valid values:
        /// 
        /// *   **china**: Chinese mainland.
        /// *   **asia-pacific**: Asia Pacific
        /// *   **europe**: Europe
        /// *   **australia**: Australia
        /// *   **north-america**: North America
        /// </summary>
        [NameInMap("IsOrKey")]
        [Validation(Required=false)]
        public bool? IsOrKey { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// Specify a filter value based on the **Key** parameter.
        /// 
        /// You can specify multiple values for a **filter key**. The logical relation among multiple filter values is **OR**. If a bandwidth package matches one of the values that you specify, the bandwidth package matches the filter condition.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The ID of the peer region.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeCenBandwidthPackagesRequestTag> Tag { get; set; }
        public class DescribeCenBandwidthPackagesRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
