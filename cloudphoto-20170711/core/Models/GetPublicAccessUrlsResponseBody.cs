// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudPhoto20170711.Models
{
    public class GetPublicAccessUrlsResponseBody : TeaModel {
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<GetPublicAccessUrlsResponseBodyResults> Results { get; set; }
        public class GetPublicAccessUrlsResponseBodyResults : TeaModel {
            [NameInMap("PhotoIdStr")]
            [Validation(Required=false)]
            public string PhotoIdStr { get; set; }

            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("PhotoId")]
            [Validation(Required=false)]
            public long? PhotoId { get; set; }

            [NameInMap("AccessUrl")]
            [Validation(Required=false)]
            public string AccessUrl { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
