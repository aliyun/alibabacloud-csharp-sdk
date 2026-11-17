// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListCollaborationGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The common business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERR.Robject.Auth.TenantAccessDenied</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of items on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;collaborationGroupId&quot;:&quot;cg_9401&quot;,&quot;name&quot;:&quot;Product Collaboration Space&quot;,&quot;status&quot;:&quot;ACTIVE&quot;,&quot;currentUserRole&quot;:&quot;OWNER&quot;}]</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListCollaborationGroupsResponseBodyItems> Items { get; set; }
        public class ListCollaborationGroupsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The ID of the collaboration space.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cg_9401</para>
            /// </summary>
            [NameInMap("collaborationGroupId")]
            [Validation(Required=false)]
            public string CollaborationGroupId { get; set; }

            /// <summary>
            /// <para>The role of the current user in the space.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ADMIN</para>
            /// </summary>
            [NameInMap("currentUserRole")]
            [Validation(Required=false)]
            public string CurrentUserRole { get; set; }

            /// <summary>
            /// <para>The name of the space.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Workflow To-Do Test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status of the space. Currently, only ACTIVE is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The common error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You do not have permissions to access tenant 2147483647 because the user does not belong to the tenant</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c9cf6cb3-3f5c-4994-a8a1-c93379a6f5cf</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of filtered records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
