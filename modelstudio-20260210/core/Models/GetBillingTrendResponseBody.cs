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
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetBillingTrendResponseBodyData Data { get; set; }
        public class GetBillingTrendResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The total costs within the entire query time range, including the top N items and Other.</para>
            /// </summary>
            [NameInMap("costTotals")]
            [Validation(Required=false)]
            public GetBillingTrendResponseBodyDataCostTotals CostTotals { get; set; }
            public class GetBillingTrendResponseBodyDataCostTotals : TeaModel {
                /// <summary>
                /// <para>The total cost amount.</para>
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
            /// <para>The total costs of the top N groups and the optional Other group within the period.</para>
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
                /// <para>The dimension value of the group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen-plus</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The display name of the group, which is affected by the locale input parameter.</para>
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
            /// <para>The historical period data, which is returned when the includeHistoryPeriod input parameter is set to true.</para>
            /// </summary>
            [NameInMap("historyPeriod")]
            [Validation(Required=false)]
            public GetBillingTrendResponseBodyDataHistoryPeriod HistoryPeriod { get; set; }
            public class GetBillingTrendResponseBodyDataHistoryPeriod : TeaModel {
                /// <summary>
                /// <para>The total costs within the historical range, including the top N items and Other.</para>
                /// </summary>
                [NameInMap("costTotals")]
                [Validation(Required=false)]
                public GetBillingTrendResponseBodyDataHistoryPeriodCostTotals CostTotals { get; set; }
                public class GetBillingTrendResponseBodyDataHistoryPeriodCostTotals : TeaModel {
                    /// <summary>
                    /// <para>The total cost amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
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
                    /// <para>800</para>
                    /// </summary>
                    [NameInMap("pretaxAmount")]
                    [Validation(Required=false)]
                    public string PretaxAmount { get; set; }

                    /// <summary>
                    /// <para>The tax amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("taxAmount")]
                    [Validation(Required=false)]
                    public string TaxAmount { get; set; }

                }

                /// <summary>
                /// <para>The total costs of the top N groups and the optional Other group within the historical period.</para>
                /// </summary>
                [NameInMap("groupByTotal")]
                [Validation(Required=false)]
                public List<GetBillingTrendResponseBodyDataHistoryPeriodGroupByTotal> GroupByTotal { get; set; }
                public class GetBillingTrendResponseBodyDataHistoryPeriodGroupByTotal : TeaModel {
                    /// <summary>
                    /// <para>The total amount of the current group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>246</para>
                    /// </summary>
                    [NameInMap("amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

                    /// <summary>
                    /// <para>The dimension value of the group. If the value is null, DIMENSION_FILTER_NULL_VALUE is returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>qwen-plus</para>
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The display name of the group, which is affected by the locale parameter. If the value is null, a hyphen (-) is displayed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>qwen-plus</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The total pretax amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("pretaxAmount")]
                    [Validation(Required=false)]
                    public string PretaxAmount { get; set; }

                    /// <summary>
                    /// <para>The total tax amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>146</para>
                    /// </summary>
                    [NameInMap("taxAmount")]
                    [Validation(Required=false)]
                    public string TaxAmount { get; set; }

                }

                /// <summary>
                /// <para>The list of cost trends sorted in ascending order by time.</para>
                /// </summary>
                [NameInMap("resultByTime")]
                [Validation(Required=false)]
                public List<GetBillingTrendResponseBodyDataHistoryPeriodResultByTime> ResultByTime { get; set; }
                public class GetBillingTrendResponseBodyDataHistoryPeriodResultByTime : TeaModel {
                    /// <summary>
                    /// <para>The statistical period.</para>
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
                    public List<GetBillingTrendResponseBodyDataHistoryPeriodResultByTimePeriodDetails> PeriodDetails { get; set; }
                    public class GetBillingTrendResponseBodyDataHistoryPeriodResultByTimePeriodDetails : TeaModel {
                        /// <summary>
                        /// <para>The amount of the current group.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>526</para>
                        /// </summary>
                        [NameInMap("amount")]
                        [Validation(Required=false)]
                        public string Amount { get; set; }

                        /// <summary>
                        /// <para>The dimension value of the group. If the value is null, DIMENSION_FILTER_NULL_VALUE is returned.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>qwen-plus</para>
                        /// </summary>
                        [NameInMap("key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The display name of the group, which is affected by the locale parameter. If the value is null, a hyphen (-) is displayed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>qwen-plus</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The percentage of the group amount.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.5</para>
                        /// </summary>
                        [NameInMap("percentage")]
                        [Validation(Required=false)]
                        public string Percentage { get; set; }

                        /// <summary>
                        /// <para>The total pretax amount.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("pretaxAmount")]
                        [Validation(Required=false)]
                        public string PretaxAmount { get; set; }

                        /// <summary>
                        /// <para>The total tax amount.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>426</para>
                        /// </summary>
                        [NameInMap("taxAmount")]
                        [Validation(Required=false)]
                        public string TaxAmount { get; set; }

                    }

                    /// <summary>
                    /// <para>The total costs of the current period.</para>
                    /// </summary>
                    [NameInMap("total")]
                    [Validation(Required=false)]
                    public GetBillingTrendResponseBodyDataHistoryPeriodResultByTimeTotal Total { get; set; }
                    public class GetBillingTrendResponseBodyDataHistoryPeriodResultByTimeTotal : TeaModel {
                        /// <summary>
                        /// <para>The total cost amount of the current period.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>600</para>
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
                        /// <para>The total pretax amount.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("pretaxAmount")]
                        [Validation(Required=false)]
                        public string PretaxAmount { get; set; }

                        /// <summary>
                        /// <para>The total tax amount.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>500</para>
                        /// </summary>
                        [NameInMap("taxAmount")]
                        [Validation(Required=false)]
                        public string TaxAmount { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The list of cost trends sorted in ascending order by time.</para>
            /// </summary>
            [NameInMap("resultByTime")]
            [Validation(Required=false)]
            public List<GetBillingTrendResponseBodyDataResultByTime> ResultByTime { get; set; }
            public class GetBillingTrendResponseBodyDataResultByTime : TeaModel {
                /// <summary>
                /// <para>The statistical period. DAY returns yyyyMMdd, and MONTH returns yyyyMM.</para>
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
                    /// <para>The amount of the group in the current period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

                    /// <summary>
                    /// <para>The dimension value of the group. For data other than the top N items, DIMENSION_GROUP_OTHERS_VALUE is used.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>qwen-plus</para>
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The display name of the group, which is affected by the locale input parameter.</para>
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
                    /// <para>The pretax amount of the group in the current period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>18.87</para>
                    /// </summary>
                    [NameInMap("pretaxAmount")]
                    [Validation(Required=false)]
                    public string PretaxAmount { get; set; }

                    /// <summary>
                    /// <para>The tax amount of the group in the current period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.13</para>
                    /// </summary>
                    [NameInMap("taxAmount")]
                    [Validation(Required=false)]
                    public string TaxAmount { get; set; }

                }

                /// <summary>
                /// <para>The total costs of the current period.</para>
                /// </summary>
                [NameInMap("total")]
                [Validation(Required=false)]
                public GetBillingTrendResponseBodyDataResultByTimeTotal Total { get; set; }
                public class GetBillingTrendResponseBodyDataResultByTimeTotal : TeaModel {
                    /// <summary>
                    /// <para>The total cost amount of the current period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

                    /// <summary>
                    /// <para>The currency of the amount in the current period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CNY</para>
                    /// </summary>
                    [NameInMap("currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// <para>The pretax amount of the current period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>28.30</para>
                    /// </summary>
                    [NameInMap("pretaxAmount")]
                    [Validation(Required=false)]
                    public string PretaxAmount { get; set; }

                    /// <summary>
                    /// <para>The tax amount of the current period.</para>
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
        /// <para>The description of the request result.</para>
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
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
