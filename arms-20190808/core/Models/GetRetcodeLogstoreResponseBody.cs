// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetRetcodeLogstoreResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRetcodeLogstoreResponseBodyData Data { get; set; }
        public class GetRetcodeLogstoreResponseBodyData : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("RetcodeSLSConfig")]
            [Validation(Required=false)]
            public GetRetcodeLogstoreResponseBodyDataRetcodeSLSConfig RetcodeSLSConfig { get; set; }
            public class GetRetcodeLogstoreResponseBodyDataRetcodeSLSConfig : TeaModel {
                [NameInMap("Logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                [NameInMap("Project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
