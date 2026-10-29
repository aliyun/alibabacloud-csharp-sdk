// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListKnowledgeBasesResponseBody : TeaModel {
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
        /// <para>The query results of the knowledge base list, including knowledge base entries and pagination information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListKnowledgeBasesResponseBodyData Data { get; set; }
        public class ListKnowledgeBasesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of knowledge base entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;KnowledgeBaseName&quot;:&quot;my-knowledge-base&quot;,&quot;Status&quot;:&quot;ACTIVE&quot;}]</para>
            /// </summary>
            [NameInMap("KnowledgeBases")]
            [Validation(Required=false)]
            public List<KnowledgeBase> KnowledgeBases { get; set; }

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
            /// <para>The pagination token for the next page. It is an opaque string. You can pass this token as the NextToken parameter in the next request to retrieve the next page. An empty value indicates that no more data is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca1eb85f5d99c7d6a97e6****</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of knowledge bases that meet the filter conditions. Pagination ends when NextToken is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The response message. If the call is successful, the value is Operation success. If the call fails, a specific error description is returned.</para>
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
