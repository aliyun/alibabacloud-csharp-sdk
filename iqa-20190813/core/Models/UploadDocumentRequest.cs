// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iqa20190813.Models
{
    public class UploadDocumentRequest : TeaModel {
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("DocumentFileUrl")]
        [Validation(Required=false)]
        public string DocumentFileUrl { get; set; }

        [NameInMap("DocumentData")]
        [Validation(Required=false)]
        public string DocumentData { get; set; }

    }

}
