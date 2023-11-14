// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UploadedHoneyPotFileRequest : TeaModel {
        [NameInMap("FileKey")]
        [Validation(Required=false)]
        public string FileKey { get; set; }

        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        [NameInMap("HoneypotImageName")]
        [Validation(Required=false)]
        public string HoneypotImageName { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("TemplateExtra")]
        [Validation(Required=false)]
        public string TemplateExtra { get; set; }

    }

}
