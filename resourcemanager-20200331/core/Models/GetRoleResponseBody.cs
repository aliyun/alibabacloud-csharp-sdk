// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetRoleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Role")]
        [Validation(Required=false)]
        public GetRoleResponseBodyRole Role { get; set; }
        public class GetRoleResponseBodyRole : TeaModel {
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
            public GetRoleResponseBodyRoleLatestDeletionTask LatestDeletionTask { get; set; }
            public class GetRoleResponseBodyRoleLatestDeletionTask : TeaModel {
                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                [NameInMap("DeletionTaskId")]
                [Validation(Required=false)]
                public string DeletionTaskId { get; set; }

            }

            [NameInMap("MaxSessionDuration")]
            [Validation(Required=false)]
            public long? MaxSessionDuration { get; set; }

            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            [NameInMap("RolePrincipalName")]
            [Validation(Required=false)]
            public string RolePrincipalName { get; set; }

            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

    }

}
