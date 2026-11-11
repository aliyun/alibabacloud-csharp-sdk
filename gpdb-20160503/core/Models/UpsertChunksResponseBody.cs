// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class UpsertChunksResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of tokens used for vectorization.</para>
        /// <remarks>
        /// <para>A token is the smallest unit into which input text is divided. A token can be a word, a phrase, a punctuation mark, or a character.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("EmbeddingTokens")]
        [Validation(Required=false)]
        public string EmbeddingTokens { get; set; }

        /// <summary>
        /// <para>The job ID. You can use this ID to call the GetGraphRAGJob operation to query the job status later.</para>
        /// <remarks>
        /// <para>This parameter is returned only when knowledge graph construction is enabled for the knowledge base.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>231460f8-75dc-405e-a669-0c5204887e91</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The execution status of the API operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b>: The operation is successful.</description></item>
        /// <item><description><b>fail</b>: The operation fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
