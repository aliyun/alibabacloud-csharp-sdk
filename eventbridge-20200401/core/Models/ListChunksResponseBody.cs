// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListChunksResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of Success indicates that the call is successful. If the call fails, a specific error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The query result of the chunk list, which includes chunk entries and pagination information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListChunksResponseBodyData Data { get; set; }
        public class ListChunksResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of chunk entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;DocumentId&quot;:&quot;doc-bp1xxxxxxxxxxxx&quot;,&quot;ChunkSeq&quot;:1,&quot;Content&quot;:&quot;EventBridge supports event routing&quot;}]</para>
            /// </summary>
            [NameInMap("Chunks")]
            [Validation(Required=false)]
            public List<KnowledgeBaseChunk> Chunks { get; set; }

            /// <summary>
            /// <para>The actual maximum number of results per page that takes effect for the current request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The pagination token for the next page, which is an opaque string. Pass this value to the NextToken parameter of the next request to obtain the next page. An empty value indicates that no more data is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca1eb85f5d99c7d6a97e6****</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of chunks in the specified document. This parameter is returned only when DocumentId is specified. In full-base mode (when DocumentId is not specified), this parameter is not returned, and pagination ends when NextToken is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The prompt message returned by the API. If the call is successful, the value is Operation success. If the call fails, a specific error description is returned.</para>
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
