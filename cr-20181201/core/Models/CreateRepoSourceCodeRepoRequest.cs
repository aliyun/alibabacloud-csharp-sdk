// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateRepoSourceCodeRepoRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        [NameInMap("CodeRepoType")]
        [Validation(Required=false)]
        public string CodeRepoType { get; set; }

        [NameInMap("CodeRepoNamespaceName")]
        [Validation(Required=false)]
        public string CodeRepoNamespaceName { get; set; }

        [NameInMap("CodeRepoName")]
        [Validation(Required=false)]
        public string CodeRepoName { get; set; }

        [NameInMap("AutoBuild")]
        [Validation(Required=false)]
        public bool? AutoBuild { get; set; }

        [NameInMap("OverseaBuild")]
        [Validation(Required=false)]
        public bool? OverseaBuild { get; set; }

        [NameInMap("DisableCacheBuild")]
        [Validation(Required=false)]
        public bool? DisableCacheBuild { get; set; }

    }

}
