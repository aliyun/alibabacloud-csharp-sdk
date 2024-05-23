// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20180807.Models
{
    public class MachineTranslateECommerceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public MachineTranslateECommerceResponseBodyResultCode ResultCode { get; set; }
        public class MachineTranslateECommerceResponseBodyResultCode : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public int? Code { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TranslateText")]
        [Validation(Required=false)]
        public string TranslateText { get; set; }

    }

}
