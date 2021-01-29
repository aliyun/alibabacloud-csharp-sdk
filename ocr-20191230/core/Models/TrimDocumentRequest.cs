// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class TrimDocumentRequest : TeaModel {
        [NameInMap("FileURL")]
        [Validation(Required=false)]
        public string FileURL { get; set; }

        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        [NameInMap("OutputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

    }

}
