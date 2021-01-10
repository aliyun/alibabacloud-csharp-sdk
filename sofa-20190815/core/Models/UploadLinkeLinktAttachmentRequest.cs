// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UploadLinkeLinktAttachmentRequest : TeaModel {
        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        [NameInMap("StoredFilename")]
        [Validation(Required=false)]
        public string StoredFilename { get; set; }

        [NameInMap("TargetResource")]
        [Validation(Required=false)]
        public string TargetResource { get; set; }

        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
