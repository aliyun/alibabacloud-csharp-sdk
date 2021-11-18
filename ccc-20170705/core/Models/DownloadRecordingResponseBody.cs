// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class DownloadRecordingResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("MediaDownloadParam")]
        [Validation(Required=false)]
        public DownloadRecordingResponseBodyMediaDownloadParam MediaDownloadParam { get; set; }
        public class DownloadRecordingResponseBodyMediaDownloadParam : TeaModel {
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }
            [NameInMap("SignatureUrl")]
            [Validation(Required=false)]
            public string SignatureUrl { get; set; }
        };

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
