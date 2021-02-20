// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeBlackholeStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("BlackholeStatus")]
        [Validation(Required=false)]
        public List<DescribeBlackholeStatusResponseBodyBlackholeStatus> BlackholeStatus { get; set; }
        public class DescribeBlackholeStatusResponseBodyBlackholeStatus : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("BlackStatus")]
            [Validation(Required=false)]
            public string BlackStatus { get; set; }

        }

    }

}
