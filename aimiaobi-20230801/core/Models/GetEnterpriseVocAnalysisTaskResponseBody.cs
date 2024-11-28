// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetEnterpriseVocAnalysisTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NoData</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetEnterpriseVocAnalysisTaskResponseBodyData Data { get; set; }
        public class GetEnterpriseVocAnalysisTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>error</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("StatisticsOverview")]
            [Validation(Required=false)]
            public GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverview StatisticsOverview { get; set; }
            public class GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverview : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("FilterDimensionStatistics")]
                [Validation(Required=false)]
                public GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverviewFilterDimensionStatistics FilterDimensionStatistics { get; set; }
                public class GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverviewFilterDimensionStatistics : TeaModel {
                    [NameInMap("TagValueCountStatistic")]
                    [Validation(Required=false)]
                    public List<GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverviewFilterDimensionStatisticsTagValueCountStatistic> TagValueCountStatistic { get; set; }
                    public class GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverviewFilterDimensionStatisticsTagValueCountStatistic : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxx</para>
                        /// </summary>
                        [NameInMap("TagName")]
                        [Validation(Required=false)]
                        public string TagName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>multiTagValues</para>
                        /// </summary>
                        [NameInMap("TagTaskType")]
                        [Validation(Required=false)]
                        public string TagTaskType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("ValueCount")]
                        [Validation(Required=false)]
                        public int? ValueCount { get; set; }

                    }

                }

                [NameInMap("TagDimensionStatistics")]
                [Validation(Required=false)]
                public GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverviewTagDimensionStatistics TagDimensionStatistics { get; set; }
                public class GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverviewTagDimensionStatistics : TeaModel {
                    [NameInMap("TagValueCountStatistic")]
                    [Validation(Required=false)]
                    public List<GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverviewTagDimensionStatisticsTagValueCountStatistic> TagValueCountStatistic { get; set; }
                    public class GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverviewTagDimensionStatisticsTagValueCountStatistic : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxx</para>
                        /// </summary>
                        [NameInMap("TagName")]
                        [Validation(Required=false)]
                        public string TagName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>multiTagValues</para>
                        /// </summary>
                        [NameInMap("TagTaskType")]
                        [Validation(Required=false)]
                        public string TagTaskType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("ValueCount")]
                        [Validation(Required=false)]
                        public int? ValueCount { get; set; }

                    }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUCCESSED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Usage")]
            [Validation(Required=false)]
            public GetEnterpriseVocAnalysisTaskResponseBodyDataUsage Usage { get; set; }
            public class GetEnterpriseVocAnalysisTaskResponseBodyDataUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
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
