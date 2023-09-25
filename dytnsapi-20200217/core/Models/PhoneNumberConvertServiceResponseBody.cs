// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class PhoneNumberConvertServiceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<PhoneNumberConvertServiceResponseBodyData> Data { get; set; }
        public class PhoneNumberConvertServiceResponseBodyData : TeaModel {
            [NameInMap("ConverResult")]
            [Validation(Required=false)]
            public bool? ConverResult { get; set; }

            [NameInMap("Number")]
            [Validation(Required=false)]
            public string Number { get; set; }

            [NameInMap("NumberMd5")]
            [Validation(Required=false)]
            public string NumberMd5 { get; set; }

            [NameInMap("NumberSha256")]
            [Validation(Required=false)]
            public string NumberSha256 { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
