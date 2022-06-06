// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DownloadRecordingsResponseBody : TeaModel {
        [NameInMap("DownloadUrls")]
        [Validation(Required=false)]
        public List<DownloadRecordingsResponseBodyDownloadUrls> DownloadUrls { get; set; }
        public class DownloadRecordingsResponseBodyDownloadUrls : TeaModel {
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
