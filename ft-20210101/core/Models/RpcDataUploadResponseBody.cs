// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ft20210101.Models
{
    public class RpcDataUploadResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, object> Headers { get; set; }

        [NameInMap("params")]
        [Validation(Required=false)]
        public Dictionary<string, object> Params { get; set; }

        [NameInMap("speed")]
        [Validation(Required=false)]
        public string Speed { get; set; }

        [NameInMap("totalBytes")]
        [Validation(Required=false)]
        public long? TotalBytes { get; set; }

        [NameInMap("totalTime")]
        [Validation(Required=false)]
        public long? TotalTime { get; set; }

        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
