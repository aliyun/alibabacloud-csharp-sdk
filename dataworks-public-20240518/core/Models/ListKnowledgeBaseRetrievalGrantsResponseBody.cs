// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListKnowledgeBaseRetrievalGrantsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business error code. You can use this code to determine the error type when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameter</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data returned when the request is successful.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListKnowledgeBaseRetrievalGrantsResponseBodyData Data { get; set; }
        public class ListKnowledgeBaseRetrievalGrantsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The user grants on the current page.</para>
            /// </summary>
            [NameInMap("KnowledgeBaseRetrievalGrants")]
            [Validation(Required=false)]
            public List<ListKnowledgeBaseRetrievalGrantsResponseBodyDataKnowledgeBaseRetrievalGrants> KnowledgeBaseRetrievalGrants { get; set; }
            public class ListKnowledgeBaseRetrievalGrantsResponseBodyDataKnowledgeBaseRetrievalGrants : TeaModel {
                /// <summary>
                /// <para>The knowledge base ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345678-1234-4234-8234-123456789abc</para>
                /// </summary>
                [NameInMap("KnowledgeBaseId")]
                [Validation(Required=false)]
                public string KnowledgeBaseId { get; set; }

                /// <summary>
                /// <para>The DataWorks user ID of the principal that receives the share. When a principal is added, the system verifies whether the user is a member of the same tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000000000000000</para>
                /// </summary>
                [NameInMap("PrincipalId")]
                [Validation(Required=false)]
                public string PrincipalId { get; set; }

                /// <summary>
                /// <para>The type of principal that receives the share. Default value: USER. Only USER is supported in the initial release.</para>
                /// 
                /// <b>Example:</b>
                /// <para>USER</para>
                /// </summary>
                [NameInMap("PrincipalType")]
                [Validation(Required=false)]
                public string PrincipalType { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of entries per page used in the current request. If you do not specify this parameter in the request, the value is 20. This value is not the actual number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The cursor for the next page. If no subsequent pages exist, null is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJvZmZzZXQiOjIwfQ</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// <para>The error message returned when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request parameters are invalid</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-4000-8000-000000000001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
