// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryCloudRecordVideoResponseBody : TeaModel {
        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("videoList")]
        [Validation(Required=false)]
        public List<QueryCloudRecordVideoResponseBodyVideoList> VideoList { get; set; }
        public class QueryCloudRecordVideoResponseBodyVideoList : TeaModel {
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }

            [NameInMap("RecordType")]
            [Validation(Required=false)]
            public long? RecordType { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
