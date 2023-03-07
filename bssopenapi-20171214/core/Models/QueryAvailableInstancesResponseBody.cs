// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryAvailableInstancesResponseBody : TeaModel {
        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAvailableInstancesResponseBodyData Data { get; set; }
        public class QueryAvailableInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// The instances returned.
            /// </summary>
            [NameInMap("InstanceList")]
            [Validation(Required=false)]
            public List<QueryAvailableInstancesResponseBodyDataInstanceList> InstanceList { get; set; }
            public class QueryAvailableInstancesResponseBodyDataInstanceList : TeaModel {
                /// <summary>
                /// The time when the specified instance was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The time when the instance was expired.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The time when the specified instance was expected to be released.
                /// </summary>
                [NameInMap("ExpectedReleaseTime")]
                [Validation(Required=false)]
                public string ExpectedReleaseTime { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceID")]
                [Validation(Required=false)]
                public string InstanceID { get; set; }

                /// <summary>
                /// The ID of the instance owner.
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                /// <summary>
                /// The code of the service.
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                /// <summary>
                /// The type of the service.
                /// </summary>
                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

                /// <summary>
                /// The ID of the region in which the instance resides.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The time when the instance was released.
                /// </summary>
                [NameInMap("ReleaseTime")]
                [Validation(Required=false)]
                public string ReleaseTime { get; set; }

                /// <summary>
                /// The renewal status of the specified instance. Valid values:
                /// 
                /// *   AutoRenewal: The instance is automatically renewed.
                /// *   ManualRenewal: The instance is manually renewed.
                /// *   NotRenewal: The instance is not renewed.
                /// </summary>
                [NameInMap("RenewStatus")]
                [Validation(Required=false)]
                public string RenewStatus { get; set; }

                /// <summary>
                /// The number of auto-renewal cycles.
                /// </summary>
                [NameInMap("RenewalDuration")]
                [Validation(Required=false)]
                public int? RenewalDuration { get; set; }

                /// <summary>
                /// The unit of the auto-renewal cycle. Valid values:
                /// 
                /// *   M: month
                /// *   Y: year
                /// </summary>
                [NameInMap("RenewalDurationUnit")]
                [Validation(Required=false)]
                public string RenewalDurationUnit { get; set; }

                /// <summary>
                /// The seller.
                /// </summary>
                [NameInMap("Seller")]
                [Validation(Required=false)]
                public string Seller { get; set; }

                /// <summary>
                /// The ID of the seller.
                /// </summary>
                [NameInMap("SellerId")]
                [Validation(Required=false)]
                public long? SellerId { get; set; }

                /// <summary>
                /// The status of the instance.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The time when the specified instance was suspended.
                /// </summary>
                [NameInMap("StopTime")]
                [Validation(Required=false)]
                public string StopTime { get; set; }

                /// <summary>
                /// The sub-status of the specified instance.
                /// </summary>
                [NameInMap("SubStatus")]
                [Validation(Required=false)]
                public string SubStatus { get; set; }

                /// <summary>
                /// The billing method. Valid values:
                /// 
                /// *   Subscription: subscription
                /// *   PayAsYouGo: pay-as-you-go
                /// </summary>
                [NameInMap("SubscriptionType")]
                [Validation(Required=false)]
                public string SubscriptionType { get; set; }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
