// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListKnowledgeBasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The business error code. This field is omitted when the request is successful. If the request fails, the common error response protocol is followed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameter</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of knowledge bases on the current page and the cursor for the next page.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListKnowledgeBasesResponseBodyData Data { get; set; }
        public class ListKnowledgeBasesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of knowledge bases that the current caller has permission to view in the current region.</para>
            /// </summary>
            [NameInMap("KnowledgeBases")]
            [Validation(Required=false)]
            public List<ListKnowledgeBasesResponseBodyDataKnowledgeBases> KnowledgeBases { get; set; }
            public class ListKnowledgeBasesResponseBodyDataKnowledgeBases : TeaModel {
                /// <summary>
                /// <para>The read-only access role of the current caller for the knowledge base. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OWNER: owner</description></item>
                /// <item><description>ADMIN: administrator</description></item>
                /// <item><description>VIEWER: viewer</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OWNER</para>
                /// </summary>
                [NameInMap("AccessRole")]
                [Validation(Required=false)]
                public string AccessRole { get; set; }

                /// <summary>
                /// <para>The creation time of the knowledge base. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1794369600000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the knowledge base. This field can be empty if no description is set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Knowledge about sales metrics, orders, and business policies</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The stable ID of the knowledge base, which can be used to limit the search scope.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345678-1234-4234-8234-123456789abc</para>
                /// </summary>
                [NameInMap("KnowledgeBaseId")]
                [Validation(Required=false)]
                public string KnowledgeBaseId { get; set; }

                /// <summary>
                /// <para>The last modification time of the knowledge base. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1794373200000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The name of the knowledge base.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sales knowledge base</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The DataWorks user ID of the knowledge base owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000000000000000</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The public status of the knowledge base. This list returns only normally visible knowledge bases, and the value is ACTIVE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACTIVE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the knowledge base. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PERSONAL: personal knowledge base</description></item>
                /// <item><description>ENTERPRISE: enterprise knowledge base</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PERSONAL</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The pagination cursor. Do not specify this parameter when you request the first page. For subsequent pages, use the NextToken value returned in the previous response as is. An empty response indicates that no more pages are available. If the current page is empty but the cursor is not empty, continue pagination. Keep the same MaxResults value during pagination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJvZmZzZXQiOjIwfQ</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of knowledge bases to return per page. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The readable description of the business error. This field is omitted when the request is successful. Provide the RequestId along with this message when troubleshooting failures.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request parameters are invalid.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which can be used to troubleshoot issues.</para>
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
