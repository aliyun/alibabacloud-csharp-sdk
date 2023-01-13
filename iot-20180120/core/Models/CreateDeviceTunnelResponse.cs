// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateDeviceTunnelResponse : TeaModel {
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
        public CreateDeviceTunnelResponseData Data { get; set; }
        public class CreateDeviceTunnelResponseData : TeaModel {
            [NameInMap("SourceAccessToken")]
            [Validation(Required=true)]
            public string SourceAccessToken { get; set; }

            [NameInMap("SourceURI")]
            [Validation(Required=true)]
            public string SourceURI { get; set; }

            [NameInMap("TunnelId")]
            [Validation(Required=true)]
            public string TunnelId { get; set; }

        }

    }

}
