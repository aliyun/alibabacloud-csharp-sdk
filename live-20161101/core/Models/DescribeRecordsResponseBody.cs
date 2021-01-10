// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeRecordsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DescribeRecordsResponseBodyRecords> Records { get; set; }
        public class DescribeRecordsResponseBodyRecords : TeaModel {
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }

            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("BoardId")]
            [Validation(Required=false)]
            public int? BoardId { get; set; }

            [NameInMap("RecordStartTime")]
            [Validation(Required=false)]
            public long? RecordStartTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public int? State { get; set; }

            [NameInMap("OssPath")]
            [Validation(Required=false)]
            public string OssPath { get; set; }

            [NameInMap("OssBucket")]
            [Validation(Required=false)]
            public string OssBucket { get; set; }

            [NameInMap("OssEndpoint")]
            [Validation(Required=false)]
            public string OssEndpoint { get; set; }

        }

    }

}
