// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypls20170830.Models
{
    public class ApplyArInvoiceWithSourceResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("ReturnValue")]
        [Validation(Required=false)]
        public ApplyArInvoiceWithSourceResponseBodyReturnValue ReturnValue { get; set; }
        public class ApplyArInvoiceWithSourceResponseBodyReturnValue : TeaModel {
            [NameInMap("EncryptProps")]
            [Validation(Required=false)]
            public Dictionary<string, string> EncryptProps { get; set; }

            [NameInMap("OuterSystemEncryptStr")]
            [Validation(Required=false)]
            public string OuterSystemEncryptStr { get; set; }

            [NameInMap("OuterSystemSignStr")]
            [Validation(Required=false)]
            public string OuterSystemSignStr { get; set; }

            [NameInMap("Sign")]
            [Validation(Required=false)]
            public string Sign { get; set; }

        }

    }

}
