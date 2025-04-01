// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeConfigurationPriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The request was successful.</description></item>
        /// <item><description><b>3xx</b>: The request was redirected.</description></item>
        /// <item><description><b>4xx</b>: The request failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The price.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeConfigurationPriceResponseBodyData Data { get; set; }
        public class DescribeConfigurationPriceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The remaining capacity of the resource plan.</para>
            /// </summary>
            [NameInMap("BagUsage")]
            [Validation(Required=false)]
            public DescribeConfigurationPriceResponseBodyDataBagUsage BagUsage { get; set; }
            public class DescribeConfigurationPriceResponseBodyDataBagUsage : TeaModel {
                /// <summary>
                /// <para>The available CPU capacity. Unit: cores \*.</para>
                /// 
                /// <b>Example:</b>
                /// <para>497570.450009</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                [NameInMap("Cu")]
                [Validation(Required=false)]
                public float? Cu { get; set; }

                /// <summary>
                /// <para>The available memory size. Unit: GiB ×.</para>
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
                /// <para>The information about pricing.</para>
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public DescribeConfigurationPriceResponseBodyDataCpuMemPriceOrder Order { get; set; }
                public class DescribeConfigurationPriceResponseBodyDataCpuMemPriceOrder : TeaModel {
                    /// <summary>
                    /// <para>The discount amount.</para>
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
                    /// <para>The ID of the discount rule.</para>
                    /// </summary>
                    [NameInMap("RuleIds")]
                    [Validation(Required=false)]
                    public List<string> RuleIds { get; set; }

                    /// <summary>
                    /// <para>The final price of the order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0037037</para>
                    /// </summary>
                    [NameInMap("TradeAmount")]
                    [Validation(Required=false)]
                    public float? TradeAmount { get; set; }

                }

                /// <summary>
                /// <para>The discount rules.</para>
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<DescribeConfigurationPriceResponseBodyDataCpuMemPriceRules> Rules { get; set; }
                public class DescribeConfigurationPriceResponseBodyDataCpuMemPriceRules : TeaModel {
                    /// <summary>
                    /// <para>The name of discount rule.</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The ID of the discount rule.</para>
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
            /// <para>The information about pricing.</para>
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public DescribeConfigurationPriceResponseBodyDataOrder Order { get; set; }
            public class DescribeConfigurationPriceResponseBodyDataOrder : TeaModel {
                /// <summary>
                /// <para>The discount amount.</para>
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
                /// <para>The ID of the promotion rule.</para>
                /// </summary>
                [NameInMap("RuleIds")]
                [Validation(Required=false)]
                public List<string> RuleIds { get; set; }

                /// <summary>
                /// <para>The transaction price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0074074</para>
                /// </summary>
                [NameInMap("TradeAmount")]
                [Validation(Required=false)]
                public float? TradeAmount { get; set; }

            }

            /// <summary>
            /// <para>The price based on the number of requests.</para>
            /// </summary>
            [NameInMap("RequestPrice")]
            [Validation(Required=false)]
            public DescribeConfigurationPriceResponseBodyDataRequestPrice RequestPrice { get; set; }
            public class DescribeConfigurationPriceResponseBodyDataRequestPrice : TeaModel {
                /// <summary>
                /// <para>The information about pricing.</para>
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public DescribeConfigurationPriceResponseBodyDataRequestPriceOrder Order { get; set; }
                public class DescribeConfigurationPriceResponseBodyDataRequestPriceOrder : TeaModel {
                    /// <summary>
                    /// <para>The discount amount.</para>
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
                    /// <para>The ID of the discount rule.</para>
                    /// </summary>
                    [NameInMap("RuleIds")]
                    [Validation(Required=false)]
                    public List<string> RuleIds { get; set; }

                    /// <summary>
                    /// <para>The actual price of the order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0037037</para>
                    /// </summary>
                    [NameInMap("TradeAmount")]
                    [Validation(Required=false)]
                    public float? TradeAmount { get; set; }

                }

                /// <summary>
                /// <para>The discount rule.</para>
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<DescribeConfigurationPriceResponseBodyDataRequestPriceRules> Rules { get; set; }
                public class DescribeConfigurationPriceResponseBodyDataRequestPriceRules : TeaModel {
                    /// <summary>
                    /// <para>The name of the discount rule.</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The ID of the discount policy.</para>
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
                /// <para>The name of the promotion rule.</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the promotion rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000010******</para>
                /// </summary>
                [NameInMap("RuleDescId")]
                [Validation(Required=false)]
                public long? RuleDescId { get; set; }

            }

            /// <summary>
            /// <para>The traffic price.</para>
            /// </summary>
            [NameInMap("TrafficPrice")]
            [Validation(Required=false)]
            public DescribeConfigurationPriceResponseBodyDataTrafficPrice TrafficPrice { get; set; }
            public class DescribeConfigurationPriceResponseBodyDataTrafficPrice : TeaModel {
                /// <summary>
                /// <para>The information about pricing.</para>
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public DescribeConfigurationPriceResponseBodyDataTrafficPriceOrder Order { get; set; }
                public class DescribeConfigurationPriceResponseBodyDataTrafficPriceOrder : TeaModel {
                    /// <summary>
                    /// <para>The discount amount.</para>
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
                    /// <para>The ID of the discount rule.</para>
                    /// </summary>
                    [NameInMap("RuleIds")]
                    [Validation(Required=false)]
                    public List<string> RuleIds { get; set; }

                    /// <summary>
                    /// <para>The final price of the order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0037037</para>
                    /// </summary>
                    [NameInMap("TradeAmount")]
                    [Validation(Required=false)]
                    public float? TradeAmount { get; set; }

                }

                /// <summary>
                /// <para>The discount rule.</para>
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<DescribeConfigurationPriceResponseBodyDataTrafficPriceRules> Rules { get; set; }
                public class DescribeConfigurationPriceResponseBodyDataTrafficPriceRules : TeaModel {
                    /// <summary>
                    /// <para>The name of the discount rule.</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The ID of the discount rule.</para>
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
        /// <para>The error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, <b>ErrorCode</b> is not returned.</description></item>
        /// <item><description>If the request failed, <b>ErrorCode</b> is returned. For more information, see <b>Error codes</b> in this topic.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The message returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, <b>success</b> is returned.</description></item>
        /// <item><description>If the request failed, an error code is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADCEC067-86AD-19E2-BD43-E83F3841****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the configuration price was obtained.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The price was obtained.</description></item>
        /// <item><description><b>false</b>: The price failed to be queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The ID of the trace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1a0dcc771722848598056771******</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
