// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class TextEmbeddingResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The embedding results.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public TextEmbeddingResponseBodyResults Results { get; set; }
        public class TextEmbeddingResponseBodyResults : TeaModel {
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<TextEmbeddingResponseBodyResultsResults> Results { get; set; }
            public class TextEmbeddingResponseBodyResultsResults : TeaModel {
                /// <summary>
                /// <para>The embedding values.</para>
                /// </summary>
                [NameInMap("Embedding")]
                [Validation(Required=false)]
                public TextEmbeddingResponseBodyResultsResultsEmbedding Embedding { get; set; }
                public class TextEmbeddingResponseBodyResultsResultsEmbedding : TeaModel {
                    [NameInMap("Embedding")]
                    [Validation(Required=false)]
                    public List<double?> Embedding { get; set; }

                }

                /// <summary>
                /// <para>The number of the embedding in the Input request parameter, which starts from 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

            }

        }

        /// <summary>
        /// <para>The status of the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b></description></item>
        /// <item><description><b>fail</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The total number of tokens consumed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TextTokens")]
        [Validation(Required=false)]
        public int? TextTokens { get; set; }

    }

}
