// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeKvUsageDataResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("KvUsageData")]
        [Validation(Required=false)]
        public List<DescribeKvUsageDataResponseBodyKvUsageData> KvUsageData { get; set; }
        public class DescribeKvUsageDataResponseBodyKvUsageData : TeaModel {
            [NameInMap("Acc")]
            [Validation(Required=false)]
            public long? Acc { get; set; }

            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
