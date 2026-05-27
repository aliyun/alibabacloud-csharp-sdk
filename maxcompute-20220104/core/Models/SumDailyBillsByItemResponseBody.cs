// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class SumDailyBillsByItemResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public SumDailyBillsByItemResponseBodyData Data { get; set; }
        public class SumDailyBillsByItemResponseBodyData : TeaModel {
            [NameInMap("itemSummaryBills")]
            [Validation(Required=false)]
            public List<SumDailyBillsByItemResponseBodyDataItemSummaryBills> ItemSummaryBills { get; set; }
            public class SumDailyBillsByItemResponseBodyDataItemSummaryBills : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>RMB</para>
                /// </summary>
                [NameInMap("currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                [NameInMap("dailySumBills")]
                [Validation(Required=false)]
                public List<SumDailyBillsByItemResponseBodyDataItemSummaryBillsDailySumBills> DailySumBills { get; set; }
                public class SumDailyBillsByItemResponseBodyDataItemSummaryBillsDailySumBills : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>31</para>
                    /// </summary>
                    [NameInMap("cost")]
                    [Validation(Required=false)]
                    public string Cost { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>RMB</para>
                    /// </summary>
                    [NameInMap("currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20260409</para>
                    /// </summary>
                    [NameInMap("dateTime")]
                    [Validation(Required=false)]
                    public string DateTime { get; set; }

                    [NameInMap("itemBills")]
                    [Validation(Required=false)]
                    public List<SumDailyBillsByItemResponseBodyDataItemSummaryBillsDailySumBillsItemBills> ItemBills { get; set; }
                    public class SumDailyBillsByItemResponseBodyDataItemSummaryBillsDailySumBillsItemBills : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>433</para>
                        /// </summary>
                        [NameInMap("cost")]
                        [Validation(Required=false)]
                        public string Cost { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>RMB</para>
                        /// </summary>
                        [NameInMap("currency")]
                        [Validation(Required=false)]
                        public string Currency { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>empty</para>
                        /// </summary>
                        [NameInMap("itemName")]
                        [Validation(Required=false)]
                        public string ItemName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>60</para>
                        /// </summary>
                        [NameInMap("percentage")]
                        [Validation(Required=false)]
                        public double? Percentage { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DRStorage</para>
                /// </summary>
                [NameInMap("itemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("percentage")]
                [Validation(Required=false)]
                public double? Percentage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OdpsStandard</para>
                /// </summary>
                [NameInMap("specCode")]
                [Validation(Required=false)]
                public string SpecCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("totalCost")]
                [Validation(Required=false)]
                public string TotalCost { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0bc3b4ab17217876841756121e1349</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
