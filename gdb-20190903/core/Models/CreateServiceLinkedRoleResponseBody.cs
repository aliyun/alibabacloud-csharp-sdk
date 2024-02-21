// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gdb20190903.Models
{
    public class CreateServiceLinkedRoleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Role")]
        [Validation(Required=false)]
        public CreateServiceLinkedRoleResponseBodyRole Role { get; set; }
        public class CreateServiceLinkedRoleResponseBodyRole : TeaModel {
            [NameInMap("Role")]
            [Validation(Required=false)]
            public List<CreateServiceLinkedRoleResponseBodyRoleRole> Role { get; set; }
            public class CreateServiceLinkedRoleResponseBodyRoleRole : TeaModel {
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                [NameInMap("AssumeRolePolicyDocument")]
                [Validation(Required=false)]
                public string AssumeRolePolicyDocument { get; set; }

                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("IsServiceLinkedRole")]
                [Validation(Required=false)]
                public bool? IsServiceLinkedRole { get; set; }

                [NameInMap("LatestDeletionTask")]
                [Validation(Required=false)]
                public bool? LatestDeletionTask { get; set; }

                [NameInMap("RoleId")]
                [Validation(Required=false)]
                public string RoleId { get; set; }

                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

                [NameInMap("RolePrincipalName")]
                [Validation(Required=false)]
                public string RolePrincipalName { get; set; }

            }

        }

    }

}
