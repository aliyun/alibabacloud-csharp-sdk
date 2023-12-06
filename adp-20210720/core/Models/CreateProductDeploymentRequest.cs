// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class CreateProductDeploymentRequest : TeaModel {
        [NameInMap("environmentUID")]
        [Validation(Required=false)]
        public string EnvironmentUID { get; set; }

        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("oldProductVersionUID")]
        [Validation(Required=false)]
        public string OldProductVersionUID { get; set; }

        [NameInMap("packageConfig")]
        [Validation(Required=false)]
        public string PackageConfig { get; set; }

        [NameInMap("packageUID")]
        [Validation(Required=false)]
        public string PackageUID { get; set; }

        [NameInMap("productVersionUID")]
        [Validation(Required=false)]
        public string ProductVersionUID { get; set; }

        [NameInMap("timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

    }

}
