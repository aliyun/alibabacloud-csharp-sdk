// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListAssignmentResponseBody : TeaModel {
        [NameInMap("assignment_list")]
        [Validation(Required=false)]
        public List<ListAssignmentResponseBodyAssignmentList> AssignmentList { get; set; }
        public class ListAssignmentResponseBodyAssignmentList : TeaModel {
            [NameInMap("created_at")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("domain_id")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            [NameInMap("identity")]
            [Validation(Required=false)]
            public Identity Identity { get; set; }

            [NameInMap("manage_resource_id")]
            [Validation(Required=false)]
            public string ManageResourceId { get; set; }

            [NameInMap("manage_resource_type")]
            [Validation(Required=false)]
            public string ManageResourceType { get; set; }

            [NameInMap("role_id")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

        }

        [NameInMap("next_marker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

    }

}
