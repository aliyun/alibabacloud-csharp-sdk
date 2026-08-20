// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class TicketCheckRefundResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TicketCheckRefundResponseBodyData Data { get; set; }
        public class TicketCheckRefundResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanRefund")]
            [Validation(Required=false)]
            public bool? CanRefund { get; set; }

            [NameInMap("RefundAmount")]
            [Validation(Required=false)]
            public TicketCheckRefundResponseBodyDataRefundAmount RefundAmount { get; set; }
            public class TicketCheckRefundResponseBodyDataRefundAmount : TeaModel {
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

            [NameInMap("RefundRule")]
            [Validation(Required=false)]
            public TicketCheckRefundResponseBodyDataRefundRule RefundRule { get; set; }
            public class TicketCheckRefundResponseBodyDataRefundRule : TeaModel {
                [NameInMap("RefundStageRules")]
                [Validation(Required=false)]
                public List<TicketCheckRefundResponseBodyDataRefundRuleRefundStageRules> RefundStageRules { get; set; }
                public class TicketCheckRefundResponseBodyDataRefundRuleRefundStageRules : TeaModel {
                    [NameInMap("Fee")]
                    [Validation(Required=false)]
                    public double? Fee { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("FeeBase")]
                    [Validation(Required=false)]
                    public int? FeeBase { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("FeeType")]
                    [Validation(Required=false)]
                    public int? FeeType { get; set; }

                    [NameInMap("From")]
                    [Validation(Required=false)]
                    public TicketCheckRefundResponseBodyDataRefundRuleRefundStageRulesFrom From { get; set; }
                    public class TicketCheckRefundResponseBodyDataRefundRuleRefundStageRulesFrom : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Anchor")]
                        [Validation(Required=false)]
                        public int? Anchor { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2026-01-01</para>
                        /// </summary>
                        [NameInMap("FixedTime")]
                        [Validation(Required=false)]
                        public string FixedTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>18:00</para>
                        /// </summary>
                        [NameInMap("OffsetDayOfTime")]
                        [Validation(Required=false)]
                        public string OffsetDayOfTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("OffsetUnit")]
                        [Validation(Required=false)]
                        public int? OffsetUnit { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("OffsetValue")]
                        [Validation(Required=false)]
                        public int? OffsetValue { get; set; }

                    }

                    [NameInMap("To")]
                    [Validation(Required=false)]
                    public TicketCheckRefundResponseBodyDataRefundRuleRefundStageRulesTo To { get; set; }
                    public class TicketCheckRefundResponseBodyDataRefundRuleRefundStageRulesTo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Anchor")]
                        [Validation(Required=false)]
                        public int? Anchor { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2026-01-01</para>
                        /// </summary>
                        [NameInMap("FixedTime")]
                        [Validation(Required=false)]
                        public string FixedTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>18:00</para>
                        /// </summary>
                        [NameInMap("OffsetDayOfTime")]
                        [Validation(Required=false)]
                        public string OffsetDayOfTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("OffsetUnit")]
                        [Validation(Required=false)]
                        public int? OffsetUnit { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("OffsetValue")]
                        [Validation(Required=false)]
                        public int? OffsetValue { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RefundType")]
                [Validation(Required=false)]
                public int? RefundType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DistributorOrderIdInvalid</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>分销商订单号不合法</para>
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
