// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeResourceUsageDetailResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeResourceUsageDetailResponseBodyData Data { get; set; }
        public class DescribeResourceUsageDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The data entries.
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeResourceUsageDetailResponseBodyDataItems> Items { get; set; }
            public class DescribeResourceUsageDetailResponseBodyDataItems : TeaModel {
                /// <summary>
                /// The unit that is used to measure the resources that are deducted.
                /// </summary>
                [NameInMap("CapacityUnit")]
                [Validation(Required=false)]
                public string CapacityUnit { get; set; }

                /// <summary>
                /// The type of the currency.
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// The amount of the deducted resources.
                /// </summary>
                [NameInMap("DeductQuantity")]
                [Validation(Required=false)]
                public float? DeductQuantity { get; set; }

                /// <summary>
                /// The end of the time range in which the usage details were queried.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The operating system.
                /// </summary>
                [NameInMap("ImageType")]
                [Validation(Required=false)]
                public string ImageType { get; set; }

                /// <summary>
                /// The instance type.
                /// </summary>
                [NameInMap("InstanceSpec")]
                [Validation(Required=false)]
                public string InstanceSpec { get; set; }

                /// <summary>
                /// The equivalent of pay-as-you-go costs.
                /// </summary>
                [NameInMap("PostpaidCost")]
                [Validation(Required=false)]
                public string PostpaidCost { get; set; }

                /// <summary>
                /// The potential net savings.
                /// </summary>
                [NameInMap("PotentialSavedCost")]
                [Validation(Required=false)]
                public string PotentialSavedCost { get; set; }

                /// <summary>
                /// The number of deduction plans.
                /// </summary>
                [NameInMap("Quantity")]
                [Validation(Required=false)]
                public long? Quantity { get; set; }

                /// <summary>
                /// The region.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The code of the region.
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

                /// <summary>
                /// The fee of the deduction plan.
                /// </summary>
                [NameInMap("ReservationCost")]
                [Validation(Required=false)]
                public string ReservationCost { get; set; }

                /// <summary>
                /// The ID of the deduction plan.
                /// </summary>
                [NameInMap("ResourceInstanceId")]
                [Validation(Required=false)]
                public string ResourceInstanceId { get; set; }

                /// <summary>
                /// The net savings.
                /// </summary>
                [NameInMap("SavedCost")]
                [Validation(Required=false)]
                public string SavedCost { get; set; }

                /// <summary>
                /// The beginning of the time range in which the usage details were queried.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The status of the deduction plan.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The name of the status.
                /// </summary>
                [NameInMap("StatusName")]
                [Validation(Required=false)]
                public string StatusName { get; set; }

                /// <summary>
                /// The total capacity of the deduction plan.
                /// </summary>
                [NameInMap("TotalQuantity")]
                [Validation(Required=false)]
                public float? TotalQuantity { get; set; }

                /// <summary>
                /// The usage rate of the deduction plan.
                /// </summary>
                [NameInMap("UsagePercentage")]
                [Validation(Required=false)]
                public float? UsagePercentage { get; set; }

                /// <summary>
                /// The account ID.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// The username of the account.
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// The zone.
                /// </summary>
                [NameInMap("Zone")]
                [Validation(Required=false)]
                public string Zone { get; set; }

                /// <summary>
                /// The code of the zone.
                /// </summary>
                [NameInMap("ZoneName")]
                [Validation(Required=false)]
                public string ZoneName { get; set; }

            }

            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// A pagination token. It can be used in the next request to retrieve a new page of results.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
