// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SearchLumaKnowledgeBaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of Success indicates a successful call. If the call fails, a specific error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The retrieval result from the knowledge base bound to the Agent.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchLumaKnowledgeBaseResponseBodyData Data { get; set; }
        public class SearchLumaKnowledgeBaseResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of matched text chunks, sorted by relevance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;DocumentId&quot;:&quot;doc-bp1xxxxxxxxxxxx&quot;,&quot;ChunkSeq&quot;:3,&quot;Content&quot;:&quot;EventBridge supports event routing&quot;}]</para>
            /// </summary>
            [NameInMap("Chunks")]
            [Validation(Required=false)]
            public List<KnowledgeBaseSearchChunk> Chunks { get; set; }

            /// <summary>
            /// <para>The time spent on the retrieval, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1200</para>
            /// </summary>
            [NameInMap("TimeSpent")]
            [Validation(Required=false)]
            public long? TimeSpent { get; set; }

        }

        /// <summary>
        /// <para>The message returned by the operation. The value is Operation success if the call succeeds, or a specific error description if the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, used for troubleshooting and ticket feedback.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34AD682D-5B91-5773-8132-AA38C130****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. A value of true indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
