// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class GlobalHotelValidatePriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The business data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GlobalHotelValidatePriceResponseBodyData Data { get; set; }
        public class GlobalHotelValidatePriceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The cancellation policies.</para>
            /// </summary>
            [NameInMap("CancellationPolicies")]
            [Validation(Required=false)]
            public List<GlobalHotelValidatePriceResponseBodyDataCancellationPolicies> CancellationPolicies { get; set; }
            public class GlobalHotelValidatePriceResponseBodyDataCancellationPolicies : TeaModel {
                /// <summary>
                /// <para>The list of cancellation penalty details.</para>
                /// </summary>
                [NameInMap("Penalties")]
                [Validation(Required=false)]
                public List<GlobalHotelValidatePriceResponseBodyDataCancellationPoliciesPenalties> Penalties { get; set; }
                public class GlobalHotelValidatePriceResponseBodyDataCancellationPoliciesPenalties : TeaModel {
                    /// <summary>
                    /// <para>The currency code. This field has a value only when the penalty type is AMOUNT.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>USD</para>
                    /// </summary>
                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// <para>The effective end time as a UTC millisecond timestamp.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1672617600000</para>
                    /// </summary>
                    [NameInMap("End")]
                    [Validation(Required=false)]
                    public string End { get; set; }

                    /// <summary>
                    /// <para>The penalty type (PERCENT/NIGHTS/NON_CANCELLABLE).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PERCENTAGE</para>
                    /// </summary>
                    [NameInMap("PenaltyType")]
                    [Validation(Required=false)]
                    public string PenaltyType { get; set; }

                    /// <summary>
                    /// <para>The penalty value (percentage, amount, or number of nights). This field is not present when PenaltyType is NON_CANCELLABLE.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("PenaltyValue")]
                    [Validation(Required=false)]
                    public string PenaltyValue { get; set; }

                    /// <summary>
                    /// <para>The effective start time as a UTC millisecond timestamp.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1672531200000</para>
                    /// </summary>
                    [NameInMap("Start")]
                    [Validation(Required=false)]
                    public string Start { get; set; }

                    /// <summary>
                    /// <para>TracerId</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TracerId</para>
                    /// </summary>
                    [NameInMap("TracerId")]
                    [Validation(Required=false)]
                    public string TracerId { get; set; }

                }

                /// <summary>
                /// <para>The cancellation policy type (FREE_CANCEL/CONDITIONAL/NON_REFUNDABLE).</para>
                /// 
                /// <b>Example:</b>
                /// <para>FREE_CANCELLATION</para>
                /// </summary>
                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

                /// <summary>
                /// <para>TracerId</para>
                /// 
                /// <b>Example:</b>
                /// <para>TracerId</para>
                /// </summary>
                [NameInMap("TracerId")]
                [Validation(Required=false)]
                public string TracerId { get; set; }

            }

            /// <summary>
            /// <para>The list of daily prices.</para>
            /// </summary>
            [NameInMap("DailyPrices")]
            [Validation(Required=false)]
            public List<GlobalHotelValidatePriceResponseBodyDataDailyPrices> DailyPrices { get; set; }
            public class GlobalHotelValidatePriceResponseBodyDataDailyPrices : TeaModel {
                /// <summary>
                /// <para>The date in yyyy-MM-dd format, in the local time zone of the hotel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-08-16</para>
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <para>The price for the night.</para>
                /// </summary>
                [NameInMap("Price")]
                [Validation(Required=false)]
                public GlobalHotelValidatePriceResponseBodyDataDailyPricesPrice Price { get; set; }
                public class GlobalHotelValidatePriceResponseBodyDataDailyPricesPrice : TeaModel {
                    /// <summary>
                    /// <para>The amount in the smallest currency unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>574</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

                    /// <summary>
                    /// <para>The currency code (ISO 4217).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>USD</para>
                    /// </summary>
                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// <para>null</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("TracerId")]
                    [Validation(Required=false)]
                    public string TracerId { get; set; }

                }

                /// <summary>
                /// <para>null</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("TracerId")]
                [Validation(Required=false)]
                public string TracerId { get; set; }

            }

            /// <summary>
            /// <para>The price validation result ID, used for subsequent order creation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>itemOffer_123</para>
            /// </summary>
            [NameInMap("ItemOfferId")]
            [Validation(Required=false)]
            public string ItemOfferId { get; set; }

            /// <summary>
            /// <para>The total selling price.</para>
            /// </summary>
            [NameInMap("TotalPrice")]
            [Validation(Required=false)]
            public GlobalHotelValidatePriceResponseBodyDataTotalPrice TotalPrice { get; set; }
            public class GlobalHotelValidatePriceResponseBodyDataTotalPrice : TeaModel {
                /// <summary>
                /// <para>The amount in the smallest currency unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>574</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                /// <summary>
                /// <para>The currency code (ISO 4217).</para>
                /// 
                /// <b>Example:</b>
                /// <para>USD</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <para>null</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("TracerId")]
                [Validation(Required=false)]
                public string TracerId { get; set; }

            }

            /// <summary>
            /// <para>TracerId</para>
            /// 
            /// <b>Example:</b>
            /// <para>TracerId</para>
            /// </summary>
            [NameInMap("TracerId")]
            [Validation(Required=false)]
            public string TracerId { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateOrderFailed</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Failed to create order</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>260E4F99-983D-1919-834C-5C42E98E5B2B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>TracerId</para>
        /// 
        /// <b>Example:</b>
        /// <para>TracerId</para>
        /// </summary>
        [NameInMap("TracerId")]
        [Validation(Required=false)]
        public string TracerId { get; set; }

    }

}
