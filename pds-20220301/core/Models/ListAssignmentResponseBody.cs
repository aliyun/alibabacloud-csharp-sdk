// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListAssignmentResponseBody : TeaModel {
        /// <summary>
        /// <para>The assigned roles.</para>
        /// </summary>
        [NameInMap("assignment_list")]
        [Validation(Required=false)]
        public List<ListAssignmentResponseBodyAssignmentList> AssignmentList { get; set; }
        public class ListAssignmentResponseBodyAssignmentList : TeaModel {
            /// <summary>
            /// <para>The time when the role was assigned. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1622682267564</para>
            /// </summary>
            [NameInMap("created_at")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            /// <summary>
            /// <para>The ID of the user who assigned the role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>216***c83</para>
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The domain ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hz1</para>
            /// </summary>
            [NameInMap("domain_id")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            /// <summary>
            /// <para>The identity to whom the role is assigned, which is a user or a group.</para>
            /// </summary>
            [NameInMap("identity")]
            [Validation(Required=false)]
            public Identity Identity { get; set; }

            /// <summary>
            /// <para>The ID of the managed resource, such as a group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>105***b82</para>
            /// </summary>
            [NameInMap("manage_resource_id")]
            [Validation(Required=false)]
            public string ManageResourceId { get; set; }

            /// <summary>
            /// <para>The type of the managed resource. For example, a value of RT_Group indicates group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RT_Group</para>
            /// </summary>
            [NameInMap("manage_resource_type")]
            [Validation(Required=false)]
            public string ManageResourceType { get; set; }

            /// <summary>
            /// <para>The ID of the role assigned to the identity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SystemGroupAdmin</para>
            /// </summary>
            [NameInMap("role_id")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If next_marker is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NWQ1Yjk4YmI1ZDRlYmU1Y2E0YWE0NmJhYWJmODBhNDQ2NzhlMTRhMg</para>
        /// </summary>
        [NameInMap("next_marker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

    }

}
