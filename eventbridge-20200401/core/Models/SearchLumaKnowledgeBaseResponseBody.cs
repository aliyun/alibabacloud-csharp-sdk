// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SearchLumaKnowledgeBaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The value is Success if the call is successful, or a specific error code if the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The search results from the knowledge base bound to the agent.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchLumaKnowledgeBaseResponseBodyData Data { get; set; }
        public class SearchLumaKnowledgeBaseResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of text chunks matched by the search, sorted by relevance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;DocumentId&quot;:&quot;doc-bp1xxxxxxxxxxxx&quot;,&quot;ChunkSeq&quot;:3,&quot;Content&quot;:&quot;EventBridge supports event routing&quot;}]</para>
            /// </summary>
            [NameInMap("Chunks")]
            [Validation(Required=false)]
            public List<KnowledgeBaseSearchChunk> Chunks { get; set; }

            /// <summary>
            /// <para>The duration of the search, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1200</para>
            /// </summary>
            [NameInMap("TimeSpent")]
            [Validation(Required=false)]
            public long? TimeSpent { get; set; }

        }

        /// <summary>
        /// <para>The response message. The value is Operation success if the call is successful, or a specific error description if the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request. You can use this ID for troubleshooting and submitting tickets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34AD682D-5B91-5773-8132-AA38C130****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates that the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
