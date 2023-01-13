// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetDeviceTunnelShareStatusResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetDeviceTunnelShareStatusResponseData Data { get; set; }
        public class GetDeviceTunnelShareStatusResponseData : TeaModel {
            [NameInMap("GmtOpened")]
            [Validation(Required=true)]
            public long? GmtOpened { get; set; }

            [NameInMap("IsOpen")]
            [Validation(Required=true)]
            public bool? IsOpen { get; set; }

            [NameInMap("Password")]
            [Validation(Required=true)]
            public string Password { get; set; }

            [NameInMap("ShareId")]
            [Validation(Required=true)]
            public string ShareId { get; set; }

        }

    }

}
