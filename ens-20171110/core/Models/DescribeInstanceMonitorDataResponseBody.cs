// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeInstanceMonitorDataResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("MonitorData")]
        [Validation(Required=false)]
        public DescribeInstanceMonitorDataResponseBodyMonitorData MonitorData { get; set; }
        public class DescribeInstanceMonitorDataResponseBodyMonitorData : TeaModel {
            [NameInMap("InstanceMonitorData")]
            [Validation(Required=false)]
            public List<DescribeInstanceMonitorDataResponseBodyMonitorDataInstanceMonitorData> InstanceMonitorData { get; set; }
            public class DescribeInstanceMonitorDataResponseBodyMonitorDataInstanceMonitorData : TeaModel {
                [NameInMap("CPU")]
                [Validation(Required=false)]
                public string CPU { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
