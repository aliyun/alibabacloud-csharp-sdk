// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListDocumentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code of the API operation. A value of Success indicates that the call is successful. If the call fails, a specific error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The query result of the document list, which includes document entries and pagination information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDocumentsResponseBodyData Data { get; set; }
        public class ListDocumentsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of document entries in the knowledge base. Each entry includes information such as the document ID, file name, processing status, size, number of chunks, and metadata.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;DocumentId&quot;:&quot;doc-bp1xxxxxxxxxxxx&quot;,&quot;FileName&quot;:&quot;manual.pdf&quot;,&quot;Status&quot;:&quot;COMPLETED&quot;,&quot;ChunkCount&quot;:120}]</para>
            /// </summary>
            [NameInMap("Documents")]
            [Validation(Required=false)]
            public List<KnowledgeBaseDocument> Documents { get; set; }

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
            /// <para>The pagination token for the next page, which is an opaque string. You can pass this token as the NextToken parameter in the next request to retrieve the next page. An empty value indicates that no more data is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca1eb85f5d99c7d6a97e6****</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of documents that meet the filtering conditions. Pagination ends when NextToken is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The prompt message returned by the API operation. If the call is successful, the value is Operation success. If the call fails, a specific error description is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which is used for troubleshooting and ticket submission.</para>
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
