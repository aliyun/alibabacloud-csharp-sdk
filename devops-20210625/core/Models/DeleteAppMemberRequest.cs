// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class DeleteAppMemberRequest : TeaModel {
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("subjectId")]
        [Validation(Required=false)]
        public string SubjectId { get; set; }

        [NameInMap("subjectType")]
        [Validation(Required=false)]
        public string SubjectType { get; set; }

    }

}
