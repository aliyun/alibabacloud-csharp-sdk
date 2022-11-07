// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateBranchRequest : TeaModel {
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("branchName")]
        [Validation(Required=false)]
        public string BranchName { get; set; }

        [NameInMap("ref")]
        [Validation(Required=false)]
        public string Ref { get; set; }

        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
