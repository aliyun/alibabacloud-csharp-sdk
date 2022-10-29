// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateFileRequest : TeaModel {
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("branchName")]
        [Validation(Required=false)]
        public string BranchName { get; set; }

        [NameInMap("commitMessage")]
        [Validation(Required=false)]
        public string CommitMessage { get; set; }

        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("encoding")]
        [Validation(Required=false)]
        public string Encoding { get; set; }

        [NameInMap("newPath")]
        [Validation(Required=false)]
        public string NewPath { get; set; }

        [NameInMap("oldPath")]
        [Validation(Required=false)]
        public string OldPath { get; set; }

        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
