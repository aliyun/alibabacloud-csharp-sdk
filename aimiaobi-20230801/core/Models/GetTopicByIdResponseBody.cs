// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetTopicByIdResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoData</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Business data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTopicByIdResponseBodyData Data { get; set; }
        public class GetTopicByIdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Asynchronous task ID (used in custom topic scenarios)</para>
            /// 
            /// <b>Example:</b>
            /// <para>异步任务ID（自定义主题场景下使用）</para>
            /// </summary>
            [NameInMap("AsyncTaskId")]
            [Validation(Required=false)]
            public string AsyncTaskId { get; set; }

            /// <summary>
            /// <para>Creator user ID (used in custom topic scenarios)</para>
            /// 
            /// <b>Example:</b>
            /// <para>创建用户ID（自定义主题场景下使用）</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>Hotness value</para>
            /// 
            /// <b>Example:</b>
            /// <para>43</para>
            /// </summary>
            [NameInMap("HotValue")]
            [Validation(Required=false)]
            public long? HotValue { get; set; }

            /// <summary>
            /// <para>Hot topic ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>热榜ID</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Asynchronous task status (used in custom event scenarios) (PENDING: pending, RUNNING: running, SUCCESSED: succeeded, SUSPENDED: suspended, FAILED: failed, CANCELED: canceled)</para>
            /// 
            /// <b>Example:</b>
            /// <para>PENDING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>List of structured topic summaries</para>
            /// </summary>
            [NameInMap("StructureSummary")]
            [Validation(Required=false)]
            public List<GetTopicByIdResponseBodyDataStructureSummary> StructureSummary { get; set; }
            public class GetTopicByIdResponseBodyDataStructureSummary : TeaModel {
                /// <summary>
                /// <para>Articles referenced to generate the title summary</para>
                /// </summary>
                [NameInMap("DocList")]
                [Validation(Required=false)]
                public List<GetTopicByIdResponseBodyDataStructureSummaryDocList> DocList { get; set; }
                public class GetTopicByIdResponseBodyDataStructureSummaryDocList : TeaModel {
                    /// <summary>
                    /// <para>Article source</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>头条</para>
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    /// <summary>
                    /// <para>Article title</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>文章标题</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// <para>Article URL</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com">http://www.example.com</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>Summary</para>
                /// 
                /// <b>Example:</b>
                /// <para>摘要</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                /// <summary>
                /// <para>Title</para>
                /// 
                /// <b>Example:</b>
                /// <para>标题</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>Hot topic summary</para>
            /// 
            /// <b>Example:</b>
            /// <para>热榜摘要</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>Error message for asynchronous task failure</para>
            /// 
            /// <b>Example:</b>
            /// <para>异步任务失败错误信息</para>
            /// </summary>
            [NameInMap("TaskErrorMessage")]
            [Validation(Required=false)]
            public string TaskErrorMessage { get; set; }

            /// <summary>
            /// <para>Asynchronous task status. 0: pending, 1: running, 2: succeeded, 3: suspended (not used), 4: failed, 6: canceled (used in custom event scenarios).</para>
            /// 
            /// <b>Example:</b>
            /// <para>14</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

            /// <summary>
            /// <para>Unique topic name</para>
            /// 
            /// <b>Example:</b>
            /// <para>主题唯一名称</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// <para>Hot topic source. Supported sources:</para>
            /// <list type="bullet">
            /// <item><description><para>Toutiao: Toutiao</para>
            /// </description></item>
            /// <item><description><para>Quark: Quark</para>
            /// </description></item>
            /// <item><description><para>Baidu: Baidu</para>
            /// </description></item>
            /// <item><description><para>Sina: Sina</para>
            /// </description></item>
            /// <item><description><para>Custom: Custom</para>
            /// </description></item>
            /// <item><description><para>Aggregation: Hot Topic List</para>
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
            /// <para>Data version</para>
            /// 
            /// <b>Example:</b>
            /// <para>数据版本</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error description</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Unique request identifier</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation succeeded: true for success, false for failure</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
