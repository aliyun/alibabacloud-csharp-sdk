// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListCollaborationGroupMembersResponseBody : TeaModel {
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
        /// <para>The list of entries on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;userId&quot;:&quot;5&quot;,&quot;displayName&quot;:&quot;Zhang San&quot;,&quot;role&quot;:&quot;OWNER&quot;,&quot;isActive&quot;:true}]</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListCollaborationGroupMembersResponseBodyItems> Items { get; set; }
        public class ListCollaborationGroupMembersResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The display name. This field is empty if the display name is not set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TEST001</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The enabling status of the tenant account. Only active members are returned, so this value is always true. This field does not indicate the HR employment status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isActive")]
            [Validation(Required=false)]
            public bool? IsActive { get; set; }

            /// <summary>
            /// <para>The role of the workspace member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ADMIN</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The platform user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The common error description.</para>
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
        /// <para>The total number of records after filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
