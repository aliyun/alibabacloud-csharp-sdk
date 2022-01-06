// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetDeviceTunnelShareStatusResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDeviceTunnelShareStatusResponseBodyData Data { get; set; }
        public class GetDeviceTunnelShareStatusResponseBodyData : TeaModel {
            [NameInMap("GmtOpened")]
            [Validation(Required=false)]
            public long? GmtOpened { get; set; }
            [NameInMap("IsOpen")]
            [Validation(Required=false)]
            public bool? IsOpen { get; set; }
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }
            [NameInMap("ShareId")]
            [Validation(Required=false)]
            public string ShareId { get; set; }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
