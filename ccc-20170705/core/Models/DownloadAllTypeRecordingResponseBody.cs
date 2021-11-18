// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class DownloadAllTypeRecordingResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("MediaDownloadParamList")]
        [Validation(Required=false)]
        public DownloadAllTypeRecordingResponseBodyMediaDownloadParamList MediaDownloadParamList { get; set; }
        public class DownloadAllTypeRecordingResponseBodyMediaDownloadParamList : TeaModel {
            [NameInMap("MediaDownloadParam")]
            [Validation(Required=false)]
            public List<DownloadAllTypeRecordingResponseBodyMediaDownloadParamListMediaDownloadParam> MediaDownloadParam { get; set; }
            public class DownloadAllTypeRecordingResponseBodyMediaDownloadParamListMediaDownloadParam : TeaModel {
                public string FileName { get; set; }
                public string SignatureUrl { get; set; }
            }
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
