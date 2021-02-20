// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreateServiceLinkedRoleResponseBody : TeaModel {
        [NameInMap("Role")]
        [Validation(Required=false)]
        public CreateServiceLinkedRoleResponseBodyRole Role { get; set; }
        public class CreateServiceLinkedRoleResponseBodyRole : TeaModel {
            [NameInMap("AssumeRolePolicyDocument")]
            [Validation(Required=false)]
            public string AssumeRolePolicyDocument { get; set; }
            [NameInMap("RolePrincipalName")]
            [Validation(Required=false)]
            public string RolePrincipalName { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }
            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public string RoleId { get; set; }
            [NameInMap("IsServiceLinkedRole")]
            [Validation(Required=false)]
            public bool? IsServiceLinkedRole { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
