// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeConfigurationPriceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeConfigurationPriceResponseBodyData Data { get; set; }
        public class DescribeConfigurationPriceResponseBodyData : TeaModel {
            [NameInMap("BagUsage")]
            [Validation(Required=false)]
            public DescribeConfigurationPriceResponseBodyDataBagUsage BagUsage { get; set; }
            public class DescribeConfigurationPriceResponseBodyDataBagUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>497570.450009</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>989802.563546</para>
                /// </summary>
                [NameInMap("Mem")]
                [Validation(Required=false)]
                public float? Mem { get; set; }

            }

            [NameInMap("CpuMemPrice")]
            [Validation(Required=false)]
            public DescribeConfigurationPriceResponseBodyDataCpuMemPrice CpuMemPrice { get; set; }
            public class DescribeConfigurationPriceResponseBodyDataCpuMemPrice : TeaModel {
                [NameInMap("Order")]
                [Validation(Required=false)]
                public DescribeConfigurationPriceResponseBodyDataCpuMemPriceOrder Order { get; set; }
                public class DescribeConfigurationPriceResponseBodyDataCpuMemPriceOrder : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.0009259</para>
                    /// </summary>
                    [NameInMap("DiscountAmount")]
                    [Validation(Required=false)]
                    public float? DiscountAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.0046296</para>
                    /// </summary>
                    [NameInMap("OriginalAmount")]
                    [Validation(Required=false)]
                    public float? OriginalAmount { get; set; }

                    [NameInMap("RuleIds")]
                    [Validation(Required=false)]
                    public List<string> RuleIds { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.0037037</para>
                    /// </summary>
                    [NameInMap("TradeAmount")]
                    [Validation(Required=false)]
                    public float? TradeAmount { get; set; }

                }

                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<DescribeConfigurationPriceResponseBodyDataCpuMemPriceRules> Rules { get; set; }
                public class DescribeConfigurationPriceResponseBodyDataCpuMemPriceRules : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2000010******</para>
                    /// </summary>
                    [NameInMap("RuleDescId")]
                    [Validation(Required=false)]
                    public float? RuleDescId { get; set; }

                }

            }

            [NameInMap("Order")]
            [Validation(Required=false)]
            public DescribeConfigurationPriceResponseBodyDataOrder Order { get; set; }
            public class DescribeConfigurationPriceResponseBodyDataOrder : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0.0018518</para>
                /// </summary>
                [NameInMap("DiscountAmount")]
                [Validation(Required=false)]
                public float? DiscountAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.0092592</para>
                /// </summary>
                [NameInMap("OriginalAmount")]
                [Validation(Required=false)]
                public float? OriginalAmount { get; set; }

                [NameInMap("RuleIds")]
                [Validation(Required=false)]
                public List<string> RuleIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.0074074</para>
                /// </summary>
                [NameInMap("TradeAmount")]
                [Validation(Required=false)]
                public float? TradeAmount { get; set; }

            }

            [NameInMap("RequestPrice")]
            [Validation(Required=false)]
            public DescribeConfigurationPriceResponseBodyDataRequestPrice RequestPrice { get; set; }
            public class DescribeConfigurationPriceResponseBodyDataRequestPrice : TeaModel {
                [NameInMap("Order")]
                [Validation(Required=false)]
                public DescribeConfigurationPriceResponseBodyDataRequestPriceOrder Order { get; set; }
                public class DescribeConfigurationPriceResponseBodyDataRequestPriceOrder : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.0009259</para>
                    /// </summary>
                    [NameInMap("DiscountAmount")]
                    [Validation(Required=false)]
                    public float? DiscountAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.0046296</para>
                    /// </summary>
                    [NameInMap("OriginalAmount")]
                    [Validation(Required=false)]
                    public float? OriginalAmount { get; set; }

                    [NameInMap("RuleIds")]
                    [Validation(Required=false)]
                    public List<string> RuleIds { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.0037037</para>
                    /// </summary>
                    [NameInMap("TradeAmount")]
                    [Validation(Required=false)]
                    public float? TradeAmount { get; set; }

                }

                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<DescribeConfigurationPriceResponseBodyDataRequestPriceRules> Rules { get; set; }
                public class DescribeConfigurationPriceResponseBodyDataRequestPriceRules : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2000010******</para>
                    /// </summary>
                    [NameInMap("RuleDescId")]
                    [Validation(Required=false)]
                    public long? RuleDescId { get; set; }

                }

            }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeConfigurationPriceResponseBodyDataRules> Rules { get; set; }
            public class DescribeConfigurationPriceResponseBodyDataRules : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2000010******</para>
                /// </summary>
                [NameInMap("RuleDescId")]
                [Validation(Required=false)]
                public long? RuleDescId { get; set; }

            }

            [NameInMap("TrafficPrice")]
            [Validation(Required=false)]
            public DescribeConfigurationPriceResponseBodyDataTrafficPrice TrafficPrice { get; set; }
            public class DescribeConfigurationPriceResponseBodyDataTrafficPrice : TeaModel {
                [NameInMap("Order")]
                [Validation(Required=false)]
                public DescribeConfigurationPriceResponseBodyDataTrafficPriceOrder Order { get; set; }
                public class DescribeConfigurationPriceResponseBodyDataTrafficPriceOrder : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.0009259</para>
                    /// </summary>
                    [NameInMap("DiscountAmount")]
                    [Validation(Required=false)]
                    public float? DiscountAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.0046296</para>
                    /// </summary>
                    [NameInMap("OriginalAmount")]
                    [Validation(Required=false)]
                    public float? OriginalAmount { get; set; }

                    [NameInMap("RuleIds")]
                    [Validation(Required=false)]
                    public List<string> RuleIds { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.0037037</para>
                    /// </summary>
                    [NameInMap("TradeAmount")]
                    [Validation(Required=false)]
                    public float? TradeAmount { get; set; }

                }

                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<DescribeConfigurationPriceResponseBodyDataTrafficPriceRules> Rules { get; set; }
                public class DescribeConfigurationPriceResponseBodyDataTrafficPriceRules : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2000010******</para>
                    /// </summary>
                    [NameInMap("RuleDescId")]
                    [Validation(Required=false)]
                    public float? RuleDescId { get; set; }

                }

            }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ADCEC067-86AD-19E2-BD43-E83F3841****</para>
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
        /// <para>1a0dcc771722848598056771******</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
