// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetCloudMetricLogsResponseBody : TeaModel {
        [NameInMap("MetricLogs")]
        [Validation(Required=false)]
        public GetCloudMetricLogsResponseBodyMetricLogs MetricLogs { get; set; }
        public class GetCloudMetricLogsResponseBodyMetricLogs : TeaModel {
            [NameInMap("MetricLog")]
            [Validation(Required=false)]
            public List<GetCloudMetricLogsResponseBodyMetricLogsMetricLog> MetricLog { get; set; }
            public class GetCloudMetricLogsResponseBodyMetricLogsMetricLog : TeaModel {
                public string DiskDevice { get; set; }
                public string Hostname { get; set; }
                public string InstanceId { get; set; }
                public string MetricData { get; set; }
                public string NetworkInterface { get; set; }
                public int? Time { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
