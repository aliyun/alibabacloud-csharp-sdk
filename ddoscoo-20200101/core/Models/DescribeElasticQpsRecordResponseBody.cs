// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeElasticQpsRecordResponseBody : TeaModel {
        /// <summary>
        /// The QPS information about the instance.
        /// </summary>
        [NameInMap("ElasticQpsList")]
        [Validation(Required=false)]
        public List<DescribeElasticQpsRecordResponseBodyElasticQpsList> ElasticQpsList { get; set; }
        public class DescribeElasticQpsRecordResponseBodyElasticQpsList : TeaModel {
            /// <summary>
            /// The timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("Date")]
            [Validation(Required=false)]
            public long? Date { get; set; }

            /// <summary>
            /// The ID of the Anti-DDoS Proxy instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The IP address of the Anti-DDoS Proxy instance.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The burstable QPS value. A value of 0 indicates that the burstable QPS feature is not enabled.
            /// </summary>
            [NameInMap("OpsElasticQps")]
            [Validation(Required=false)]
            public long? OpsElasticQps { get; set; }

            /// <summary>
            /// The service QPS (active).
            /// </summary>
            [NameInMap("OpsQps")]
            [Validation(Required=false)]
            public long? OpsQps { get; set; }

            /// <summary>
            /// The service QPS (purchased).
            /// </summary>
            [NameInMap("OriginQps")]
            [Validation(Required=false)]
            public long? OriginQps { get; set; }

            /// <summary>
            /// The daily peak 95th percentile QPS.
            /// </summary>
            [NameInMap("Qps")]
            [Validation(Required=false)]
            public long? Qps { get; set; }

            /// <summary>
            /// The daily peak traffic.
            /// </summary>
            [NameInMap("QpsPeak")]
            [Validation(Required=false)]
            public long? QpsPeak { get; set; }

            /// <summary>
            /// Indicates whether the instance has expired or is released. Valid values:
            /// 
            /// *   **1**: The instance runs as expected.
            /// *   **2**: The instance has expired.
            /// *   **4**: The instance is released.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

        }

        /// <summary>
        /// The request ID, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
