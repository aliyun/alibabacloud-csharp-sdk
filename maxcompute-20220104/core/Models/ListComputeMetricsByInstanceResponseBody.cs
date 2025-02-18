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
            /// <para>List of pay-as-you-go job compute usage.</para>
            /// </summary>
            [NameInMap("instanceComputeMetrics")]
            [Validation(Required=false)]
            public List<ListComputeMetricsByInstanceResponseBodyDataInstanceComputeMetrics> InstanceComputeMetrics { get; set; }
            public class ListComputeMetricsByInstanceResponseBodyDataInstanceComputeMetrics : TeaModel {
                /// <summary>
                /// <para>The end time of the job execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710432000000</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The job(instance) ID.</para>
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
                /// <para>Specifications Type, specifies the resource package that you select when you purchase the MaxCompute service.</para>
                /// <list type="bullet">
                /// <item><description><para>OdpsStandard: the pay-as-you-go resource package.</para>
                /// </description></item>
                /// <item><description><para>OdpsSpot: the pay-as-you-go spot resource package.</para>
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
                /// <para>The submission time of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1610432000000</para>
                /// </summary>
                [NameInMap("submitTime")]
                [Validation(Required=false)]
                public long? SubmitTime { get; set; }

                /// <summary>
                /// <para>Metering types.</para>
                /// <list type="bullet">
                /// <item><description><para>ComputationSql: the metering data of SQL jobs that involve internal tables.</para>
                /// </description></item>
                /// <item><description><para>ComputationSqlOTS: the metering data of SQL jobs that involve Tablestore external tables.</para>
                /// </description></item>
                /// <item><description><para>ComputationSqlOSS: the metering data of SQL jobs that involve OSS external tables.</para>
                /// </description></item>
                /// <item><description><para>MapReduce: the metering data of MapReduce jobs.</para>
                /// </description></item>
                /// <item><description><para>spark: the metering data of Spark jobs.</para>
                /// </description></item>
                /// <item><description><para>mars: the metering data of Mars jobs.</para>
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
                /// <para>The unit of computing resource usage</para>
                /// 
                /// <b>Example:</b>
                /// <para>GB</para>
                /// </summary>
                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                /// <summary>
                /// <para>The computing resource usage is calculated based on the following items:</para>
                /// <list type="bullet">
                /// <item><description><para>Amount of scanned data in the unit of GB. For the jobs whose metering types are ComputationSql, ComputationSqlOTS, or ComputationSqlOSS, they are billed based on the amount of scanned data. The computing resource usage of such a job is calculated by using the following formula: Amount of scanned data × Complexity. The complexity is fixed at 1 for the jobs whose metering types are ComputationSqlOTS or ComputationSqlOSS.</para>
                /// </description></item>
                /// <item><description><para>CU-hours. For the jobs whose metering types are MapReduce, spark, or mars, they are billed based on CU-hours.</para>
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
            /// <para>The current page number.</para>
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
            /// <para>The total number of results returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OBJECT_NOT_EXIST</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This object does not exist.</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description>1xx: informational response. The request is received and is being processed.</description></item>
        /// <item><description>2xx: success. The request is successfully received, understood, and accepted by the server.</description></item>
        /// <item><description>3xx: redirection. The request is redirected, and further actions are required to complete the request.</description></item>
        /// <item><description>4xx: client error. The request contains invalid request parameters or syntaxes, or specific request conditions cannot be met.</description></item>
        /// <item><description>5xx: server error. The server cannot meet requirements due to other reasons.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc059b717363029839908920ea631</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
