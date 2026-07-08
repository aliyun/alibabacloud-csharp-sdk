// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetEnterpriseVocAnalysisTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoData</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The result of the enterprise VOC analysis.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetEnterpriseVocAnalysisTaskResponseBodyData Data { get; set; }
        public class GetEnterpriseVocAnalysisTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>error</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The statistics overview.</para>
            /// </summary>
            [NameInMap("StatisticsOverview")]
            [Validation(Required=false)]
            public GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverview StatisticsOverview { get; set; }
            public class GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverview : TeaModel {
                /// <summary>
                /// <para>The total number of analyzed data entries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The statistics of filter tags.</para>
                /// </summary>
                [NameInMap("FilterDimensionStatistics")]
                [Validation(Required=false)]
                public GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverviewFilterDimensionStatistics FilterDimensionStatistics { get; set; }
                public class GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverviewFilterDimensionStatistics : TeaModel {
                    /// <summary>
                    /// <para>The statistics of tag value counts.</para>
                    /// </summary>
                    [NameInMap("TagValueCountStatistic")]
                    [Validation(Required=false)]
                    public List<GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverviewFilterDimensionStatisticsTagValueCountStatistic> TagValueCountStatistic { get; set; }
                    public class GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverviewFilterDimensionStatisticsTagValueCountStatistic : TeaModel {
                        /// <summary>
                        /// <para>The tag name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xxx</para>
                        /// </summary>
                        [NameInMap("TagName")]
                        [Validation(Required=false)]
                        public string TagName { get; set; }

                        /// <summary>
                        /// <para>The type of the tag mining task. Valid values: \<c>singleTagValue\\</c> (single tag), \<c>multiTagValues\\</c> (multiple tags), and \<c>summaryAndOverview\\</c> (summary and overview).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>multiTagValues</para>
                        /// </summary>
                        [NameInMap("TagTaskType")]
                        [Validation(Required=false)]
                        public string TagTaskType { get; set; }

                        /// <summary>
                        /// <para>The number of tag values.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("ValueCount")]
                        [Validation(Required=false)]
                        public int? ValueCount { get; set; }

                    }

                }

                /// <summary>
                /// <para>The statistics of content tags.</para>
                /// </summary>
                [NameInMap("TagDimensionStatistics")]
                [Validation(Required=false)]
                public GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverviewTagDimensionStatistics TagDimensionStatistics { get; set; }
                public class GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverviewTagDimensionStatistics : TeaModel {
                    /// <summary>
                    /// <para>The statistics of tag value counts.</para>
                    /// </summary>
                    [NameInMap("TagValueCountStatistic")]
                    [Validation(Required=false)]
                    public List<GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverviewTagDimensionStatisticsTagValueCountStatistic> TagValueCountStatistic { get; set; }
                    public class GetEnterpriseVocAnalysisTaskResponseBodyDataStatisticsOverviewTagDimensionStatisticsTagValueCountStatistic : TeaModel {
                        /// <summary>
                        /// <para>The tag name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xxx</para>
                        /// </summary>
                        [NameInMap("TagName")]
                        [Validation(Required=false)]
                        public string TagName { get; set; }

                        /// <summary>
                        /// <para>The type of the tag mining task. Valid values: \<c>singleTagValue\\</c> (single tag), \<c>multiTagValues\\</c> (multiple tags), and \<c>summaryAndOverview\\</c> (summary and overview).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>multiTagValues</para>
                        /// </summary>
                        [NameInMap("TagTaskType")]
                        [Validation(Required=false)]
                        public string TagTaskType { get; set; }

                        /// <summary>
                        /// <para>The number of tag values.</para>
                        /// 
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
            /// <para>The status of the task. Valid values: \<c>PENDING\\</c> (pending), \<c>RUNNING\\</c> (running), \<c>SUCCESSED\\</c> (successful), \<c>FAILED\\</c> (failed), and \<c>CANCELED\\</c> (canceled).</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESSED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The usage statistics.</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public GetEnterpriseVocAnalysisTaskResponseBodyDataUsage Usage { get; set; }
            public class GetEnterpriseVocAnalysisTaskResponseBodyDataUsage : TeaModel {
                /// <summary>
                /// <para>The number of input tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("InputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <para>The number of output tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("OutputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. \<c>true\\</c> indicates success. \<c>false\\</c> indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
