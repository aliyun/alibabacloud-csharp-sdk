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

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetLoginDetailsResponseBodyData Data { get; set; }
        public class GetLoginDetailsResponseBodyData : TeaModel {
            [NameInMap("AgentServerUrl")]
            [Validation(Required=false)]
            public string AgentServerUrl { get; set; }

            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            [NameInMap("ChatAppId")]
            [Validation(Required=false)]
            public string ChatAppId { get; set; }

            [NameInMap("ChatAppKey")]
            [Validation(Required=false)]
            public string ChatAppKey { get; set; }

            [NameInMap("ChatDeviceId")]
            [Validation(Required=false)]
            public string ChatDeviceId { get; set; }

            [NameInMap("ChatLoginToken")]
            [Validation(Required=false)]
            public string ChatLoginToken { get; set; }

            [NameInMap("ChatServerUrl")]
            [Validation(Required=false)]
            public string ChatServerUrl { get; set; }

            [NameInMap("ChatUserId")]
            [Validation(Required=false)]
            public string ChatUserId { get; set; }

            [NameInMap("DeviceExt")]
            [Validation(Required=false)]
            public string DeviceExt { get; set; }

            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            [NameInMap("DeviceState")]
            [Validation(Required=false)]
            public string DeviceState { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            [NameInMap("Nickname")]
            [Validation(Required=false)]
            public string Nickname { get; set; }

            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

            [NameInMap("Signature2")]
            [Validation(Required=false)]
            public string Signature2 { get; set; }

            [NameInMap("SipServerUrl")]
            [Validation(Required=false)]
            public string SipServerUrl { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserKey")]
            [Validation(Required=false)]
            public string UserKey { get; set; }

            [NameInMap("UserKey2")]
            [Validation(Required=false)]
            public string UserKey2 { get; set; }

            [NameInMap("WorkMode")]
            [Validation(Required=false)]
            public string WorkMode { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
