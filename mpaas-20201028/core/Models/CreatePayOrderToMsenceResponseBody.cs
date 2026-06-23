// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class CreatePayOrderToMsenceResponseBody : TeaModel {
        [NameInMap("MpaasOrderCreateResponse")]
        [Validation(Required=false)]
        public CreatePayOrderToMsenceResponseBodyMpaasOrderCreateResponse MpaasOrderCreateResponse { get; set; }
        public class CreatePayOrderToMsenceResponseBodyMpaasOrderCreateResponse : TeaModel {
            [NameInMap("BizOrderId")]
            [Validation(Required=false)]
            public string BizOrderId { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMsg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
