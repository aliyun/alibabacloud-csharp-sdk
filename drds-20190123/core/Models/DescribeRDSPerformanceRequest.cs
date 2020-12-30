// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeRDSPerformanceRequest : TeaModel {
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("RdsInstanceId")]
        [Validation(Required=false)]
        public string RdsInstanceId { get; set; }

        [NameInMap("Keys")]
        [Validation(Required=false)]
        public string Keys { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("DbInstType")]
        [Validation(Required=false)]
        public string DbInstType { get; set; }

    }

}
