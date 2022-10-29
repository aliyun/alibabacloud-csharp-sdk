// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetFileLastCommitRequest : TeaModel {
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("filepath")]
        [Validation(Required=false)]
        public string Filepath { get; set; }

        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("sha")]
        [Validation(Required=false)]
        public string Sha { get; set; }

        [NameInMap("showSignature")]
        [Validation(Required=false)]
        public bool? ShowSignature { get; set; }

    }

}
