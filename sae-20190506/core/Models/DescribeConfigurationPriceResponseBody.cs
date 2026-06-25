// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeConfigurationPriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code or POP error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: The request was redirected.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: A request error occurred.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: A server error occurred.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The pricing information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeConfigurationPriceResponseBodyData Data { get; set; }
        public class DescribeConfigurationPriceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The remaining quota of the resource plan.</para>
            /// </summary>
            [NameInMap("BagUsage")]
            [Validation(Required=false)]
            public DescribeConfigurationPriceResponseBodyDataBagUsage BagUsage { get; set; }
            public class DescribeConfigurationPriceResponseBodyDataBagUsage : TeaModel {
                /// <summary>
                /// <para>The remaining CPU quota. Unit: core-hours.</para>
                /// 
                /// <b>Example:</b>
                /// <para>497570.450009</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                /// <summary>
                /// <para>The remaining computing units (CUs) of the resource plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("Cu")]
                [Validation(Required=false)]
                public float? Cu { get; set; }

                /// <summary>
                /// <para>The remaining memory quota. Unit: GiB-hours.</para>
                /// 
                /// <b>Example:</b>
                /// <para>989802.563546</para>
                /// </summary>
                [NameInMap("Mem")]
                [Validation(Required=false)]
                public float? Mem { get; set; }

            }

            /// <summary>
            /// <para>The price of CPU and memory.</para>
            /// </summary>
            [NameInMap("CpuMemPrice")]
            [Validation(Required=false)]
            public DescribeConfigurationPriceResponseBodyDataCpuMemPrice CpuMemPrice { get; set; }
            public class DescribeConfigurationPriceResponseBodyDataCpuMemPrice : TeaModel {
                /// <summary>
                /// <para>The pricing information.</para>
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public DescribeConfigurationPriceResponseBodyDataCpuMemPriceOrder Order { get; set; }
                public class DescribeConfigurationPriceResponseBodyDataCpuMemPriceOrder : TeaModel {
                    /// <summary>
                    /// <para>The discount amount of the order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0009259</para>
                    /// </summary>
                    [NameInMap("DiscountAmount")]
                    [Validation(Required=false)]
                    public float? DiscountAmount { get; set; }

                    /// <summary>
                    /// <para>The original price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0046296</para>
                    /// </summary>
                    [NameInMap("OriginalAmount")]
                    [Validation(Required=false)]
                    public float? OriginalAmount { get; set; }

                    /// <summary>
                    /// <para>The rule ID.</para>
                    /// </summary>
                    [NameInMap("RuleIds")]
                    [Validation(Required=false)]
                    public List<string> RuleIds { get; set; }

                    /// <summary>
                    /// <para>The actual transaction price of the order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0037037</para>
                    /// </summary>
                    [NameInMap("TradeAmount")]
                    [Validation(Required=false)]
                    public float? TradeAmount { get; set; }

                }

                /// <summary>
                /// <para>The promotion rules.</para>
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<DescribeConfigurationPriceResponseBodyDataCpuMemPriceRules> Rules { get; set; }
                public class DescribeConfigurationPriceResponseBodyDataCpuMemPriceRules : TeaModel {
                    /// <summary>
                    /// <para>The name of the rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20% discount on pay-as-you-go</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The rule ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2000010******</para>
                    /// </summary>
                    [NameInMap("RuleDescId")]
                    [Validation(Required=false)]
                    public float? RuleDescId { get; set; }

                }

            }

            /// <summary>
            /// <para>The pricing information.</para>
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public DescribeConfigurationPriceResponseBodyDataOrder Order { get; set; }
            public class DescribeConfigurationPriceResponseBodyDataOrder : TeaModel {
                /// <summary>
                /// <para>The discount amount of the order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0018518</para>
                /// </summary>
                [NameInMap("DiscountAmount")]
                [Validation(Required=false)]
                public float? DiscountAmount { get; set; }

                /// <summary>
                /// <para>The original price of the order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0092592</para>
                /// </summary>
                [NameInMap("OriginalAmount")]
                [Validation(Required=false)]
                public float? OriginalAmount { get; set; }

                /// <summary>
                /// <para>The promotion ID.</para>
                /// </summary>
                [NameInMap("RuleIds")]
                [Validation(Required=false)]
                public List<string> RuleIds { get; set; }

                /// <summary>
                /// <para>The final price of the order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0074074</para>
                /// </summary>
                [NameInMap("TradeAmount")]
                [Validation(Required=false)]
                public float? TradeAmount { get; set; }

            }

            /// <summary>
            /// <para>The price per request.</para>
            /// </summary>
            [NameInMap("RequestPrice")]
            [Validation(Required=false)]
            public DescribeConfigurationPriceResponseBodyDataRequestPrice RequestPrice { get; set; }
            public class DescribeConfigurationPriceResponseBodyDataRequestPrice : TeaModel {
                /// <summary>
                /// <para>The pricing information.</para>
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public DescribeConfigurationPriceResponseBodyDataRequestPriceOrder Order { get; set; }
                public class DescribeConfigurationPriceResponseBodyDataRequestPriceOrder : TeaModel {
                    /// <summary>
                    /// <para>The discount amount of the order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0009259</para>
                    /// </summary>
                    [NameInMap("DiscountAmount")]
                    [Validation(Required=false)]
                    public float? DiscountAmount { get; set; }

                    /// <summary>
                    /// <para>The original price of the order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0046296</para>
                    /// </summary>
                    [NameInMap("OriginalAmount")]
                    [Validation(Required=false)]
                    public float? OriginalAmount { get; set; }

                    /// <summary>
                    /// <para>The rule ID.</para>
                    /// </summary>
                    [NameInMap("RuleIds")]
                    [Validation(Required=false)]
                    public List<string> RuleIds { get; set; }

                    /// <summary>
                    /// <para>The actual transaction price of the order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0037037</para>
                    /// </summary>
                    [NameInMap("TradeAmount")]
                    [Validation(Required=false)]
                    public float? TradeAmount { get; set; }

                }

                /// <summary>
                /// <para>The promotion rules.</para>
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<DescribeConfigurationPriceResponseBodyDataRequestPriceRules> Rules { get; set; }
                public class DescribeConfigurationPriceResponseBodyDataRequestPriceRules : TeaModel {
                    /// <summary>
                    /// <para>The name of the rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20% discount on pay-as-you-go</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The policy ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2000010******</para>
                    /// </summary>
                    [NameInMap("RuleDescId")]
                    [Validation(Required=false)]
                    public long? RuleDescId { get; set; }

                }

            }

            /// <summary>
            /// <para>The promotion rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeConfigurationPriceResponseBodyDataRules> Rules { get; set; }
            public class DescribeConfigurationPriceResponseBodyDataRules : TeaModel {
                /// <summary>
                /// <para>The name of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20% discount on pay-as-you-go</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000010******</para>
                /// </summary>
                [NameInMap("RuleDescId")]
                [Validation(Required=false)]
                public long? RuleDescId { get; set; }

            }

            /// <summary>
            /// <para>The price of traffic.</para>
            /// </summary>
            [NameInMap("TrafficPrice")]
            [Validation(Required=false)]
            public DescribeConfigurationPriceResponseBodyDataTrafficPrice TrafficPrice { get; set; }
            public class DescribeConfigurationPriceResponseBodyDataTrafficPrice : TeaModel {
                /// <summary>
                /// <para>The pricing information.</para>
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public DescribeConfigurationPriceResponseBodyDataTrafficPriceOrder Order { get; set; }
                public class DescribeConfigurationPriceResponseBodyDataTrafficPriceOrder : TeaModel {
                    /// <summary>
                    /// <para>The discount amount of the order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0009259</para>
                    /// </summary>
                    [NameInMap("DiscountAmount")]
                    [Validation(Required=false)]
                    public float? DiscountAmount { get; set; }

                    /// <summary>
                    /// <para>The original price of the order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0046296</para>
                    /// </summary>
                    [NameInMap("OriginalAmount")]
                    [Validation(Required=false)]
                    public float? OriginalAmount { get; set; }

                    /// <summary>
                    /// <para>The promotion ID.</para>
                    /// </summary>
                    [NameInMap("RuleIds")]
                    [Validation(Required=false)]
                    public List<string> RuleIds { get; set; }

                    /// <summary>
                    /// <para>The actual transaction price of the order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0037037</para>
                    /// </summary>
                    [NameInMap("TradeAmount")]
                    [Validation(Required=false)]
                    public float? TradeAmount { get; set; }

                }

                /// <summary>
                /// <para>The promotion rules.</para>
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<DescribeConfigurationPriceResponseBodyDataTrafficPriceRules> Rules { get; set; }
                public class DescribeConfigurationPriceResponseBodyDataTrafficPriceRules : TeaModel {
                    /// <summary>
                    /// <para>The name of the rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20% discount on pay-as-you-go</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The rule ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2000010******</para>
                    /// </summary>
                    [NameInMap("RuleDescId")]
                    [Validation(Required=false)]
                    public float? RuleDescId { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is not returned if the request is successful.</para>
        /// </description></item>
        /// <item><description><para>This parameter is returned if the request fails. For more information, see the <b>Error codes</b> section of this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <list type="bullet">
        /// <item><description><para>If the request is successful, <b>success</b> is returned.</para>
        /// </description></item>
        /// <item><description><para>If the request fails, an error code is returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADCEC067-86AD-19E2-BD43-E83F3841****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the price of the configuration was obtained.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The price was obtained.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The price failed to be obtained.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1a0dcc771722848598056771******</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
