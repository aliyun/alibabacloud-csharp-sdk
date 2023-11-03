// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCustinsResourceInfoResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeCustinsResourceInfoResponseBodyData> Data { get; set; }
        public class DescribeCustinsResourceInfoResponseBodyData : TeaModel {
            /// <summary>
            /// Cpu adjustment deadline.
            /// </summary>
            [NameInMap("CpuAdjustDeadline")]
            [Validation(Required=false)]
            public string CpuAdjustDeadline { get; set; }

            /// <summary>
            /// Cpu adjustable maximum ratio.
            /// </summary>
            [NameInMap("CpuAdjustableMaxRatio")]
            [Validation(Required=false)]
            public string CpuAdjustableMaxRatio { get; set; }

            /// <summary>
            /// Maximum CPU usage.
            /// </summary>
            [NameInMap("CpuAdjustableMaxValue")]
            [Validation(Required=false)]
            public string CpuAdjustableMaxValue { get; set; }

            /// <summary>
            /// CPU usage rate.
            /// </summary>
            [NameInMap("CpuIncreaseRatio")]
            [Validation(Required=false)]
            public string CpuIncreaseRatio { get; set; }

            /// <summary>
            /// CPU usage rate.
            /// </summary>
            [NameInMap("CpuIncreaseRatioValue")]
            [Validation(Required=false)]
            public string CpuIncreaseRatioValue { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// The maximum number of IO requests per second.
            /// </summary>
            [NameInMap("IopsAdjustableMaxValue")]
            [Validation(Required=false)]
            public string IopsAdjustableMaxValue { get; set; }

            /// <summary>
            /// Maximum Connection Adjustment Deadline
            /// </summary>
            [NameInMap("MaxConnAdjustDeadline")]
            [Validation(Required=false)]
            public string MaxConnAdjustDeadline { get; set; }

            /// <summary>
            /// Maximum number of concurrent connections.
            /// </summary>
            [NameInMap("MaxConnAdjustableMaxValue")]
            [Validation(Required=false)]
            public string MaxConnAdjustableMaxValue { get; set; }

            /// <summary>
            /// Maximum number of concurrent connections.
            /// </summary>
            [NameInMap("MaxConnIncreaseRatio")]
            [Validation(Required=false)]
            public string MaxConnIncreaseRatio { get; set; }

            /// <summary>
            /// Maximum number of concurrent connections.
            /// </summary>
            [NameInMap("MaxConnIncreaseRatioValue")]
            [Validation(Required=false)]
            public string MaxConnIncreaseRatioValue { get; set; }

            /// <summary>
            /// Maximum iops adjustment deadline.
            /// </summary>
            [NameInMap("MaxIopsAdjustDeadline")]
            [Validation(Required=false)]
            public string MaxIopsAdjustDeadline { get; set; }

            /// <summary>
            /// The maximum number of IO requests per second.
            /// </summary>
            [NameInMap("MaxIopsIncreaseRatio")]
            [Validation(Required=false)]
            public string MaxIopsIncreaseRatio { get; set; }

            /// <summary>
            /// The maximum number of IO requests per second.
            /// </summary>
            [NameInMap("MaxIopsIncreaseRatioValue")]
            [Validation(Required=false)]
            public string MaxIopsIncreaseRatioValue { get; set; }

            /// <summary>
            /// Memory adjustable maximum ratio.
            /// </summary>
            [NameInMap("MemAdjustableMaxRatio")]
            [Validation(Required=false)]
            public string MemAdjustableMaxRatio { get; set; }

            /// <summary>
            /// The maximum value of the resource to be evaluated.
            /// </summary>
            [NameInMap("MemAdjustableMaxValue")]
            [Validation(Required=false)]
            public string MemAdjustableMaxValue { get; set; }

            /// <summary>
            /// Memory adjustment deadline.
            /// </summary>
            [NameInMap("MemoryAdjustDeadline")]
            [Validation(Required=false)]
            public string MemoryAdjustDeadline { get; set; }

            /// <summary>
            /// Memory creation time.
            /// </summary>
            [NameInMap("MemoryIncreaseRatio")]
            [Validation(Required=false)]
            public string MemoryIncreaseRatio { get; set; }

            /// <summary>
            /// Memory usage.
            /// </summary>
            [NameInMap("MemoryIncreaseRatioValue")]
            [Validation(Required=false)]
            public string MemoryIncreaseRatioValue { get; set; }

            /// <summary>
            /// Number of instance CPUs.
            /// </summary>
            [NameInMap("OriginCpu")]
            [Validation(Required=false)]
            public string OriginCpu { get; set; }

            /// <summary>
            /// Maximum number of concurrent connections.
            /// </summary>
            [NameInMap("OriginMaxConn")]
            [Validation(Required=false)]
            public string OriginMaxConn { get; set; }

            /// <summary>
            /// The maximum number of IO requests per second.
            /// </summary>
            [NameInMap("OriginMaxIops")]
            [Validation(Required=false)]
            public string OriginMaxIops { get; set; }

            /// <summary>
            /// Actual memory used.
            /// </summary>
            [NameInMap("OriginMemory")]
            [Validation(Required=false)]
            public string OriginMemory { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
