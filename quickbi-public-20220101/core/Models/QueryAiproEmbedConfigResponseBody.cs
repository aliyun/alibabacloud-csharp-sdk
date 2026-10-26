// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryAiproEmbedConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D8749***C180FF3B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryAiproEmbedConfigResponseBodyResult> Result { get; set; }
        public class QueryAiproEmbedConfigResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>小Q</para>
            /// </summary>
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123124</para>
            /// </summary>
            [NameInMap("AiProId")]
            [Validation(Required=false)]
            public string AiProId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ChatHistoryStatus")]
            [Validation(Required=false)]
            public int? ChatHistoryStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MemoryEnabled")]
            [Validation(Required=false)]
            public int? MemoryEnabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0327</para>
            /// </summary>
            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UploadEnabled")]
            [Validation(Required=false)]
            public int? UploadEnabled { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
