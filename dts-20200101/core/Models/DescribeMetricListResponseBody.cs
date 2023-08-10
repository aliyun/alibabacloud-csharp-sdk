// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeMetricListResponseBody : TeaModel {
        /// <summary>
        /// The error code returned by the backend service. The number is incremented.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The monitoring statistics.
        /// </summary>
        [NameInMap("DataPoints")]
        [Validation(Required=false)]
        public List<DescribeMetricListResponseBodyDataPoints> DataPoints { get; set; }
        public class DescribeMetricListResponseBodyDataPoints : TeaModel {
            /// <summary>
            /// The statistical value.
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public float? Statistics { get; set; }

            /// <summary>
            /// The timestamp of the record. Unit: milliseconds.
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// The dynamic part in the error message. This parameter is used to replace the %s variable in the **ErrMessage** parameter.
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// The HTTP status code returned for an exception.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// *   **InternetOut**: the outbound traffic over the Internet. Unit: byte.
        /// *   **diskusage_utilization**: the disk usage.
        /// *   **IntranetInRate**: the inbound traffic over the internal network. Unit: byte.
        /// *   **InternetIn**: the inbound traffic from the Internet. Unit: byte.
        /// *   **cpu_total**: the CPU utilization.
        /// *   **memory_usedutilization**: the memory usage.
        /// *   **IntranetOutRate**: the outbound traffic over the internal network. Unit: byte.
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// Indicates whether the metrics of the cluster or a node are queried. Valid values:
        /// 
        /// *   **CLUSTER**: The metrics of the cluster are queried.
        /// *   **NODE**: The metrics of a node are queried.
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// The monitored object.
        /// 
        /// *   If the **MetricType** parameter is set to **NODE**, the value of this parameter is the ID of the node that is monitored.****
        /// *   If the **MetricType** parameter is set to **CLUSTER**, the value of this parameter is the ID of the dedicated cluster. You can obtain the ID by calling the ListDedicatedCluster operation.
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public string Param { get; set; }

        /// <summary>
        /// The monitoring interval. Unit: seconds. Minimum value: 15.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
