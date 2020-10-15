// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeInstanceMonitorDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("MonitorData")]
        [Validation(Required=true)]
        public DescribeInstanceMonitorDataResponseMonitorData MonitorData { get; set; }
        public class DescribeInstanceMonitorDataResponseMonitorData : TeaModel {
            [NameInMap("InstanceMonitorData")]
            [Validation(Required=true)]
            public List<DescribeInstanceMonitorDataResponseMonitorDataInstanceMonitorData> InstanceMonitorData { get; set; }
            public class DescribeInstanceMonitorDataResponseMonitorDataInstanceMonitorData : TeaModel {
                public string InstanceId { get; set; }
                public string Memory { get; set; }
                public string CPU { get; set; }
            }
        };

    }

}
