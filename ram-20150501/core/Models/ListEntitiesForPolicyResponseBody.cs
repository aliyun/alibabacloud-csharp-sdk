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
        public List<ListEntitiesForPolicyResponseBodyGroups> Groups { get; set; }
        public class ListEntitiesForPolicyResponseBodyGroups : TeaModel {
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("Comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }

            [NameInMap("AttachDate")]
            [Validation(Required=false)]
            public string AttachDate { get; set; }

        }

        [NameInMap("Roles")]
        [Validation(Required=false)]
        public List<ListEntitiesForPolicyResponseBodyRoles> Roles { get; set; }
        public class ListEntitiesForPolicyResponseBodyRoles : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            [NameInMap("AttachDate")]
            [Validation(Required=false)]
            public string AttachDate { get; set; }

            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

        }

        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<ListEntitiesForPolicyResponseBodyUsers> Users { get; set; }
        public class ListEntitiesForPolicyResponseBodyUsers : TeaModel {
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("AttachDate")]
            [Validation(Required=false)]
            public string AttachDate { get; set; }

        }

    }

}
