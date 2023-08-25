// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateOssSubDirectoryResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateOssSubDirectoryResponseBodyData Data { get; set; }
        public class CreateOssSubDirectoryResponseBodyData : TeaModel {
            [NameInMap("ClientCRC")]
            [Validation(Required=false)]
            public long? ClientCRC { get; set; }

            [NameInMap("ETag")]
            [Validation(Required=false)]
            public string ETag { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("ServerCRC")]
            [Validation(Required=false)]
            public long? ServerCRC { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

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
