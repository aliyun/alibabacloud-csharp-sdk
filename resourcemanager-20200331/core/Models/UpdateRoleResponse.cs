// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class UpdateRoleResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Role")]
        [Validation(Required=true)]
        public UpdateRoleResponseRole Role { get; set; }
        public class UpdateRoleResponseRole : TeaModel {
            [NameInMap("Arn")]
            [Validation(Required=true)]
            public string Arn { get; set; }
            [NameInMap("AssumeRolePolicyDocument")]
            [Validation(Required=true)]
            public string AssumeRolePolicyDocument { get; set; }
            [NameInMap("RolePrincipalName")]
            [Validation(Required=true)]
            public string RolePrincipalName { get; set; }
            [NameInMap("CreateDate")]
            [Validation(Required=true)]
            public string CreateDate { get; set; }
            [NameInMap("UpdateDate")]
            [Validation(Required=true)]
            public string UpdateDate { get; set; }
            [NameInMap("Description")]
            [Validation(Required=true)]
            public string Description { get; set; }
            [NameInMap("RoleId")]
            [Validation(Required=true)]
            public string RoleId { get; set; }
            [NameInMap("RoleName")]
            [Validation(Required=true)]
            public string RoleName { get; set; }
            [NameInMap("MaxSessionDuration")]
            [Validation(Required=true)]
            public long MaxSessionDuration { get; set; }
        };

    }

}
