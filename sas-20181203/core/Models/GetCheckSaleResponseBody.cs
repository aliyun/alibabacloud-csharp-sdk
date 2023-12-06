// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckSaleResponseBody : TeaModel {
        /// <summary>
        /// The sales information about the configuration assessment quota.
        /// </summary>
        [NameInMap("CheckSale")]
        [Validation(Required=false)]
        public GetCheckSaleResponseBodyCheckSale CheckSale { get; set; }
        public class GetCheckSaleResponseBodyCheckSale : TeaModel {
            /// <summary>
            /// The consumed quota.
            /// </summary>
            [NameInMap("ConsumeCount")]
            [Validation(Required=false)]
            public long? ConsumeCount { get; set; }

            /// <summary>
            /// Indicates whether the user is an existing user and whether the user uses the configuration assessment feature before the feature is released for sale on July 07, 2023. Valid values:
            /// 
            /// *   **true**: existing user
            /// *   **false**: new user
            /// </summary>
            [NameInMap("LoyalUser")]
            [Validation(Required=false)]
            public bool? LoyalUser { get; set; }

            /// <summary>
            /// The purchased quota.
            /// </summary>
            [NameInMap("PurchaseCount")]
            [Validation(Required=false)]
            public long? PurchaseCount { get; set; }

            /// <summary>
            /// The type of the user. Valid values:
            /// 
            /// *   **1**: a user who can use all check items.
            /// *   **2**: an user who can only use the check items before the release of the feature on July 07, 2023. This type of users must upgrade Security Center before the users can use all check items.
            /// *   **3**: a new user who cannot use the configuration assessment feature. This type of users must make a purchase before the users can use the feature.
            /// </summary>
            [NameInMap("SaleUserType")]
            [Validation(Required=false)]
            public int? SaleUserType { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
