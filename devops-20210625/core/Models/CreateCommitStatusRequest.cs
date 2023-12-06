// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateCommitStatusRequest : TeaModel {
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("context")]
        [Validation(Required=false)]
        public string Context { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("targetUrl")]
        [Validation(Required=false)]
        public string TargetUrl { get; set; }

        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("repositoryIdentity")]
        [Validation(Required=false)]
        public string RepositoryIdentity { get; set; }

        [NameInMap("sha")]
        [Validation(Required=false)]
        public string Sha { get; set; }

    }

}
