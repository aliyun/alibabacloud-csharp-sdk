// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListKnowledgeBasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of Success indicates that the call was successful. If the call failed, a specific error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The query result of the knowledge base list, including knowledge base entries and pagination information.</para>
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
            /// <para>The maximum number of results per page that was applied to this request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The pagination token (an opaque string) for the next page. Pass this value as the NextToken parameter in the next request to retrieve the next page. An empty value indicates that no more data is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca1eb85f5d99c7d6a97e6****</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of knowledge bases that match the filter conditions. Use an empty NextToken value as the termination condition for pagination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The message returned by the operation. The value Operation success is returned if the call was successful. A specific error description is returned if the call failed.</para>
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
