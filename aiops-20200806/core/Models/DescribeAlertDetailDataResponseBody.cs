// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class DescribeAlertDetailDataResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAlertDetailDataResponseBodyData Data { get; set; }
        public class DescribeAlertDetailDataResponseBodyData : TeaModel {
            [NameInMap("AlertName")]
            [Validation(Required=false)]
            public string AlertName { get; set; }

            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public string BeginTime { get; set; }

            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("CountConvergence")]
            [Validation(Required=false)]
            public int? CountConvergence { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InstanceRegionName")]
            [Validation(Required=false)]
            public string InstanceRegionName { get; set; }

            [NameInMap("MetricExtend")]
            [Validation(Required=false)]
            public string MetricExtend { get; set; }

            [NameInMap("Mttr")]
            [Validation(Required=false)]
            public string Mttr { get; set; }

            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            [NameInMap("metricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            [NameInMap("metricUnit")]
            [Validation(Required=false)]
            public string MetricUnit { get; set; }

            [NameInMap("productCodeKey")]
            [Validation(Required=false)]
            public string ProductCodeKey { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
