// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListEntitiesForPolicyResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Groups")]
        [Validation(Required=false)]
        public ListEntitiesForPolicyResponseBodyGroups Groups { get; set; }
        public class ListEntitiesForPolicyResponseBodyGroups : TeaModel {
            [NameInMap("Group")]
            [Validation(Required=false)]
            public List<ListEntitiesForPolicyResponseBodyGroupsGroup> Group { get; set; }
            public class ListEntitiesForPolicyResponseBodyGroupsGroup : TeaModel {
                public string GroupName { get; set; }
                public string Comments { get; set; }
                public string AttachDate { get; set; }
            }
        };

        [NameInMap("Roles")]
        [Validation(Required=false)]
        public ListEntitiesForPolicyResponseBodyRoles Roles { get; set; }
        public class ListEntitiesForPolicyResponseBodyRoles : TeaModel {
            [NameInMap("Role")]
            [Validation(Required=false)]
            public List<ListEntitiesForPolicyResponseBodyRolesRole> Role { get; set; }
            public class ListEntitiesForPolicyResponseBodyRolesRole : TeaModel {
                public string Description { get; set; }
                public string RoleName { get; set; }
                public string AttachDate { get; set; }
                public string Arn { get; set; }
                public string RoleId { get; set; }
            }
        };

        [NameInMap("Users")]
        [Validation(Required=false)]
        public ListEntitiesForPolicyResponseBodyUsers Users { get; set; }
        public class ListEntitiesForPolicyResponseBodyUsers : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public List<ListEntitiesForPolicyResponseBodyUsersUser> User { get; set; }
            public class ListEntitiesForPolicyResponseBodyUsersUser : TeaModel {
                public string DisplayName { get; set; }
                public string UserId { get; set; }
                public string UserName { get; set; }
                public string AttachDate { get; set; }
            }
        };

    }

}
