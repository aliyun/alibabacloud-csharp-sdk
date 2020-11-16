// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeRecordResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("RecordId")]
        [Validation(Required=true)]
        public string RecordId { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=true)]
        public string AppId { get; set; }

        [NameInMap("BoardId")]
        [Validation(Required=true)]
        public int? BoardId { get; set; }

        [NameInMap("RecordStartTime")]
        [Validation(Required=true)]
        public long RecordStartTime { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=true)]
        public long StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=true)]
        public long EndTime { get; set; }

        [NameInMap("State")]
        [Validation(Required=true)]
        public int? State { get; set; }

        [NameInMap("OssPath")]
        [Validation(Required=true)]
        public string OssPath { get; set; }

        [NameInMap("OssBucket")]
        [Validation(Required=true)]
        public string OssBucket { get; set; }

        [NameInMap("OssEndpoint")]
        [Validation(Required=true)]
        public string OssEndpoint { get; set; }

    }

}
