// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetUploadDetailsResponseBody : TeaModel {
        [NameInMap("ForbiddenMediaIds")]
        [Validation(Required=false)]
        public List<string> ForbiddenMediaIds { get; set; }

        [NameInMap("NonExistMediaIds")]
        [Validation(Required=false)]
        public List<string> NonExistMediaIds { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UploadDetails")]
        [Validation(Required=false)]
        public List<GetUploadDetailsResponseBodyUploadDetails> UploadDetails { get; set; }
        public class GetUploadDetailsResponseBodyUploadDetails : TeaModel {
            [NameInMap("CompletionTime")]
            [Validation(Required=false)]
            public string CompletionTime { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("DeviceModel")]
            [Validation(Required=false)]
            public string DeviceModel { get; set; }

            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("UploadIP")]
            [Validation(Required=false)]
            public string UploadIP { get; set; }

            [NameInMap("UploadRatio")]
            [Validation(Required=false)]
            public float? UploadRatio { get; set; }

            [NameInMap("UploadSize")]
            [Validation(Required=false)]
            public long? UploadSize { get; set; }

            [NameInMap("UploadSource")]
            [Validation(Required=false)]
            public string UploadSource { get; set; }

            [NameInMap("UploadStatus")]
            [Validation(Required=false)]
            public string UploadStatus { get; set; }

        }

    }

}
