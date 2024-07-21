// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DownloadCdsFileResponseBody : TeaModel {
        [NameInMap("DownloadFileModel")]
        [Validation(Required=false)]
        public DownloadCdsFileResponseBodyDownloadFileModel DownloadFileModel { get; set; }
        public class DownloadCdsFileResponseBodyDownloadFileModel : TeaModel {
            [NameInMap("DownloadType")]
            [Validation(Required=false)]
            public string DownloadType { get; set; }

            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            [NameInMap("ExpirationSecond")]
            [Validation(Required=false)]
            public string ExpirationSecond { get; set; }

            [NameInMap("ExpirationTime")]
            [Validation(Required=false)]
            public string ExpirationTime { get; set; }

            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("StreamUrl")]
            [Validation(Required=false)]
            public string StreamUrl { get; set; }

        }

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
