// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ExecAKSBuildRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("DockerSecurityBenchmark")]
        [Validation(Required=false)]
        public bool? DockerSecurityBenchmark { get; set; }

        [NameInMap("ScmBranch")]
        [Validation(Required=false)]
        public string ScmBranch { get; set; }

        [NameInMap("ScmUrl")]
        [Validation(Required=false)]
        public string ScmUrl { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

        [NameInMap("BuildArgs")]
        [Validation(Required=false)]
        public List<ExecAKSBuildRequestBuildArgs> BuildArgs { get; set; }
        public class ExecAKSBuildRequestBuildArgs : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
