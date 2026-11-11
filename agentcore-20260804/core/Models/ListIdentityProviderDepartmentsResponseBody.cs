// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListIdentityProviderDepartmentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code for the current API request. SUCCESS indicates that the current request is successful, but does not indicate that the asynchronous synchronization task is completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code for the current API request. This does not indicate the execution result of an asynchronous task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The direct child departments on the current page under the current parent department. For details about the child departments, you must make another query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;id&quot;:&quot;10001&quot;,&quot;name&quot;:&quot;R&amp;D Department&quot;,&quot;parentId&quot;:&quot;1&quot;,&quot;memberCount&quot;:12,&quot;hasChildren&quot;:true}]</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListIdentityProviderDepartmentsResponseBodyItems> Items { get; set; }
        public class ListIdentityProviderDepartmentsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>A value of true indicates that the department has child departments, and you can display an expansion entry based on this. A value of false indicates a leaf node. If this parameter is not returned, the value is unknown. For details about the child departments, you must make another query by using the id of the current node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("hasChildren")]
            [Validation(Required=false)]
            public bool? HasChildren { get; set; }

            /// <summary>
            /// <para>The unique identifier of the department returned by the identity provider. When querying the child departments of this node, use this value as parentDepartmentId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The number of department members returned by the identity provider. This parameter is not returned when the value is unknown. A missing value should not be treated as 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("memberCount")]
            [Validation(Required=false)]
            public long? MemberCount { get; set; }

            /// <summary>
            /// <para>The name of the department returned by the identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>R&amp;D Department</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the parent department to which this department belongs. This value describes the parent-child relationship and is not used to expand the current node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("parentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page used for the current query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response message for the current API request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token for the next page. An empty value or no return value indicates that there are no subsequent pages at the current level of the parent department, which does not mean that the entire department tree has been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-next-page-token</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request. Provide this value when troubleshooting issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01234567-89AB-CDEF-0123-456789ABCDEF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the current API request is successful. To check whether an asynchronous task is completed, query the task status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>This operation does not calculate the total number of departments. Currently, it actually returns JSON null. To determine whether pagination has ended, check whether nextToken is an empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
