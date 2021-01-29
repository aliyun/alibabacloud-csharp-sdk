// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeVATInvoiceRequest : TeaModel {
        [NameInMap("FileURL")]
        [Validation(Required=false)]
        public string FileURL { get; set; }

        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

    }

}
