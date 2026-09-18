// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListComputeMetricsByInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListComputeMetricsByInstanceResponseBodyData Data { get; set; }
        public class ListComputeMetricsByInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of pay-as-you-go job compute usage.</para>
            /// </summary>
            [NameInMap("instanceComputeMetrics")]
            [Validation(Required=false)]
            public List<ListComputeMetricsByInstanceResponseBodyDataInstanceComputeMetrics> InstanceComputeMetrics { get; set; }
            public class ListComputeMetricsByInstanceResponseBodyDataInstanceComputeMetrics : TeaModel {
                /// <summary>
                /// <para>The job end time. This value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710432000000</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20240730****ddlr</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The job owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN$7632***@aliyun.com</para>
                /// </summary>
                [NameInMap("jobOwner")]
                [Validation(Required=false)]
                public string JobOwner { get; set; }

                /// <summary>
                /// <para>The project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps_porject</para>
                /// </summary>
                [NameInMap("projectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The SQL job signature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pqrs12345tuv</para>
                /// </summary>
                [NameInMap("signature")]
                [Validation(Required=false)]
                public string Signature { get; set; }

                /// <summary>
                /// <para>The specification type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OdpsStandard: the pay-as-you-go billing method Standard Edition.</description></item>
                /// <item><description>OdpsSpot: the pay-as-you-go billing method Off-peak Edition.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OdpsStandard</para>
                /// </summary>
                [NameInMap("specCode")]
                [Validation(Required=false)]
                public string SpecCode { get; set; }

                /// <summary>
                /// <para>The job submit time. This value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1610432000000</para>
                /// </summary>
                [NameInMap("submitTime")]
                [Validation(Required=false)]
                public long? SubmitTime { get; set; }

                /// <summary>
                /// <para>The metering type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>ComputationSql: metering data of SQL jobs that operate on internal tables.</para>
                /// </description></item>
                /// <item><description><para>ComputationSqlOTS: metering data of SQL jobs that operate on OTS external tables.</para>
                /// </description></item>
                /// <item><description><para>ComputationSqlOSS: metering data of SQL jobs that operate on OSS external tables.</para>
                /// </description></item>
                /// <item><description><para>MapReduce: metering data of MapReduce jobs.</para>
                /// </description></item>
                /// <item><description><para>spark: metering data of Spark jobs.</para>
                /// </description></item>
                /// <item><description><para>mars: metering data of Mars jobs.</para>
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
                /// <item><description><para>For scan-based billing types, the unit is GB. This includes the ComputationSql, ComputationSqlOTS, and ComputationSqlOSS billing types, which are billed based on the amount of data scanned. The compute usage is calculated as the scan volume × complexity for each job. The complexity for ComputationSqlOTS and ComputationSqlOSS types is fixed at 1.</para>
                /// </description></item>
                /// <item><description><para>For CU-hour-based billing types, the unit is CU-hours. This includes the MapReduce, spark, and mars billing types, which are billed based on CU-hours.</para>
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
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1xx: Informational response. The request has been received and is being processed.</description></item>
        /// <item><description>2xx: Success. The request has been successfully received, understood, and accepted by the server.</description></item>
        /// <item><description>3xx: Redirection. The request is redirected, and further action is required to complete the request.</description></item>
        /// <item><description>4xx: Client error. The request contains invalid parameters, bad syntax, or specific request conditions cannot be fulfilled.</description></item>
        /// <item><description>5xx: Server error. The server cannot fulfill the request due to other reasons.</description></item>
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
