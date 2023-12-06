// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class GetProductVersionPackageRequest : TeaModel {
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

        [NameInMap("packageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        [NameInMap("packageUID")]
        [Validation(Required=false)]
        public string PackageUID { get; set; }

        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("withURL")]
        [Validation(Required=false)]
        public bool? WithURL { get; set; }

    }

}
