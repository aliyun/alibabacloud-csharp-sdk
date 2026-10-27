// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListIdentityProviderDepartmentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code of the API request. SUCCESS indicates that the request is successful, but does not indicate that the asynchronous synchronization task is completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code of the API request, which does not indicate the execution result of the asynchronous task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The direct child departments on the current page under the current parent department. You must make another query to obtain the details of the child departments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;id&quot;:&quot;10001&quot;,&quot;name&quot;:&quot;R&amp;D Department&quot;,&quot;parentId&quot;:&quot;1&quot;,&quot;memberCount&quot;:12,&quot;hasChildren&quot;:true}]</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListIdentityProviderDepartmentsResponseBodyItems> Items { get; set; }
        public class ListIdentityProviderDepartmentsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>Indicates whether the department has child departments. A value of true indicates that the department has child departments and an expansion entry can be displayed accordingly. A value of false indicates a leaf node. If this field is not returned, the status is unknown. You must use the ID of the current node to make another query to obtain the details of the child departments.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("hasChildren")]
            [Validation(Required=false)]
            public bool? HasChildren { get; set; }

            /// <summary>
            /// <para>The unique identifier of the department returned by the identity provider. When querying the child departments of this node, use this value as the parentDepartmentId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The number of members in the department returned by the identity provider. This field is not returned when the number is unknown. Do not treat a missing value as 0.</para>
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
        /// <para>The number of items per page used for this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response message of the API request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token for the next page. An empty or missing value indicates that there are no subsequent pages at the current hierarchy level of the parent department, but does not indicate that the entire department tree has been returned.</para>
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
        /// <para>Indicates whether the API request is successful. To check whether an asynchronous task is completed, query the task status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of departments. This operation does not provide this statistic and may not return this field. Do not treat a missing value as 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
