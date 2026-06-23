// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetAppConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Time consumed</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        /// <summary>
        /// <para>Returned data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAppConfigResponseBodyData Data { get; set; }
        public class GetAppConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Embedding type list</para>
            /// </summary>
            [NameInMap("embeddingTypeList")]
            [Validation(Required=false)]
            public List<Dictionary<string, string>> EmbeddingTypeList { get; set; }

            /// <summary>
            /// <para>Frontend configuration</para>
            /// </summary>
            [NameInMap("frontendConfig")]
            [Validation(Required=false)]
            public Dictionary<string, bool?> FrontendConfig { get; set; }

            /// <summary>
            /// <para>Document library status list</para>
            /// </summary>
            [NameInMap("libraryDocumentStatusList")]
            [Validation(Required=false)]
            public List<Dictionary<string, string>> LibraryDocumentStatusList { get; set; }

            /// <summary>
            /// <para>Large Language Model (LLM) type list</para>
            /// </summary>
            [NameInMap("llmHelperTypeList")]
            [Validation(Required=false)]
            public List<Dictionary<string, string>> LlmHelperTypeList { get; set; }

            /// <summary>
            /// <para>Text index category list</para>
            /// </summary>
            [NameInMap("textIndexCategoryList")]
            [Validation(Required=false)]
            public List<string> TextIndexCategoryList { get; set; }

            /// <summary>
            /// <para>Vector index category list</para>
            /// </summary>
            [NameInMap("vectorIndexCategoryList")]
            [Validation(Required=false)]
            public List<string> VectorIndexCategoryList { get; set; }

        }

        /// <summary>
        /// <para>Data type</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>Error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>EF4B5C9B-3BC8-5171-A47B-4C5CF3DC3258</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Is successful</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Timestamp</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-04-24 11:54:34</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
