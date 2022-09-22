// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeOrderAutoRebootTimeResponseBody : TeaModel {
        [NameInMap("DescribeOrderAutoRebootTimeInfo")]
        [Validation(Required=false)]
        public DescribeOrderAutoRebootTimeResponseBodyDescribeOrderAutoRebootTimeInfo DescribeOrderAutoRebootTimeInfo { get; set; }
        public class DescribeOrderAutoRebootTimeResponseBodyDescribeOrderAutoRebootTimeInfo : TeaModel {
            [NameInMap("AutoRebootTime")]
            [Validation(Required=false)]
            public string AutoRebootTime { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
