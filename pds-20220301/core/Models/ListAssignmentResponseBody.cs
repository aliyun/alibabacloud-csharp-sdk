// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListAssignmentResponseBody : TeaModel {
        /// <summary>
        /// The assigned roles.
        /// </summary>
        [NameInMap("assignment_list")]
        [Validation(Required=false)]
        public List<ListAssignmentResponseBodyAssignmentList> AssignmentList { get; set; }
        public class ListAssignmentResponseBodyAssignmentList : TeaModel {
            /// <summary>
            /// The time when the role was assigned. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("created_at")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            /// <summary>
            /// The ID of the user who assigned the role.
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// The domain ID.
            /// </summary>
            [NameInMap("domain_id")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            /// <summary>
            /// The identity to whom the role is assigned, which is a user or a group.
            /// </summary>
            [NameInMap("identity")]
            [Validation(Required=false)]
            public Identity Identity { get; set; }

            /// <summary>
            /// The ID of the managed resource, such as a group ID.
            /// </summary>
            [NameInMap("manage_resource_id")]
            [Validation(Required=false)]
            public string ManageResourceId { get; set; }

            /// <summary>
            /// The type of the managed resource. For example, a value of RT_Group indicates group.
            /// </summary>
            [NameInMap("manage_resource_type")]
            [Validation(Required=false)]
            public string ManageResourceType { get; set; }

            /// <summary>
            /// The ID of the role assigned to the identity.
            /// </summary>
            [NameInMap("role_id")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

        }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. If next_marker is empty, no next page exists.
        /// </summary>
        [NameInMap("next_marker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

    }

}
