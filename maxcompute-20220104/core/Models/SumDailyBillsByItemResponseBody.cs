// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class SumDailyBillsByItemResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public SumDailyBillsByItemResponseBodyData Data { get; set; }
        public class SumDailyBillsByItemResponseBodyData : TeaModel {
            /// <summary>
            /// <para>An array of item-level cost summaries.</para>
            /// </summary>
            [NameInMap("itemSummaryBills")]
            [Validation(Required=false)]
            public List<SumDailyBillsByItemResponseBodyDataItemSummaryBills> ItemSummaryBills { get; set; }
            public class SumDailyBillsByItemResponseBodyDataItemSummaryBills : TeaModel {
                /// <summary>
                /// <para>The currency of the cost.</para>
                /// </summary>
                [NameInMap("currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <para>An array of daily cost summaries for the item.</para>
                /// </summary>
                [NameInMap("dailySumBills")]
                [Validation(Required=false)]
                public List<SumDailyBillsByItemResponseBodyDataItemSummaryBillsDailySumBills> DailySumBills { get; set; }
                public class SumDailyBillsByItemResponseBodyDataItemSummaryBillsDailySumBills : TeaModel {
                    /// <summary>
                    /// <para>The cost for the day.</para>
                    /// </summary>
                    [NameInMap("cost")]
                    [Validation(Required=false)]
                    public string Cost { get; set; }

                    /// <summary>
                    /// <para>The currency of the cost.</para>
                    /// </summary>
                    [NameInMap("currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// <para>The date. Format: YYYYMMDD.</para>
                    /// </summary>
                    [NameInMap("dateTime")]
                    [Validation(Required=false)]
                    public string DateTime { get; set; }

                    /// <summary>
                    /// <para>An array of detailed bills for the item on the specified day.</para>
                    /// </summary>
                    [NameInMap("itemBills")]
                    [Validation(Required=false)]
                    public List<SumDailyBillsByItemResponseBodyDataItemSummaryBillsDailySumBillsItemBills> ItemBills { get; set; }
                    public class SumDailyBillsByItemResponseBodyDataItemSummaryBillsDailySumBillsItemBills : TeaModel {
                        /// <summary>
                        /// <para>The cost of the item.</para>
                        /// </summary>
                        [NameInMap("cost")]
                        [Validation(Required=false)]
                        public string Cost { get; set; }

                        /// <summary>
                        /// <para>The currency of the cost.</para>
                        /// </summary>
                        [NameInMap("currency")]
                        [Validation(Required=false)]
                        public string Currency { get; set; }

                        /// <summary>
                        /// <para>The name of the billable item.</para>
                        /// </summary>
                        [NameInMap("itemName")]
                        [Validation(Required=false)]
                        public string ItemName { get; set; }

                        /// <summary>
                        /// <para>The item\&quot;s percentage of the daily total cost.</para>
                        /// </summary>
                        [NameInMap("percentage")]
                        [Validation(Required=false)]
                        public double? Percentage { get; set; }

                    }

                }

                /// <summary>
                /// <para>The name of the billable item.</para>
                /// </summary>
                [NameInMap("itemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                /// <summary>
                /// <para>The item\&quot;s percentage of the total cost.</para>
                /// </summary>
                [NameInMap("percentage")]
                [Validation(Required=false)]
                public double? Percentage { get; set; }

                /// <summary>
                /// <para>The specification code of the item.</para>
                /// </summary>
                [NameInMap("specCode")]
                [Validation(Required=false)]
                public string SpecCode { get; set; }

                /// <summary>
                /// <para>The total cost of the item.</para>
                /// </summary>
                [NameInMap("totalCost")]
                [Validation(Required=false)]
                public string TotalCost { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The unique identifier for the request.</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
