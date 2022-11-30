// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi_intl20211015.Models
{
    public class ListReceiptResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListReceiptResponseBodyList> List { get; set; }
        public class ListReceiptResponseBodyList : TeaModel {
            [NameInMap("CallFailedCount")]
            [Validation(Required=false)]
            public int? CallFailedCount { get; set; }

            [NameInMap("CallSuccessCount")]
            [Validation(Required=false)]
            public int? CallSuccessCount { get; set; }

            [NameInMap("CallTotalCount")]
            [Validation(Required=false)]
            public int? CallTotalCount { get; set; }

            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ReceiptUrl")]
        [Validation(Required=false)]
        public string ReceiptUrl { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
