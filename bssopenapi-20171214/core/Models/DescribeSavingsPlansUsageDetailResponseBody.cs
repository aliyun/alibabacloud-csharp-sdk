// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeSavingsPlansUsageDetailResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The return data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSavingsPlansUsageDetailResponseBodyData Data { get; set; }
        public class DescribeSavingsPlansUsageDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The data entries.
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeSavingsPlansUsageDetailResponseBodyDataItems> Items { get; set; }
            public class DescribeSavingsPlansUsageDetailResponseBodyDataItems : TeaModel {
                /// <summary>
                /// The currency.
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// The used amount of the savings plan.
                /// </summary>
                [NameInMap("DeductValue")]
                [Validation(Required=false)]
                public float? DeductValue { get; set; }

                /// <summary>
                /// The end time.
                /// </summary>
                [NameInMap("EndPeriod")]
                [Validation(Required=false)]
                public string EndPeriod { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The total amount of the savings plan.
                /// </summary>
                [NameInMap("PoolValue")]
                [Validation(Required=false)]
                public float? PoolValue { get; set; }

                /// <summary>
                /// The pay-as-you-go cost.
                /// </summary>
                [NameInMap("PostpaidCost")]
                [Validation(Required=false)]
                public float? PostpaidCost { get; set; }

                /// <summary>
                /// The amount that is saved.
                /// </summary>
                [NameInMap("SavedCost")]
                [Validation(Required=false)]
                public float? SavedCost { get; set; }

                /// <summary>
                /// The start time.
                /// </summary>
                [NameInMap("StartPeriod")]
                [Validation(Required=false)]
                public string StartPeriod { get; set; }

                /// <summary>
                /// The status of the instance.
                /// 
                /// A value of -1 indicates that the payment is overdue. A value of 1 indicates that the instance is active.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The type of the savings plan. Valid values: universal and ECS compute.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The usage.
                /// </summary>
                [NameInMap("UsagePercentage")]
                [Validation(Required=false)]
                public float? UsagePercentage { get; set; }

                /// <summary>
                /// The ID of the account.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                /// <summary>
                /// The username of the account.
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// The token of the next page.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// The total number of entries.
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
        /// Indicates whether the operation was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
