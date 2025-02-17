// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GetServiceInstanceSubscriptionEstimateCostResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>464C8CB6-A548-5206-B83C-D32A8E43EC21</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List of resource price information.</para>
        /// </summary>
        [NameInMap("ResourcePrices")]
        [Validation(Required=false)]
        public List<GetServiceInstanceSubscriptionEstimateCostResponseBodyResourcePrices> ResourcePrices { get; set; }
        public class GetServiceInstanceSubscriptionEstimateCostResponseBodyResourcePrices : TeaModel {
            /// <summary>
            /// <para>Currency. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CNY: Chinese Yuan.</description></item>
            /// <item><description>USD: US Dollar.</description></item>
            /// <item><description>JPY: Japanese Yen.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The price details of the pricing module.</para>
            /// </summary>
            [NameInMap("DetailInfos")]
            [Validation(Required=false)]
            public List<GetServiceInstanceSubscriptionEstimateCostResponseBodyResourcePricesDetailInfos> DetailInfos { get; set; }
            public class GetServiceInstanceSubscriptionEstimateCostResponseBodyResourcePricesDetailInfos : TeaModel {
                /// <summary>
                /// <para>Discount amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("DiscountAmount")]
                [Validation(Required=false)]
                public float? DiscountAmount { get; set; }

                /// <summary>
                /// <para>Original price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>900</para>
                /// </summary>
                [NameInMap("OriginalAmount")]
                [Validation(Required=false)]
                public float? OriginalAmount { get; set; }

                /// <summary>
                /// <para>Pricing module identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance</para>
                /// </summary>
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public string Resource { get; set; }

                /// <summary>
                /// <para>Discounted price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("TradeAmount")]
                [Validation(Required=false)]
                public float? TradeAmount { get; set; }

            }

            /// <summary>
            /// <para>Discount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DiscountAmount")]
            [Validation(Required=false)]
            public float? DiscountAmount { get; set; }

            /// <summary>
            /// <para>Original price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>900</para>
            /// </summary>
            [NameInMap("OriginalAmount")]
            [Validation(Required=false)]
            public float? OriginalAmount { get; set; }

            /// <summary>
            /// <para>Renewal duration. The unit is specified by PeriodUnit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// <para>The time unit for the renewal duration, which is the unit of the Period parameter. Valid values: Month, Year. Default value: Month.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>Resource ARN (Aliyun Resource Name).</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ecs:cn-hongkong:1488317743351199:instance/i-j6c6f3lbky38o8rpeqw2</para>
            /// </summary>
            [NameInMap("ResourceArn")]
            [Validation(Required=false)]
            public string ResourceArn { get; set; }

            /// <summary>
            /// <para>Promotion details.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<GetServiceInstanceSubscriptionEstimateCostResponseBodyResourcePricesRules> Rules { get; set; }
            public class GetServiceInstanceSubscriptionEstimateCostResponseBodyResourcePricesRules : TeaModel {
                /// <summary>
                /// <para>Promotion description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Promotion name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Promotion ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1021199213</para>
                /// </summary>
                [NameInMap("RuleDescId")]
                [Validation(Required=false)]
                public long? RuleDescId { get; set; }

            }

            /// <summary>
            /// <para>Discounted price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("TradeAmount")]
            [Validation(Required=false)]
            public float? TradeAmount { get; set; }

        }

    }

}
