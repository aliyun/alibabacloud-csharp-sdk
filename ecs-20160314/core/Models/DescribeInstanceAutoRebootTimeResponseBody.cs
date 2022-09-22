// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeInstanceAutoRebootTimeResponseBody : TeaModel {
        [NameInMap("AutoRebootInfos")]
        [Validation(Required=false)]
        public DescribeInstanceAutoRebootTimeResponseBodyAutoRebootInfos AutoRebootInfos { get; set; }
        public class DescribeInstanceAutoRebootTimeResponseBodyAutoRebootInfos : TeaModel {
            [NameInMap("AutoRebootInfo")]
            [Validation(Required=false)]
            public List<DescribeInstanceAutoRebootTimeResponseBodyAutoRebootInfosAutoRebootInfo> AutoRebootInfo { get; set; }
            public class DescribeInstanceAutoRebootTimeResponseBodyAutoRebootInfosAutoRebootInfo : TeaModel {
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("LimitRebootTime")]
                [Validation(Required=false)]
                public string LimitRebootTime { get; set; }

                [NameInMap("OrderType")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

                [NameInMap("RebootTime")]
                [Validation(Required=false)]
                public string RebootTime { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
