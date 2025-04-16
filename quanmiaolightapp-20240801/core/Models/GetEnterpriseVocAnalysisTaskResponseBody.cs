// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class GetEnterpriseVocAnalysisTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NoPermission</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetEnterpriseVocAnalysisTaskResponseBodyData Data { get; set; }
        public class GetEnterpriseVocAnalysisTaskResponseBodyData : TeaModel {
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qwen-max</para>
            /// </summary>
            [NameInMap("modelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            [NameInMap("modelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            [NameInMap("statisticsOverview")]
            [Validation(Required=false)]
            public GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverview StatisticsOverview { get; set; }
            public class GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverview : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>17</para>
                /// </summary>
                [NameInMap("count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("filterDimensionStatistics")]
                [Validation(Required=false)]
                public GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverviewFilterDimensionStatistics FilterDimensionStatistics { get; set; }
                public class GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverviewFilterDimensionStatistics : TeaModel {
                    [NameInMap("tagValueCountStatistic")]
                    [Validation(Required=false)]
                    public List<GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverviewFilterDimensionStatisticsTagValueCountStatistic> TagValueCountStatistic { get; set; }
                    public class GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverviewFilterDimensionStatisticsTagValueCountStatistic : TeaModel {
                        [NameInMap("tagName")]
                        [Validation(Required=false)]
                        public string TagName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("valueCount")]
                        [Validation(Required=false)]
                        public int? ValueCount { get; set; }

                    }

                }

                [NameInMap("tagDimensionStatistics")]
                [Validation(Required=false)]
                public GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverviewTagDimensionStatistics TagDimensionStatistics { get; set; }
                public class GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverviewTagDimensionStatistics : TeaModel {
                    [NameInMap("tagValueCountStatistic")]
                    [Validation(Required=false)]
                    public List<GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverviewTagDimensionStatisticsTagValueCountStatistic> TagValueCountStatistic { get; set; }
                    public class GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverviewTagDimensionStatisticsTagValueCountStatistic : TeaModel {
                        [NameInMap("tagName")]
                        [Validation(Required=false)]
                        public string TagName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("valueCount")]
                        [Validation(Required=false)]
                        public int? ValueCount { get; set; }

                    }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PENDING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("usage")]
            [Validation(Required=false)]
            public GetEnterpriseVocAnalysisTaskResponseBodyDataUsage Usage { get; set; }
            public class GetEnterpriseVocAnalysisTaskResponseBodyDataUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("inputTokens")]
                [Validation(Required=false)]
                public int? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("outputTokens")]
                [Validation(Required=false)]
                public int? OutputTokens { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>117F5ABE-CF02-5502-9A3F-E56BC9081A64</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
