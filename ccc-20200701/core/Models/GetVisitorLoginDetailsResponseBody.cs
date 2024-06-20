// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetVisitorLoginDetailsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetVisitorLoginDetailsResponseBodyData Data { get; set; }
        public class GetVisitorLoginDetailsResponseBodyData : TeaModel {
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
