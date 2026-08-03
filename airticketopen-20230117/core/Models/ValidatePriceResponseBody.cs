// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class ValidatePriceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ValidatePriceResponseBodyData Data { get; set; }
        public class ValidatePriceResponseBodyData : TeaModel {
            [NameInMap("CancellationPolicies")]
            [Validation(Required=false)]
            public List<ValidatePriceResponseBodyDataCancellationPolicies> CancellationPolicies { get; set; }
            public class ValidatePriceResponseBodyDataCancellationPolicies : TeaModel {
                [NameInMap("Penalties")]
                [Validation(Required=false)]
                public List<ValidatePriceResponseBodyDataCancellationPoliciesPenalties> Penalties { get; set; }
                public class ValidatePriceResponseBodyDataCancellationPoliciesPenalties : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>USD</para>
                    /// </summary>
                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1672617600000</para>
                    /// </summary>
                    [NameInMap("End")]
                    [Validation(Required=false)]
                    public long? End { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PERCENTAGE</para>
                    /// </summary>
                    [NameInMap("PenaltyType")]
                    [Validation(Required=false)]
                    public string PenaltyType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("PenaltyValue")]
                    [Validation(Required=false)]
                    public string PenaltyValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1672531200000</para>
                    /// </summary>
                    [NameInMap("Start")]
                    [Validation(Required=false)]
                    public long? Start { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>traceId</para>
                    /// </summary>
                    [NameInMap("TracerId")]
                    [Validation(Required=false)]
                    public string TracerId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>FREE_CANCELLATION</para>
                /// </summary>
                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>traceId</para>
                /// </summary>
                [NameInMap("TracerId")]
                [Validation(Required=false)]
                public string TracerId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>itemOffer_123</para>
            /// </summary>
            [NameInMap("ItemOfferId")]
            [Validation(Required=false)]
            public string ItemOfferId { get; set; }

            [NameInMap("Pricing")]
            [Validation(Required=false)]
            public ValidatePriceResponseBodyDataPricing Pricing { get; set; }
            public class ValidatePriceResponseBodyDataPricing : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>USD</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                [NameInMap("NightlyPrices")]
                [Validation(Required=false)]
                public List<ValidatePriceResponseBodyDataPricingNightlyPrices> NightlyPrices { get; set; }
                public class ValidatePriceResponseBodyDataPricingNightlyPrices : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5000</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-07-01</para>
                    /// </summary>
                    [NameInMap("Date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>traceId</para>
                    /// </summary>
                    [NameInMap("TracerId")]
                    [Validation(Required=false)]
                    public string TracerId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("TotalAmount")]
                [Validation(Required=false)]
                public string TotalAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>traceId</para>
                /// </summary>
                [NameInMap("TracerId")]
                [Validation(Required=false)]
                public string TracerId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>traceId</para>
            /// </summary>
            [NameInMap("TracerId")]
            [Validation(Required=false)]
            public string TracerId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CreateOrderFailed</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>创建订单失败</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>260E4F99-983D-1919-834C-5C42E98E5B2B</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>traceId</para>
        /// </summary>
        [NameInMap("TracerId")]
        [Validation(Required=false)]
        public string TracerId { get; set; }

    }

}
