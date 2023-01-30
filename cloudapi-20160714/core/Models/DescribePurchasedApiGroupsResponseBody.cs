// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribePurchasedApiGroupsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The attributes of the API group.
        /// </summary>
        [NameInMap("PurchasedApiGroupAttributes")]
        [Validation(Required=false)]
        public DescribePurchasedApiGroupsResponseBodyPurchasedApiGroupAttributes PurchasedApiGroupAttributes { get; set; }
        public class DescribePurchasedApiGroupsResponseBodyPurchasedApiGroupAttributes : TeaModel {
            [NameInMap("PurchasedApiGroupAttribute")]
            [Validation(Required=false)]
            public List<DescribePurchasedApiGroupsResponseBodyPurchasedApiGroupAttributesPurchasedApiGroupAttribute> PurchasedApiGroupAttribute { get; set; }
            public class DescribePurchasedApiGroupsResponseBodyPurchasedApiGroupAttributesPurchasedApiGroupAttribute : TeaModel {
                /// <summary>
                /// The ID of the region where the API group is located.
                /// </summary>
                [NameInMap("BillingType")]
                [Validation(Required=false)]
                public string BillingType { get; set; }

                /// <summary>
                /// The name of the API group.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The description of the API group.
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// The maximum number of calls.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The ID of the API group.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The current number of calls.
                /// </summary>
                [NameInMap("InvokeTimesMax")]
                [Validation(Required=false)]
                public long? InvokeTimesMax { get; set; }

                /// <summary>
                /// The billing method.
                /// </summary>
                [NameInMap("InvokeTimesNow")]
                [Validation(Required=false)]
                public long? InvokeTimesNow { get; set; }

                /// <summary>
                /// The time when the API group expires.
                /// </summary>
                [NameInMap("PurchasedTime")]
                [Validation(Required=false)]
                public string PurchasedTime { get; set; }

                /// <summary>
                /// auditing
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The time when the API group was purchased.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The attributes of the API group.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
