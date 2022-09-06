// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateDeviceTunnelResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateDeviceTunnelResponseBodyData Data { get; set; }
        public class CreateDeviceTunnelResponseBodyData : TeaModel {
            [NameInMap("SourceAccessToken")]
            [Validation(Required=false)]
            public string SourceAccessToken { get; set; }

            [NameInMap("SourceURI")]
            [Validation(Required=false)]
            public string SourceURI { get; set; }

            [NameInMap("TunnelId")]
            [Validation(Required=false)]
            public string TunnelId { get; set; }

        }

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
