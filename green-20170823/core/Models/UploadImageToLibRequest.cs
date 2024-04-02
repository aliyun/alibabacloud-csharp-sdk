// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class UploadImageToLibRequest : TeaModel {
        [NameInMap("ImageLibId")]
        [Validation(Required=false)]
        public int? ImageLibId { get; set; }

        [NameInMap("Images")]
        [Validation(Required=false)]
        public string Images { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("Urls")]
        [Validation(Required=false)]
        public string Urls { get; set; }

    }

}
