// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeVATInvoiceAdvanceRequest : TeaModel {
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        [NameInMap("FileURL")]
        [Validation(Required=false)]
        public Stream FileURLObject { get; set; }

    }

}
