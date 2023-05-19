// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QuerySavingsPlansDeductLogResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The type of the savings plan. Valid values:
        /// 
        /// *   universal: general-purpose
        /// *   ecs: ECS compute
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySavingsPlansDeductLogResponseBodyData Data { get; set; }
        public class QuerySavingsPlansDeductLogResponseBodyData : TeaModel {
            /// <summary>
            /// The deduction rate.
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<QuerySavingsPlansDeductLogResponseBodyDataItems> Items { get; set; }
            public class QuerySavingsPlansDeductLogResponseBodyDataItems : TeaModel {
                /// <summary>
                /// The total number of entries.
                /// </summary>
                [NameInMap("BillModule")]
                [Validation(Required=false)]
                public string BillModule { get; set; }

                [NameInMap("DeductCommodity")]
                [Validation(Required=false)]
                public string DeductCommodity { get; set; }

                [NameInMap("DeductFee")]
                [Validation(Required=false)]
                public string DeductFee { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("DeductInstanceId")]
                [Validation(Required=false)]
                public string DeductInstanceId { get; set; }

                [NameInMap("DeductRate")]
                [Validation(Required=false)]
                public string DeductRate { get; set; }

                /// <summary>
                /// The billable item for which the fee is deducted.
                /// </summary>
                [NameInMap("DiscountRate")]
                [Validation(Required=false)]
                public string DiscountRate { get; set; }

                /// <summary>
                /// The page number of the returned page.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The service for which the fee is deducted.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                /// <summary>
                /// The ID of the instance for which the fee is deducted.
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
                /// The number of the page to return.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

            }

            /// <summary>
            /// The number of entries to return on each page.
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// The language of the return data. Valid values:
            /// 
            /// *   ZH: Chinese
            /// *   EN: English
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The end of the time range to query. Specify the time in the format of yyyy-MM-dd HH:mm:ss.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the savings plan instance.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The deduction details.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The return data.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
