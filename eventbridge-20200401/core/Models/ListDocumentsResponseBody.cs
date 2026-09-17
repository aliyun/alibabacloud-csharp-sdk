// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListDocumentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of Success indicates a successful operation. If the operation fails, a specific error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The document list query result, which contains document entries and pagination information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDocumentsResponseBodyData Data { get; set; }
        public class ListDocumentsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of document entries in the knowledge base. Each entry contains information such as the document ID, file name, processing status, size, number of chunks, and metadata.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;DocumentId&quot;:&quot;doc-bp1xxxxxxxxxxxx&quot;,&quot;FileName&quot;:&quot;manual.pdf&quot;,&quot;Status&quot;:&quot;COMPLETED&quot;,&quot;ChunkCount&quot;:120}]</para>
            /// </summary>
            [NameInMap("Documents")]
            [Validation(Required=false)]
            public List<KnowledgeBaseDocument> Documents { get; set; }

            /// <summary>
            /// <para>The maximum number of results per page that took effect for this request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The pagination token for the next page (an opaque string). Pass this value as the NextToken parameter in the next request to retrieve the next page. An empty value indicates that no more data is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca1eb85f5d99c7d6a97e6****</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of documents that match the filter conditions. Use an empty NextToken value as the termination condition for pagination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The message returned by the operation. The value is Operation success if the operation succeeds, or a specific error description if the operation fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID of the request. Use this ID for troubleshooting and when you submit a ticket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34AD682D-5B91-5773-8132-AA38C130****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
