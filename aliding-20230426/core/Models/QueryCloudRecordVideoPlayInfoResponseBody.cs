// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryCloudRecordVideoPlayInfoResponseBody : TeaModel {
        [NameInMap("duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        [NameInMap("fileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        [NameInMap("mp4FileUrl")]
        [Validation(Required=false)]
        public string Mp4FileUrl { get; set; }

        [NameInMap("playUrl")]
        [Validation(Required=false)]
        public string PlayUrl { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

    }

}
