// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ServiceLinkedRole : TeaModel {
        [NameInMap("arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        [NameInMap("assumeRolePolicyDocument")]
        [Validation(Required=false)]
        public string AssumeRolePolicyDocument { get; set; }

        [NameInMap("createDate")]
        [Validation(Required=false)]
        public string CreateDate { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("isServiceLinkedRole")]
        [Validation(Required=false)]
        public bool? IsServiceLinkedRole { get; set; }

        [NameInMap("roleId")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

        [NameInMap("roleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        [NameInMap("rolePrincipalName")]
        [Validation(Required=false)]
        public string RolePrincipalName { get; set; }

    }

}
