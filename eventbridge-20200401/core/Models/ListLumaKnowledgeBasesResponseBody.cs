// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListLumaKnowledgeBasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of Success indicates that the call was successful. If the call fails, a specific error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of knowledge bases bound to the agent, including entries and pagination information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListLumaKnowledgeBasesResponseBodyData Data { get; set; }
        public class ListLumaKnowledgeBasesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of knowledge bases bound to the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;KnowledgeBaseName&quot;:&quot;my-knowledge-base&quot;}]</para>
            /// </summary>
            [NameInMap("KnowledgeBases")]
            [Validation(Required=false)]
            public List<KnowledgeBase> KnowledgeBases { get; set; }

            /// <summary>
            /// <para>The maximum number of results per page that takes effect for this request. If MaxResults is not specified, this value is the server default. If the specified value exceeds the upper limit, this value is the adjusted value.</para>
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
            /// <para>The total number of knowledge bases bound to the agent, regardless of the number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The message returned by the operation. The value Operation success is returned if the call was successful. A specific error description is returned if the call fails.</para>
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
        /// <para>Indicates whether the call was successful. A value of true indicates that the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
