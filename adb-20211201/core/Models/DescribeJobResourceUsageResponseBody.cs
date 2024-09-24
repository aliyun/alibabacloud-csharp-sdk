// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeJobResourceUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The queried resource usage.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeJobResourceUsageResponseBodyData Data { get; set; }
        public class DescribeJobResourceUsageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amv-clusterxxx</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The end time of the query. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-23T16:00:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The AnalyticDB compute unit (ACU) usage of the job resource group.</para>
            /// </summary>
            [NameInMap("JobAcuUsage")]
            [Validation(Required=false)]
            public List<DescribeJobResourceUsageResponseBodyDataJobAcuUsage> JobAcuUsage { get; set; }
            public class DescribeJobResourceUsageResponseBodyDataJobAcuUsage : TeaModel {
                /// <summary>
                /// <para>The ACU usage.</para>
                /// </summary>
                [NameInMap("AcuUsageDetail")]
                [Validation(Required=false)]
                public DescribeJobResourceUsageResponseBodyDataJobAcuUsageAcuUsageDetail AcuUsageDetail { get; set; }
                public class DescribeJobResourceUsageResponseBodyDataJobAcuUsageAcuUsageDetail : TeaModel {
                    /// <summary>
                    /// <para>The number of ACUs for the elastic resources.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>16ACU</para>
                    /// </summary>
                    [NameInMap("ElasticAcuNumber")]
                    [Validation(Required=false)]
                    public float? ElasticAcuNumber { get; set; }

                    /// <summary>
                    /// <para>The number of ACUs for the reserved resources.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>16ACU</para>
                    /// </summary>
                    [NameInMap("ReservedAcuNumber")]
                    [Validation(Required=false)]
                    public float? ReservedAcuNumber { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>16ACU</para>
                    /// </summary>
                    [NameInMap("SpotAcuNumber")]
                    [Validation(Required=false)]
                    public float? SpotAcuNumber { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.9</para>
                    /// </summary>
                    [NameInMap("SpotAcuPercentage")]
                    [Validation(Required=false)]
                    public float? SpotAcuPercentage { get; set; }

                    /// <summary>
                    /// <para>The total number of ACUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>32ACU</para>
                    /// </summary>
                    [NameInMap("TotalAcuNumber")]
                    [Validation(Required=false)]
                    public float? TotalAcuNumber { get; set; }

                }

                /// <summary>
                /// <para>The end time of the job. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-05-23T16:00:00Z</para>
                /// </summary>
                [NameInMap("JobEndTime")]
                [Validation(Required=false)]
                public string JobEndTime { get; set; }

                /// <summary>
                /// <para>The job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1592</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The start time of the job. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-05-22T16:00:00Z</para>
                /// </summary>
                [NameInMap("JobStartTime")]
                [Validation(Required=false)]
                public string JobStartTime { get; set; }

                /// <summary>
                /// <para>The name of the job resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job_default</para>
                /// </summary>
                [NameInMap("ResourceGroupName")]
                [Validation(Required=false)]
                public string ResourceGroupName { get; set; }

            }

            /// <summary>
            /// <para>The start time of the query. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-22T16:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
