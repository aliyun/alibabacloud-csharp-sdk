// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeJobResourceUsageResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The queried resource usage.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeJobResourceUsageResponseBodyData Data { get; set; }
        public class DescribeJobResourceUsageResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// The end time of the query. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The AnalyticDB compute unit (ACU) usage of the job resource group.
            /// </summary>
            [NameInMap("JobAcuUsage")]
            [Validation(Required=false)]
            public List<DescribeJobResourceUsageResponseBodyDataJobAcuUsage> JobAcuUsage { get; set; }
            public class DescribeJobResourceUsageResponseBodyDataJobAcuUsage : TeaModel {
                /// <summary>
                /// The ACU usage.
                /// </summary>
                [NameInMap("AcuUsageDetail")]
                [Validation(Required=false)]
                public DescribeJobResourceUsageResponseBodyDataJobAcuUsageAcuUsageDetail AcuUsageDetail { get; set; }
                public class DescribeJobResourceUsageResponseBodyDataJobAcuUsageAcuUsageDetail : TeaModel {
                    /// <summary>
                    /// The number of ACUs for the elastic resources.
                    /// </summary>
                    [NameInMap("ElasticAcuNumber")]
                    [Validation(Required=false)]
                    public float? ElasticAcuNumber { get; set; }

                    /// <summary>
                    /// The number of ACUs for the reserved resources.
                    /// </summary>
                    [NameInMap("ReservedAcuNumber")]
                    [Validation(Required=false)]
                    public float? ReservedAcuNumber { get; set; }

                    [NameInMap("SpotAcuNumber")]
                    [Validation(Required=false)]
                    public float? SpotAcuNumber { get; set; }

                    [NameInMap("SpotAcuPercentage")]
                    [Validation(Required=false)]
                    public float? SpotAcuPercentage { get; set; }

                    /// <summary>
                    /// The total number of ACUs.
                    /// </summary>
                    [NameInMap("TotalAcuNumber")]
                    [Validation(Required=false)]
                    public float? TotalAcuNumber { get; set; }

                }

                /// <summary>
                /// The end time of the job. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("JobEndTime")]
                [Validation(Required=false)]
                public string JobEndTime { get; set; }

                /// <summary>
                /// The job ID.
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// The start time of the job. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("JobStartTime")]
                [Validation(Required=false)]
                public string JobStartTime { get; set; }

                /// <summary>
                /// The name of the job resource group.
                /// </summary>
                [NameInMap("ResourceGroupName")]
                [Validation(Required=false)]
                public string ResourceGroupName { get; set; }

            }

            /// <summary>
            /// The start time of the query. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
