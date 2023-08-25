// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDownloadRecordsResponseBody : TeaModel {
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DescribeDownloadRecordsResponseBodyRecords> Records { get; set; }
        public class DescribeDownloadRecordsResponseBodyRecords : TeaModel {
            [NameInMap("DownloadId")]
            [Validation(Required=false)]
            public long? DownloadId { get; set; }

            [NameInMap("ExceptionMsg")]
            [Validation(Required=false)]
            public string ExceptionMsg { get; set; }

            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
