// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SearchKnowledgeBaseResponseBody : TeaModel {
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
        /// <para>The search results, including the list of matched chunks and the time spent.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchKnowledgeBaseResponseBodyData Data { get; set; }
        public class SearchKnowledgeBaseResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of matched chunks, sorted by relevance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;DocumentId&quot;:&quot;doc-bp1xxxxxxxxxxxx&quot;,&quot;ChunkSeq&quot;:3,&quot;Content&quot;:&quot;EventBridge supports event routing&quot;}]</para>
            /// </summary>
            [NameInMap("Chunks")]
            [Validation(Required=false)]
            public List<KnowledgeBaseSearchChunk> Chunks { get; set; }

            /// <summary>
            /// <para>The server-side processing duration of this search. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("TimeSpent")]
            [Validation(Required=false)]
            public long? TimeSpent { get; set; }

        }

        /// <summary>
        /// <para>The response message. A value of Operation success is returned for a successful call. A specific error description is returned for a failed call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
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
