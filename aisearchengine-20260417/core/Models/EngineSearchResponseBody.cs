// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiSearchEngine20260417.Models
{
    public class EngineSearchResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public EngineSearchResponseBodyData Data { get; set; }
        public class EngineSearchResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>搜索词违禁</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("extra")]
            [Validation(Required=false)]
            public Dictionary<string, object> Extra { get; set; }

            [NameInMap("items")]
            [Validation(Required=false)]
            public List<EngineSearchResponseBodyDataItems> Items { get; set; }
            public class EngineSearchResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;rankScore&quot;:1.0}</para>
                /// </summary>
                [NameInMap("algorithm")]
                [Validation(Required=false)]
                public Dictionary<string, object> Algorithm { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;titile&quot;:&quot;大疆无人机&quot;}</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public Dictionary<string, object> Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>iceberg-tbl-b7420156-6d23-4555-8e05-12285b36d6ca</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.75</para>
                /// </summary>
                [NameInMap("score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;traceId&quot;:&quot;12285b36d6ca&quot;}</para>
                /// </summary>
                [NameInMap("traceInfo")]
                [Validation(Required=false)]
                public Dictionary<string, object> TraceInfo { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>62CC3999-5380-5344-ABC7-46453625A910</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>121</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;traceId&quot;:&quot;234234324&quot;}</para>
            /// </summary>
            [NameInMap("traceInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> TraceInfo { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
