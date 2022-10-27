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
                [NameInMap("DiskDevice")]
                [Validation(Required=false)]
                public string DiskDevice { get; set; }

                [NameInMap("Hostname")]
                [Validation(Required=false)]
                public string Hostname { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("MetricData")]
                [Validation(Required=false)]
                public string MetricData { get; set; }

                [NameInMap("NetworkInterface")]
                [Validation(Required=false)]
                public string NetworkInterface { get; set; }

                [NameInMap("Time")]
                [Validation(Required=false)]
                public int? Time { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
