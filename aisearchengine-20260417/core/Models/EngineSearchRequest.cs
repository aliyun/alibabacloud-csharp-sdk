// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiSearchEngine20260417.Models
{
    public class EngineSearchRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>507218</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("grey")]
        [Validation(Required=false)]
        public bool? Grey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public EngineSearchRequestQuery Query { get; set; }
        public class EngineSearchRequestQuery : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;24234111&quot;,&quot;12423525&quot;]</para>
            /// </summary>
            [NameInMap("excludeIds")]
            [Validation(Required=false)]
            public List<string> ExcludeIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;<a href="https://paperreview.oss-cn-hangzhou.aliyuncs.com/59dd424f-97ed-4855-942e-c961f1f5b67e.jpeg%22%5D">https://paperreview.oss-cn-hangzhou.aliyuncs.com/59dd424f-97ed-4855-942e-c961f1f5b67e.jpeg&quot;]</a></para>
            /// </summary>
            [NameInMap("imageUrls")]
            [Validation(Required=false)]
            public List<string> ImageUrls { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;梅花图片&quot;]</para>
            /// </summary>
            [NameInMap("texts")]
            [Validation(Required=false)]
            public List<string> Texts { get; set; }

        }

        [NameInMap("recall")]
        [Validation(Required=false)]
        public EngineSearchRequestRecall Recall { get; set; }
        public class EngineSearchRequestRecall : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("closeRecallAsr")]
            [Validation(Required=false)]
            public bool? CloseRecallAsr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("needMergeSegments")]
            [Validation(Required=false)]
            public bool? NeedMergeSegments { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2e95ef4fbc28437db5008a910bd392a4</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>507218</para>
        /// </summary>
        [NameInMap("strategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

        [NameInMap("user")]
        [Validation(Required=false)]
        public EngineSearchRequestUser User { get; set; }
        public class EngineSearchRequestUser : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;123456&quot;</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>默认1.0</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
