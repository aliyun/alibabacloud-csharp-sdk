// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MindLive20210301.Models
{
    public class RequestBackgroundResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RequestBackgroundResponseBodyData Data { get; set; }
        public class RequestBackgroundResponseBodyData : TeaModel {
            [NameInMap("BgConfig")]
            [Validation(Required=false)]
            public Dictionary<string, object> BgConfig { get; set; }

            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("Open")]
            [Validation(Required=false)]
            public bool? Open { get; set; }

            [NameInMap("ResourceUuid")]
            [Validation(Required=false)]
            public string ResourceUuid { get; set; }

            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

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
