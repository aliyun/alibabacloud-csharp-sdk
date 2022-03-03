// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeStructuredTaxiInvoicesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeStructuredTaxiInvoicesResponseBodyData Data { get; set; }
        public class RecognizeStructuredTaxiInvoicesResponseBodyData : TeaModel {
            [NameInMap("Addresses")]
            [Validation(Required=false)]
            public List<string> Addresses { get; set; }
            [NameInMap("CellPhoneNumbers")]
            [Validation(Required=false)]
            public List<string> CellPhoneNumbers { get; set; }
            [NameInMap("Companies")]
            [Validation(Required=false)]
            public List<string> Companies { get; set; }
            [NameInMap("Departments")]
            [Validation(Required=false)]
            public List<string> Departments { get; set; }
            [NameInMap("Emails")]
            [Validation(Required=false)]
            public List<string> Emails { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("OfficePhoneNumbers")]
            [Validation(Required=false)]
            public List<string> OfficePhoneNumbers { get; set; }
            [NameInMap("Titles")]
            [Validation(Required=false)]
            public List<string> Titles { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
