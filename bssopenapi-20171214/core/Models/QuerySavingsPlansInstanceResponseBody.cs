// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QuerySavingsPlansInstanceResponseBody : TeaModel {
        /// <summary>
        /// The prepaid amount.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The commitment.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySavingsPlansInstanceResponseBodyData Data { get; set; }
        public class QuerySavingsPlansInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// The number of the page to return.
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<QuerySavingsPlansInstanceResponseBodyDataItems> Items { get; set; }
            public class QuerySavingsPlansInstanceResponseBodyDataItems : TeaModel {
                /// <summary>
                /// The allocation status. Valid values:
                /// 
                /// *   unallocated
                /// *   allocated
                /// *   beAllocated
                /// </summary>
                [NameInMap("AllocationStatus")]
                [Validation(Required=false)]
                public string AllocationStatus { get; set; }

                /// <summary>
                /// The status of the instance. Valid values:
                /// 
                /// *   NORMAL: normal
                /// *   LIMIT: stopped due to overdue payment
                /// *   RELEASE: released
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                [NameInMap("Cycle")]
                [Validation(Required=false)]
                public string Cycle { get; set; }

                [NameInMap("DeductCycleType")]
                [Validation(Required=false)]
                public string DeductCycleType { get; set; }

                /// <summary>
                /// The ID of the savings plan instance.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("EndTimestamp")]
                [Validation(Required=false)]
                public long? EndTimestamp { get; set; }

                /// <summary>
                /// The value of the tag.
                /// </summary>
                [NameInMap("InstanceFamily")]
                [Validation(Required=false)]
                public string InstanceFamily { get; set; }

                /// <summary>
                /// The time when the instance takes effect. The time is in the format of yyyy-MM-dd HH:mm:ss.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("LastBillTotalUsage")]
                [Validation(Required=false)]
                public string LastBillTotalUsage { get; set; }

                [NameInMap("LastBillUtilization")]
                [Validation(Required=false)]
                public string LastBillUtilization { get; set; }

                [NameInMap("PayMode")]
                [Validation(Required=false)]
                public string PayMode { get; set; }

                /// <summary>
                /// The total amount that is saved.
                /// </summary>
                [NameInMap("PoolValue")]
                [Validation(Required=false)]
                public string PoolValue { get; set; }

                /// <summary>
                /// The page number of the returned page.
                /// </summary>
                [NameInMap("PrepayFee")]
                [Validation(Required=false)]
                public string PrepayFee { get; set; }

                /// <summary>
                /// The total number of entries.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("RestPoolValue")]
                [Validation(Required=false)]
                public string RestPoolValue { get; set; }

                /// <summary>
                /// The key of the tag.
                /// </summary>
                [NameInMap("SavingsType")]
                [Validation(Required=false)]
                public string SavingsType { get; set; }

                /// <summary>
                /// The payment type. Valid values:
                /// 
                /// *   total: All Upfront
                /// *   half: Partial Upfront
                /// *   zero: No Upfront
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("StartTimestamp")]
                [Validation(Required=false)]
                public long? StartTimestamp { get; set; }

                /// <summary>
                /// The value of the tag to query.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<QuerySavingsPlansInstanceResponseBodyDataItemsTags> Tags { get; set; }
                public class QuerySavingsPlansInstanceResponseBodyDataItemsTags : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("TotalSave")]
                [Validation(Required=false)]
                public string TotalSave { get; set; }

                /// <summary>
                /// The currency. Valid values: CNY and USD.
                /// </summary>
                [NameInMap("Utilization")]
                [Validation(Required=false)]
                public string Utilization { get; set; }

            }

            /// <summary>
            /// The type of the savings plan. Valid values:
            /// 
            /// *   universal: general-purpose
            /// *   ecs: ECS compute
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// The key of the tag to query.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The language of the return data. Valid values:
            /// 
            /// *   ZH: Chinese
            /// *   EN: English
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The details about the instances.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The return data.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The region.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
