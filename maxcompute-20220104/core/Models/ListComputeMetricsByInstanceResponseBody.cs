// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListComputeMetricsByInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListComputeMetricsByInstanceResponseBodyData Data { get; set; }
        public class ListComputeMetricsByInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Usage metrics for pay-as-you-go jobs.</para>
            /// </summary>
            [NameInMap("instanceComputeMetrics")]
            [Validation(Required=false)]
            public List<ListComputeMetricsByInstanceResponseBodyDataInstanceComputeMetrics> InstanceComputeMetrics { get; set; }
            public class ListComputeMetricsByInstanceResponseBodyDataInstanceComputeMetrics : TeaModel {
                /// <summary>
                /// <para>The job completion time, as a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710432000000</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20240730****ddlr</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The owner of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN$7632***@aliyun.com</para>
                /// </summary>
                [NameInMap("jobOwner")]
                [Validation(Required=false)]
                public string JobOwner { get; set; }

                /// <summary>
                /// <para>The name of the project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps_porject</para>
                /// </summary>
                [NameInMap("projectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The signature of the SQL job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pqrs12345tuv</para>
                /// </summary>
                [NameInMap("signature")]
                [Validation(Required=false)]
                public string Signature { get; set; }

                /// <summary>
                /// <para>The specification type.</para>
                /// <list type="bullet">
                /// <item><description><para><c>OdpsStandard</c>: Standard pay-as-you-go specification.</para>
                /// </description></item>
                /// <item><description><para><c>OdpsSpot</c>: Spot pay-as-you-go specification.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OdpsStandard</para>
                /// </summary>
                [NameInMap("specCode")]
                [Validation(Required=false)]
                public string SpecCode { get; set; }

                /// <summary>
                /// <para>The job submission time, as a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1610432000000</para>
                /// </summary>
                [NameInMap("submitTime")]
                [Validation(Required=false)]
                public long? SubmitTime { get; set; }

                /// <summary>
                /// <para>The metering type.</para>
                /// <list type="bullet">
                /// <item><description><para><c>ComputationSql</c>: Metrics for SQL jobs on internal tables.</para>
                /// </description></item>
                /// <item><description><para><c>ComputationSqlOTS</c>: Metrics for SQL jobs on Tablestore external tables.</para>
                /// </description></item>
                /// <item><description><para><c>ComputationSqlOSS</c>: Metrics for SQL jobs on OSS external tables.</para>
                /// </description></item>
                /// <item><description><para><c>MapReduce</c>: Metrics for MapReduce jobs.</para>
                /// </description></item>
                /// <item><description><para><c>spark</c>: Metrics for Spark jobs.</para>
                /// </description></item>
                /// <item><description><para><c>mars</c>: Metrics for Mars jobs.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ComputationSql</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The unit of compute usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GB</para>
                /// </summary>
                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                /// <summary>
                /// <para>The compute usage.</para>
                /// <list type="bullet">
                /// <item><description><para>For jobs billed by the amount of data scanned, such as <c>ComputationSql</c>, <c>ComputationSqlOTS</c>, and <c>ComputationSqlOSS</c> jobs, the unit is GB. The usage is calculated as: Amount of scanned data × Complexity. The complexity factor for <c>ComputationSqlOTS</c> and <c>ComputationSqlOSS</c> jobs is 1.</para>
                /// </description></item>
                /// <item><description><para>For jobs billed by CU-hours (such as <c>MapReduce</c>, <c>spark</c>, and <c>mars</c> jobs), the unit is CU-hour.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("usage")]
                [Validation(Required=false)]
                public double? Usage { get; set; }

            }

            /// <summary>
            /// <para>The returned page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description><para>1xx: Informational - The request has been received and is being processed.</para>
        /// </description></item>
        /// <item><description><para>2xx: Success - The request was successfully received, understood, and accepted.</para>
        /// </description></item>
        /// <item><description><para>3xx: Redirection - Further action is required to complete the request.</para>
        /// </description></item>
        /// <item><description><para>4xx: Client Error - The request contains invalid syntax or cannot be fulfilled.</para>
        /// </description></item>
        /// <item><description><para>5xx: Server Error - The server failed to fulfill a valid request.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc059b717363029839908920ea631</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
