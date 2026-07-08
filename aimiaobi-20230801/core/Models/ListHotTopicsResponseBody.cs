// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListHotTopicsResponseBody : TeaModel {
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
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListHotTopicsResponseBodyData> Data { get; set; }
        public class ListHotTopicsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The asynchronous task ID. This parameter is returned only when <c>TopicSource</c> is <c>Custom</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>异步任务ID（自定义主题场景下使用）</para>
            /// </summary>
            [NameInMap("AsyncTaskId")]
            [Validation(Required=false)]
            public string AsyncTaskId { get; set; }

            /// <summary>
            /// <para>The time the topic was created, in <c>yyyy-MM-dd HH:mm:ss</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-04 12:34:56</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the user who created the topic. This parameter is returned only when <c>TopicSource</c> is <c>Custom</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>创建用户ID（自定义主题场景下使用）</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>A custom field for business-specific data, such as a keyword.</para>
            /// 
            /// <b>Example:</b>
            /// <para>biz-tag-001</para>
            /// </summary>
            [NameInMap("CustomField")]
            [Validation(Required=false)]
            public string CustomField { get; set; }

            /// <summary>
            /// <para>The popularity score of the topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>61</para>
            /// </summary>
            [NameInMap("HotValue")]
            [Validation(Required=false)]
            public long? HotValue { get; set; }

            /// <summary>
            /// <para>The ID of the hot topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>热榜ID</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The asynchronous task status. This parameter is returned only when <c>TopicSource</c> is <c>Custom</c>. Valid values: <c>PENDING</c>, <c>RUNNING</c>, <c>SUCCEEDED</c>, <c>SUSPENDED</c>, <c>FAILED</c>, and <c>CANCELED</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FAILED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>A list of structured topic summaries.</para>
            /// </summary>
            [NameInMap("StructureSummary")]
            [Validation(Required=false)]
            public List<ListHotTopicsResponseBodyDataStructureSummary> StructureSummary { get; set; }
            public class ListHotTopicsResponseBodyDataStructureSummary : TeaModel {
                /// <summary>
                /// <para>A list of articles used to generate the title and summary.</para>
                /// </summary>
                [NameInMap("DocList")]
                [Validation(Required=false)]
                public List<ListHotTopicsResponseBodyDataStructureSummaryDocList> DocList { get; set; }
                public class ListHotTopicsResponseBodyDataStructureSummaryDocList : TeaModel {
                    /// <summary>
                    /// <para>The source of the article.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>夸克</para>
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    /// <summary>
                    /// <para>The article title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxxxx</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// <para>The article URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com">http://www.example.com</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>The generated summary.</para>
                /// 
                /// <b>Example:</b>
                /// <para>摘要</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                /// <summary>
                /// <para>The generated title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>标题</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The hot topic summary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>热榜摘要</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>The error message returned when the asynchronous task fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>异步任务失败错误信息</para>
            /// </summary>
            [NameInMap("TaskErrorMessage")]
            [Validation(Required=false)]
            public string TaskErrorMessage { get; set; }

            /// <summary>
            /// <para>The asynchronous task status. This parameter is returned only when <c>TopicSource</c> is <c>Custom</c>. Valid values: <c>0</c> (Pending), <c>1</c> (Running), <c>2</c> (Succeeded), <c>3</c> (Suspended, not currently in use), <c>4</c> (Failed), and <c>6</c> (Canceled).</para>
            /// 
            /// <b>Example:</b>
            /// <para>26</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

            /// <summary>
            /// <para>The unique topic name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>主题唯一名称</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// <para>The source of the hot topic. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Toutiao</c></para>
            /// </description></item>
            /// <item><description><para><c>Quark</c></para>
            /// </description></item>
            /// <item><description><para><c>Baidu</c></para>
            /// </description></item>
            /// <item><description><para><c>Sina</c></para>
            /// </description></item>
            /// <item><description><para><c>Custom</c></para>
            /// </description></item>
            /// <item><description><para><c>Aggregation</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Toutiao</para>
            /// </summary>
            [NameInMap("TopicSource")]
            [Validation(Required=false)]
            public string TopicSource { get; set; }

            /// <summary>
            /// <para>The URL of the original topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com/topic/123">https://www.example.com/topic/123</a></para>
            /// </summary>
            [NameInMap("TopicUrl")]
            [Validation(Required=false)]
            public string TopicUrl { get; set; }

            /// <summary>
            /// <para>The data version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>数据版本</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

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
        /// <para>The maximum number of results returned on this page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The result message for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>下一页的token</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The unique ID for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. A value of <c>true</c> indicates success; <c>false</c> indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of topics found.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
