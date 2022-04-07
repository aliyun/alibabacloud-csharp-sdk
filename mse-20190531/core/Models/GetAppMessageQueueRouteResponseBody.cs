// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetAppMessageQueueRouteResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAppMessageQueueRouteResponseBodyData Data { get; set; }
        public class GetAppMessageQueueRouteResponseBodyData : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
