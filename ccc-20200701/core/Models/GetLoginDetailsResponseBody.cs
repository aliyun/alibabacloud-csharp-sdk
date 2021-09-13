// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetLoginDetailsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetLoginDetailsResponseBodyData Data { get; set; }
        public class GetLoginDetailsResponseBodyData : TeaModel {
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }
            [NameInMap("SipServerUrl")]
            [Validation(Required=false)]
            public string SipServerUrl { get; set; }
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }
            [NameInMap("AgentServerUrl")]
            [Validation(Required=false)]
            public string AgentServerUrl { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
            [NameInMap("UserKey")]
            [Validation(Required=false)]
            public string UserKey { get; set; }
        };

    }

}
