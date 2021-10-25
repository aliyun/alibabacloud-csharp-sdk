// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeConnectionCountRecordsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("AccessIpRecords")]
        [Validation(Required=false)]
        public List<DescribeConnectionCountRecordsResponseBodyAccessIpRecords> AccessIpRecords { get; set; }
        public class DescribeConnectionCountRecordsResponseBodyAccessIpRecords : TeaModel {
            [NameInMap("AccessIp")]
            [Validation(Required=false)]
            public string AccessIp { get; set; }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

        }

        [NameInMap("UserRecords")]
        [Validation(Required=false)]
        public List<DescribeConnectionCountRecordsResponseBodyUserRecords> UserRecords { get; set; }
        public class DescribeConnectionCountRecordsResponseBodyUserRecords : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

        }

    }

}
