// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QuerySavingsPlansDeductLogResponseBody : TeaModel {
        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The return data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySavingsPlansDeductLogResponseBodyData Data { get; set; }
        public class QuerySavingsPlansDeductLogResponseBodyData : TeaModel {
            /// <summary>
            /// The deduction details.
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<QuerySavingsPlansDeductLogResponseBodyDataItems> Items { get; set; }
            public class QuerySavingsPlansDeductLogResponseBodyDataItems : TeaModel {
                /// <summary>
                /// The billable item for which the fee is deducted.
                /// </summary>
                [NameInMap("BillModule")]
                [Validation(Required=false)]
                public string BillModule { get; set; }

                [NameInMap("BillingCycle")]
                [Validation(Required=false)]
                public string BillingCycle { get; set; }

                [NameInMap("BillingOfficialPrice")]
                [Validation(Required=false)]
                public string BillingOfficialPrice { get; set; }

                /// <summary>
                /// The service for which the fee is deducted.
                /// </summary>
                [NameInMap("DeductCommodity")]
                [Validation(Required=false)]
                public string DeductCommodity { get; set; }

                /// <summary>
                /// The deducted amount.
                /// </summary>
                [NameInMap("DeductFee")]
                [Validation(Required=false)]
                public string DeductFee { get; set; }

                /// <summary>
                /// The ID of the instance for which the fee is deducted.
                /// </summary>
                [NameInMap("DeductInstanceId")]
                [Validation(Required=false)]
                public string DeductInstanceId { get; set; }

                /// <summary>
                /// The deduction rate.
                /// </summary>
                [NameInMap("DeductRate")]
                [Validation(Required=false)]
                public string DeductRate { get; set; }

                [NameInMap("DeductedOfficialPrice")]
                [Validation(Required=false)]
                public string DeductedOfficialPrice { get; set; }

                /// <summary>
                /// The discount used for the current deduction.
                /// </summary>
                [NameInMap("DiscountRate")]
                [Validation(Required=false)]
                public string DiscountRate { get; set; }

                /// <summary>
                /// The end of the billing cycle for which the fee is deducted.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The ID of the savings plan instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceSpec")]
                [Validation(Required=false)]
                public string InstanceSpec { get; set; }

                [NameInMap("InstanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }

                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The type of the savings plan. Valid values:
                /// 
                /// *   universal: general-purpose
                /// *   ecs: ECS compute
                /// </summary>
                [NameInMap("SavingsType")]
                [Validation(Required=false)]
                public string SavingsType { get; set; }

                /// <summary>
                /// The beginning of the billing cycle for which the fee is deducted. The time is in the format of yyyy-MM-dd HH:mm:ss.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The ID of the user.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

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
