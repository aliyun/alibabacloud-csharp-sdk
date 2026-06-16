// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiSearchEngine20260417.Models
{
    public class EngineSearchResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The business data body.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public EngineSearchResponseBodyData Data { get; set; }
        public class EngineSearchResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>搜索词违禁</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The additional metadata. </para>
            /// <remarks>
            /// <para>Contains the exclude_ids field, which represents the list of IDs that were actually excluded. The format is <c>Array[String]</c>.</para>
            /// <list type="bullet">
            /// <item><description>Example: [&quot;id_1&quot;, &quot;id_2&quot;].</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{exclude_ids: [&quot;id_1&quot;, &quot;id_2&quot;]}</para>
            /// </summary>
            [NameInMap("extra")]
            [Validation(Required=false)]
            public Dictionary<string, object> Extra { get; set; }

            /// <summary>
            /// <para>搜索结果列表</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<EngineSearchResponseBodyDataItems> Items { get; set; }
            public class EngineSearchResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>算法内容</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;rankScore&quot;:1.0}</para>
                /// </summary>
                [NameInMap("algorithm")]
                [Validation(Required=false)]
                public Dictionary<string, object> Algorithm { get; set; }

                /// <summary>
                /// <para>内容详情对象（详细结构见下文）</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;titile&quot;:&quot;大疆无人机&quot;}</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public Dictionary<string, object> Content { get; set; }

                /// <summary>
                /// <para>权益绑定 ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>iceberg-tbl-b7420156-6d23-4555-8e05-12285b36d6ca</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>相关性得分</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.005369</para>
                /// </summary>
                [NameInMap("score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// <para>回传日志时使用。</para>
                /// <para>取值：</para>
                /// <para>trace_id=ali。</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;traceId&quot;:&quot;12285b36d6ca&quot;}</para>
                /// </summary>
                [NameInMap("traceInfo")]
                [Validation(Required=false)]
                public Dictionary<string, object> TraceInfo { get; set; }

            }

            /// <summary>
            /// <para>The search page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The response ID of this request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>62CC3999-5380-5344-ABC7-46453625A910</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The number of results returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The execution status.
            /// 200: succeeded.
            /// 500: failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>121</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

            /// <summary>
            /// <para>The Tracing Analysis information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;traceId&quot;:&quot;234234324&quot;}</para>
            /// </summary>
            [NameInMap("traceInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> TraceInfo { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
