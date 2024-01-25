// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MindLive20210301.Models
{
    public class RequestPasterResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<RequestPasterResponseBodyData> Data { get; set; }
        public class RequestPasterResponseBodyData : TeaModel {
            [NameInMap("Configs")]
            [Validation(Required=false)]
            public Dictionary<string, object> Configs { get; set; }

            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            [NameInMap("ResourceUuid")]
            [Validation(Required=false)]
            public string ResourceUuid { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
