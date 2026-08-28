// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class GetBillingTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The request result code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetBillingTrendResponseBodyData Data { get; set; }
        public class GetBillingTrendResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The total cost for the entire query time range, including the top N groups and &quot;Others&quot;.</para>
            /// </summary>
            [NameInMap("costTotals")]
            [Validation(Required=false)]
            public GetBillingTrendResponseBodyDataCostTotals CostTotals { get; set; }
            public class GetBillingTrendResponseBodyDataCostTotals : TeaModel {
                /// <summary>
                /// <para>The total amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                /// <summary>
                /// <para>The currency of the amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <para>The pretax amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>94.34</para>
                /// </summary>
                [NameInMap("pretaxAmount")]
                [Validation(Required=false)]
                public string PretaxAmount { get; set; }

                /// <summary>
                /// <para>The tax amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.66</para>
                /// </summary>
                [NameInMap("taxAmount")]
                [Validation(Required=false)]
                public string TaxAmount { get; set; }

            }

            /// <summary>
            /// <para>The total cost of the top N groups and the optional &quot;Others&quot; group within the period.</para>
            /// </summary>
            [NameInMap("groupByTotal")]
            [Validation(Required=false)]
            public List<GetBillingTrendResponseBodyDataGroupByTotal> GroupByTotal { get; set; }
            public class GetBillingTrendResponseBodyDataGroupByTotal : TeaModel {
                /// <summary>
                /// <para>The total amount of the current group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                /// <summary>
                /// <para>The grouping dimension value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen-plus</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The display name of the group. This value is affected by the locale parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen-plus</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The pretax amount of the current group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>56.60</para>
                /// </summary>
                [NameInMap("pretaxAmount")]
                [Validation(Required=false)]
                public string PretaxAmount { get; set; }

                /// <summary>
                /// <para>The tax amount of the current group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.40</para>
                /// </summary>
                [NameInMap("taxAmount")]
                [Validation(Required=false)]
                public string TaxAmount { get; set; }

            }

            /// <summary>
            /// <para>The cost trend list sorted by time in ascending order.</para>
            /// </summary>
            [NameInMap("resultByTime")]
            [Validation(Required=false)]
            public List<GetBillingTrendResponseBodyDataResultByTime> ResultByTime { get; set; }
            public class GetBillingTrendResponseBodyDataResultByTime : TeaModel {
                /// <summary>
                /// <para>The statistical period. DAY returns yyyyMMdd. MONTH returns yyyyMM.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20260801</para>
                /// </summary>
                [NameInMap("period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                /// <summary>
                /// <para>The cost groups that actually exist in the current period.</para>
                /// </summary>
                [NameInMap("periodDetails")]
                [Validation(Required=false)]
                public List<GetBillingTrendResponseBodyDataResultByTimePeriodDetails> PeriodDetails { get; set; }
                public class GetBillingTrendResponseBodyDataResultByTimePeriodDetails : TeaModel {
                    /// <summary>
                    /// <para>The amount of the group within the current period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

                    /// <summary>
                    /// <para>The grouping dimension value. Data beyond the top N uses DIMENSION_GROUP_OTHERS_VALUE.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>qwen-plus</para>
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The display name of the group. This value is affected by the locale parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>qwen-plus</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The ratio of the current group amount to the total amount of the current period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.6667</para>
                    /// </summary>
                    [NameInMap("percentage")]
                    [Validation(Required=false)]
                    public string Percentage { get; set; }

                    /// <summary>
                    /// <para>The pretax amount of the group within the current period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>18.87</para>
                    /// </summary>
                    [NameInMap("pretaxAmount")]
                    [Validation(Required=false)]
                    public string PretaxAmount { get; set; }

                    /// <summary>
                    /// <para>The tax amount of the group within the current period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.13</para>
                    /// </summary>
                    [NameInMap("taxAmount")]
                    [Validation(Required=false)]
                    public string TaxAmount { get; set; }

                }

                /// <summary>
                /// <para>The total cost for the current period.</para>
                /// </summary>
                [NameInMap("total")]
                [Validation(Required=false)]
                public GetBillingTrendResponseBodyDataResultByTimeTotal Total { get; set; }
                public class GetBillingTrendResponseBodyDataResultByTimeTotal : TeaModel {
                    /// <summary>
                    /// <para>The total amount for the current period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

                    /// <summary>
                    /// <para>The currency of the amount for the current period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CNY</para>
                    /// </summary>
                    [NameInMap("currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// <para>The pretax amount for the current period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>28.30</para>
                    /// </summary>
                    [NameInMap("pretaxAmount")]
                    [Validation(Required=false)]
                    public string PretaxAmount { get; set; }

                    /// <summary>
                    /// <para>The tax amount for the current period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.70</para>
                    /// </summary>
                    [NameInMap("taxAmount")]
                    [Validation(Required=false)]
                    public string TaxAmount { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The request result description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>099A671E-FA21-5A36-8A73-918572DDEF53</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
