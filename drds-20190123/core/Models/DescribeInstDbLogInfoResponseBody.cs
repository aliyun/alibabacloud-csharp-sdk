// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeInstDbLogInfoResponseBody : TeaModel {
        [NameInMap("LogTimeRange")]
        [Validation(Required=false)]
        public DescribeInstDbLogInfoResponseBodyLogTimeRange LogTimeRange { get; set; }
        public class DescribeInstDbLogInfoResponseBodyLogTimeRange : TeaModel {
            [NameInMap("SupportLatestTime")]
            [Validation(Required=false)]
            public long? SupportLatestTime { get; set; }
            [NameInMap("SupportOldestTime")]
            [Validation(Required=false)]
            public long? SupportOldestTime { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
