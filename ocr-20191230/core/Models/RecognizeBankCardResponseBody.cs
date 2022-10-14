// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeBankCardResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeBankCardResponseBodyData Data { get; set; }
        public class RecognizeBankCardResponseBodyData : TeaModel {
            [NameInMap("BankName")]
            [Validation(Required=false)]
            public string BankName { get; set; }

            [NameInMap("CardNumber")]
            [Validation(Required=false)]
            public string CardNumber { get; set; }

            [NameInMap("ValidDate")]
            [Validation(Required=false)]
            public string ValidDate { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
