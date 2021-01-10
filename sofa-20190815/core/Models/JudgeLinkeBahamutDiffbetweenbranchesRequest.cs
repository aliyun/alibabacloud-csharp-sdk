// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class JudgeLinkeBahamutDiffbetweenbranchesRequest : TeaModel {
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("MrSourceBranch")]
        [Validation(Required=false)]
        public string MrSourceBranch { get; set; }

        [NameInMap("MrTargetBranch")]
        [Validation(Required=false)]
        public string MrTargetBranch { get; set; }

        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        [NameInMap("TenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

    }

}
