// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDataReDistributeInfoResponseBody : TeaModel {
        [NameInMap("DataReDistributeInfo")]
        [Validation(Required=false)]
        public DescribeDataReDistributeInfoResponseBodyDataReDistributeInfo DataReDistributeInfo { get; set; }
        public class DescribeDataReDistributeInfoResponseBodyDataReDistributeInfo : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public long? Progress { get; set; }

            [NameInMap("RemainTime")]
            [Validation(Required=false)]
            public string RemainTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
