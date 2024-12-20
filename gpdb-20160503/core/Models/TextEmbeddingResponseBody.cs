// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class TextEmbeddingResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public TextEmbeddingResponseBodyResults Results { get; set; }
        public class TextEmbeddingResponseBodyResults : TeaModel {
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<TextEmbeddingResponseBodyResultsResults> Results { get; set; }
            public class TextEmbeddingResponseBodyResultsResults : TeaModel {
                [NameInMap("Embedding")]
                [Validation(Required=false)]
                public TextEmbeddingResponseBodyResultsResultsEmbedding Embedding { get; set; }
                public class TextEmbeddingResponseBodyResultsResultsEmbedding : TeaModel {
                    [NameInMap("Embedding")]
                    [Validation(Required=false)]
                    public List<double?> Embedding { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TextTokens")]
        [Validation(Required=false)]
        public int? TextTokens { get; set; }

    }

}
