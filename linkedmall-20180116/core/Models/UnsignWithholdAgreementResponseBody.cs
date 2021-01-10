// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class UnsignWithholdAgreementResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WithholdSignResponse")]
        [Validation(Required=false)]
        public UnsignWithholdAgreementResponseBodyWithholdSignResponse WithholdSignResponse { get; set; }
        public class UnsignWithholdAgreementResponseBodyWithholdSignResponse : TeaModel {
            [NameInMap("OutRequestNo")]
            [Validation(Required=false)]
            public string OutRequestNo { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
