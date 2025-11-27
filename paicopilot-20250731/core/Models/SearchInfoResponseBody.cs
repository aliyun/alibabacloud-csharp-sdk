// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAICopilot20250731.Models
{
    public class SearchInfoResponseBody : TeaModel {
        [NameInMap("KnowledgeBaseSearchResults")]
        [Validation(Required=false)]
        public List<SearchInfoResponseBodyKnowledgeBaseSearchResults> KnowledgeBaseSearchResults { get; set; }
        public class SearchInfoResponseBodyKnowledgeBaseSearchResults : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public string Index { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DSW is ****** in pai.</para>
            /// </summary>
            [NameInMap("ResultContent")]
            [Validation(Required=false)]
            public string ResultContent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.6215165367</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public double? Score { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>44553E9A-******-37ADC33FE2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WebSearchResults")]
        [Validation(Required=false)]
        public List<SearchInfoResponseBodyWebSearchResults> WebSearchResults { get; set; }
        public class SearchInfoResponseBodyWebSearchResults : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public string Index { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Qwen3-Coder*****is good</para>
            /// </summary>
            [NameInMap("ResultContent")]
            [Validation(Required=false)]
            public string ResultContent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.5215170567</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public double? Score { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://help.aliyun.com/zh/pai/use-cases/dsw-use-qwen3-coder-to-assist-in-code-development">https://help.aliyun.com/zh/pai/use-cases/dsw-use-qwen3-coder-to-assist-in-code-development</a></para>
            /// </summary>
            [NameInMap("SourceLink")]
            [Validation(Required=false)]
            public string SourceLink { get; set; }

        }

    }

}
