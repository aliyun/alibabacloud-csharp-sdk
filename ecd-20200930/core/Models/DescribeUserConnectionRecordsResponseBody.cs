// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeUserConnectionRecordsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ConnectionRecords")]
        [Validation(Required=false)]
        public List<DescribeUserConnectionRecordsResponseBodyConnectionRecords> ConnectionRecords { get; set; }
        public class DescribeUserConnectionRecordsResponseBodyConnectionRecords : TeaModel {
            [NameInMap("ConnectionRecordId")]
            [Validation(Required=false)]
            public string ConnectionRecordId { get; set; }

            [NameInMap("ConnectStartTime")]
            [Validation(Required=false)]
            public string ConnectStartTime { get; set; }

            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            [NameInMap("ConnectDuration")]
            [Validation(Required=false)]
            public string ConnectDuration { get; set; }

            [NameInMap("ConnectEndTime")]
            [Validation(Required=false)]
            public string ConnectEndTime { get; set; }

            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

        }

    }

}
