// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetCustomSourceTopicAnalysisTaskResponseBody : TeaModel {
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
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCustomSourceTopicAnalysisTaskResponseBodyData Data { get; set; }
        public class GetCustomSourceTopicAnalysisTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of documents after clustering.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ClusterCount")]
            [Validation(Required=false)]
            public int? ClusterCount { get; set; }

            /// <summary>
            /// <para>A list of news aggregation results.</para>
            /// </summary>
            [NameInMap("ClusterResults")]
            [Validation(Required=false)]
            public List<GetCustomSourceTopicAnalysisTaskResponseBodyDataClusterResults> ClusterResults { get; set; }
            public class GetCustomSourceTopicAnalysisTaskResponseBodyDataClusterResults : TeaModel {
                /// <summary>
                /// <para>A list of aggregated news articles. The body text is not included.</para>
                /// </summary>
                [NameInMap("ClusterNews")]
                [Validation(Required=false)]
                public List<GetCustomSourceTopicAnalysisTaskResponseBodyDataClusterResultsClusterNews> ClusterNews { get; set; }
                public class GetCustomSourceTopicAnalysisTaskResponseBodyDataClusterResultsClusterNews : TeaModel {
                    /// <summary>
                    /// <para>The title of the news article.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>新闻标题</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// <para>The URL of the news article.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com/xxx.html">http://www.example.com/xxx.html</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>The name of the aggregated topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>话题名称</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

            }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>错误信息</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The maximum number of news articles in a cluster after aggregation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("MaxClusteredTopicNewsSize")]
            [Validation(Required=false)]
            public int? MaxClusteredTopicNewsSize { get; set; }

            /// <summary>
            /// <para>The number of news articles after the file is parsed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ParsedNewsSize")]
            [Validation(Required=false)]
            public int? ParsedNewsSize { get; set; }

            /// <summary>
            /// <para>The status of the task. Valid values: \<c>PENDING\\</c>, \<c>RUNNING\\</c>, \<c>SUCCESSED\\</c>, \<c>FAILED\\</c>, and \<c>CANCELED\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESSED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The total runtime in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("rt")]
            [Validation(Required=false)]
            public long? Rt { get; set; }

            /// <summary>
            /// <para>The token usage. The possible billable items are:
            /// quanmiaoMax, quanmiaoPlus</para>
            /// </summary>
            [NameInMap("usages")]
            [Validation(Required=false)]
            public Dictionary<string, long?> Usages { get; set; }

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
        /// <para>The error message.</para>
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
        /// <para>Indicates whether the request was successful. \<c>true\\</c> indicates success and \<c>false\\</c> indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
