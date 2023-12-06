// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class CreateProductVersionPackageRequest : TeaModel {
        [NameInMap("clusterEngineType")]
        [Validation(Required=false)]
        public string ClusterEngineType { get; set; }

        [NameInMap("foundationReferenceUID")]
        [Validation(Required=false)]
        public string FoundationReferenceUID { get; set; }

        [NameInMap("oldFoundationReferenceUID")]
        [Validation(Required=false)]
        public string OldFoundationReferenceUID { get; set; }

        [NameInMap("oldProductVersionUID")]
        [Validation(Required=false)]
        public string OldProductVersionUID { get; set; }

        [NameInMap("packageContentType")]
        [Validation(Required=false)]
        public string PackageContentType { get; set; }

        [NameInMap("packageToolType")]
        [Validation(Required=false)]
        public string PackageToolType { get; set; }

        [NameInMap("packageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

    }

}
