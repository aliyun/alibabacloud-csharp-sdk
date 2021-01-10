// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DeleteAKSHelmRepoRequest : TeaModel {
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
