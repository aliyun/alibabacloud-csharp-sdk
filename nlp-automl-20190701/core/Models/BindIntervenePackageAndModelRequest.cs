// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlp_automl20190701.Models
{
    public class BindIntervenePackageAndModelRequest : TeaModel {
        [NameInMap("PackageId")]
        [Validation(Required=true)]
        public long PackageId { get; set; }

        [NameInMap("ModelId")]
        [Validation(Required=true)]
        public long ModelId { get; set; }

        [NameInMap("ModelVersion")]
        [Validation(Required=false)]
        public string ModelVersion { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=true)]
        public long ProjectId { get; set; }

    }

}
