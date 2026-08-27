// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class GetBillingTrendResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetBillingTrendResponseBodyData Data { get; set; }
        public class GetBillingTrendResponseBodyData : TeaModel {
            [NameInMap("costTotals")]
            [Validation(Required=false)]
            public GetBillingTrendResponseBodyDataCostTotals CostTotals { get; set; }
            public class GetBillingTrendResponseBodyDataCostTotals : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>94.34</para>
                /// </summary>
                [NameInMap("pretaxAmount")]
                [Validation(Required=false)]
                public string PretaxAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5.66</para>
                /// </summary>
                [NameInMap("taxAmount")]
                [Validation(Required=false)]
                public string TaxAmount { get; set; }

            }

            [NameInMap("groupByTotal")]
            [Validation(Required=false)]
            public List<GetBillingTrendResponseBodyDataGroupByTotal> GroupByTotal { get; set; }
            public class GetBillingTrendResponseBodyDataGroupByTotal : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>qwen-plus</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>qwen-plus</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>56.60</para>
                /// </summary>
                [NameInMap("pretaxAmount")]
                [Validation(Required=false)]
                public string PretaxAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3.40</para>
                /// </summary>
                [NameInMap("taxAmount")]
                [Validation(Required=false)]
                public string TaxAmount { get; set; }

            }

            [NameInMap("resultByTime")]
            [Validation(Required=false)]
            public List<GetBillingTrendResponseBodyDataResultByTime> ResultByTime { get; set; }
            public class GetBillingTrendResponseBodyDataResultByTime : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>20260801</para>
                /// </summary>
                [NameInMap("period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                [NameInMap("periodDetails")]
                [Validation(Required=false)]
                public List<GetBillingTrendResponseBodyDataResultByTimePeriodDetails> PeriodDetails { get; set; }
                public class GetBillingTrendResponseBodyDataResultByTimePeriodDetails : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>qwen-plus</para>
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>qwen-plus</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.6667</para>
                    /// </summary>
                    [NameInMap("percentage")]
                    [Validation(Required=false)]
                    public string Percentage { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>18.87</para>
                    /// </summary>
                    [NameInMap("pretaxAmount")]
                    [Validation(Required=false)]
                    public string PretaxAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1.13</para>
                    /// </summary>
                    [NameInMap("taxAmount")]
                    [Validation(Required=false)]
                    public string TaxAmount { get; set; }

                }

                [NameInMap("total")]
                [Validation(Required=false)]
                public GetBillingTrendResponseBodyDataResultByTimeTotal Total { get; set; }
                public class GetBillingTrendResponseBodyDataResultByTimeTotal : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CNY</para>
                    /// </summary>
                    [NameInMap("currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>28.30</para>
                    /// </summary>
                    [NameInMap("pretaxAmount")]
                    [Validation(Required=false)]
                    public string PretaxAmount { get; set; }

                    /// <summary>
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
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>099A671E-FA21-5A36-8A73-918572DDEF53</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
