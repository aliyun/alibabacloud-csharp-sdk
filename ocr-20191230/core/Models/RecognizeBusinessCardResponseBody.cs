// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeBusinessCardResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeBusinessCardResponseBodyData Data { get; set; }
        public class RecognizeBusinessCardResponseBodyData : TeaModel {
            [NameInMap("Companies")]
            [Validation(Required=false)]
            public List<string> Companies { get; set; }
            [NameInMap("Titles")]
            [Validation(Required=false)]
            public List<string> Titles { get; set; }
            [NameInMap("Emails")]
            [Validation(Required=false)]
            public List<string> Emails { get; set; }
            [NameInMap("Departments")]
            [Validation(Required=false)]
            public List<string> Departments { get; set; }
            [NameInMap("OfficePhoneNumbers")]
            [Validation(Required=false)]
            public List<string> OfficePhoneNumbers { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("CellPhoneNumbers")]
            [Validation(Required=false)]
            public List<string> CellPhoneNumbers { get; set; }
            [NameInMap("Addresses")]
            [Validation(Required=false)]
            public List<string> Addresses { get; set; }
        };

    }

}
