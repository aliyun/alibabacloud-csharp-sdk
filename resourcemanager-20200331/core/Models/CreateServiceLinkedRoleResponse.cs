// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreateServiceLinkedRoleResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Role")]
        [Validation(Required=true)]
        public CreateServiceLinkedRoleResponseRole Role { get; set; }
        public class CreateServiceLinkedRoleResponseRole : TeaModel {
            [NameInMap("RoleName")]
            [Validation(Required=true)]
            public string RoleName { get; set; }
            [NameInMap("Description")]
            [Validation(Required=true)]
            public string Description { get; set; }
            [NameInMap("AssumeRolePolicyDocument")]
            [Validation(Required=true)]
            public string AssumeRolePolicyDocument { get; set; }
            [NameInMap("IsServiceLinkedRole")]
            [Validation(Required=true)]
            public bool? IsServiceLinkedRole { get; set; }
            [NameInMap("Arn")]
            [Validation(Required=true)]
            public string Arn { get; set; }
            [NameInMap("RoleId")]
            [Validation(Required=true)]
            public string RoleId { get; set; }
            [NameInMap("CreateDate")]
            [Validation(Required=true)]
            public string CreateDate { get; set; }
            [NameInMap("RolePrincipalName")]
            [Validation(Required=true)]
            public string RolePrincipalName { get; set; }
        };

    }

}
