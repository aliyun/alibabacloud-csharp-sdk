// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class GetMqttTokenResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMqttTokenResponseBodyData Data { get; set; }
        public class GetMqttTokenResponseBodyData : TeaModel {
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("P2pTopic")]
            [Validation(Required=false)]
            public string P2pTopic { get; set; }
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
