// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class ExportAnnotationsRequest : TeaModel {
        [NameInMap("OssPath")]
        [Validation(Required=false)]
        public string OssPath { get; set; }

        [NameInMap("RegisterDataset")]
        [Validation(Required=false)]
        public string RegisterDataset { get; set; }

        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

    }

}
