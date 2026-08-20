// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class TicketQueryPriceStockResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TicketQueryPriceStockResponseBodyData Data { get; set; }
        public class TicketQueryPriceStockResponseBodyData : TeaModel {
            [NameInMap("CalendarPriceStocks")]
            [Validation(Required=false)]
            public List<TicketQueryPriceStockResponseBodyDataCalendarPriceStocks> CalendarPriceStocks { get; set; }
            public class TicketQueryPriceStockResponseBodyDataCalendarPriceStocks : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-10-01</para>
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                [NameInMap("DistributionPrice")]
                [Validation(Required=false)]
                public TicketQueryPriceStockResponseBodyDataCalendarPriceStocksDistributionPrice DistributionPrice { get; set; }
                public class TicketQueryPriceStockResponseBodyDataCalendarPriceStocksDistributionPrice : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public long? Amount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>USD</para>
                    /// </summary>
                    [NameInMap("CurrencyCode")]
                    [Validation(Required=false)]
                    public string CurrencyCode { get; set; }

                }

                [NameInMap("MarketPrice")]
                [Validation(Required=false)]
                public TicketQueryPriceStockResponseBodyDataCalendarPriceStocksMarketPrice MarketPrice { get; set; }
                public class TicketQueryPriceStockResponseBodyDataCalendarPriceStocksMarketPrice : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public long? Amount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>USD</para>
                    /// </summary>
                    [NameInMap("CurrencyCode")]
                    [Validation(Required=false)]
                    public string CurrencyCode { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Stock")]
                [Validation(Required=false)]
                public long? Stock { get; set; }

                [NameInMap("SuggestedPrice")]
                [Validation(Required=false)]
                public TicketQueryPriceStockResponseBodyDataCalendarPriceStocksSuggestedPrice SuggestedPrice { get; set; }
                public class TicketQueryPriceStockResponseBodyDataCalendarPriceStocksSuggestedPrice : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public long? Amount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>USD</para>
                    /// </summary>
                    [NameInMap("CurrencyCode")]
                    [Validation(Required=false)]
                    public string CurrencyCode { get; set; }

                }

            }

            [NameInMap("NormalPriceStock")]
            [Validation(Required=false)]
            public TicketQueryPriceStockResponseBodyDataNormalPriceStock NormalPriceStock { get; set; }
            public class TicketQueryPriceStockResponseBodyDataNormalPriceStock : TeaModel {
                [NameInMap("DistributionPrice")]
                [Validation(Required=false)]
                public TicketQueryPriceStockResponseBodyDataNormalPriceStockDistributionPrice DistributionPrice { get; set; }
                public class TicketQueryPriceStockResponseBodyDataNormalPriceStockDistributionPrice : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public long? Amount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>USD</para>
                    /// </summary>
                    [NameInMap("CurrencyCode")]
                    [Validation(Required=false)]
                    public string CurrencyCode { get; set; }

                }

                [NameInMap("MarketPrice")]
                [Validation(Required=false)]
                public TicketQueryPriceStockResponseBodyDataNormalPriceStockMarketPrice MarketPrice { get; set; }
                public class TicketQueryPriceStockResponseBodyDataNormalPriceStockMarketPrice : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public long? Amount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>USD</para>
                    /// </summary>
                    [NameInMap("CurrencyCode")]
                    [Validation(Required=false)]
                    public string CurrencyCode { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Stock")]
                [Validation(Required=false)]
                public long? Stock { get; set; }

                [NameInMap("SuggestedPrice")]
                [Validation(Required=false)]
                public TicketQueryPriceStockResponseBodyDataNormalPriceStockSuggestedPrice SuggestedPrice { get; set; }
                public class TicketQueryPriceStockResponseBodyDataNormalPriceStockSuggestedPrice : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public long? Amount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>USD</para>
                    /// </summary>
                    [NameInMap("CurrencyCode")]
                    [Validation(Required=false)]
                    public string CurrencyCode { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StockType")]
            [Validation(Required=false)]
            public int? StockType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ScenicIdInvalid</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ScenicId不合法</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>51593418-8C73-5E47-8BA8-3F1D4A00CC0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
