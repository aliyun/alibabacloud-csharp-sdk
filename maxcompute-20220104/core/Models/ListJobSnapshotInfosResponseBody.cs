// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListJobSnapshotInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListJobSnapshotInfosResponseBodyData Data { get; set; }
        public class ListJobSnapshotInfosResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of job snapshots.</para>
            /// </summary>
            [NameInMap("jobInfoList")]
            [Validation(Required=false)]
            public List<ListJobSnapshotInfosResponseBodyDataJobInfoList> JobInfoList { get; set; }
            public class ListJobSnapshotInfosResponseBodyDataJobInfoList : TeaModel {
                /// <summary>
                /// <para>The amount of CPU cores requested by the job at the snapshot time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("cpuRequest")]
                [Validation(Required=false)]
                public long? CpuRequest { get; set; }

                /// <summary>
                /// <para>The CPU usage of the job at the snapshot time. Unit: cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("cpuUsage")]
                [Validation(Required=false)]
                public long? CpuUsage { get; set; }

                /// <summary>
                /// <para>The CPU fulfillment ratio of the job at the snapshot time. This is calculated by dividing the CPU usage by the CPU request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("cpuUsageToRequestRatio")]
                [Validation(Required=false)]
                public double? CpuUsageToRequestRatio { get; set; }

                /// <summary>
                /// <para>The upstream node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>76358164</para>
                /// </summary>
                [NameInMap("extNodeId")]
                [Validation(Required=false)]
                public string ExtNodeId { get; set; }

                /// <summary>
                /// <para>The account ID of the task owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>duty_2</para>
                /// </summary>
                [NameInMap("extNodeOnDuty")]
                [Validation(Required=false)]
                public string ExtNodeOnDuty { get; set; }

                /// <summary>
                /// <para>The upstream platform.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Dataworks</para>
                /// </summary>
                [NameInMap("extPlantFrom")]
                [Validation(Required=false)]
                public string ExtPlantFrom { get; set; }

                [NameInMap("extPlatformId")]
                [Validation(Required=false)]
                public string ExtPlatformId { get; set; }

                /// <summary>
                /// <para>The job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20241028****jkl</para>
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
                /// <para>The job type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SQL</para>
                /// </summary>
                [NameInMap("jobType")]
                [Validation(Required=false)]
                public string JobType { get; set; }

                /// <summary>
                /// <para>This parameter is not used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("maxCpuPct")]
                [Validation(Required=false)]
                public double? MaxCpuPct { get; set; }

                /// <summary>
                /// <para>This parameter is not used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("maxMemoryPct")]
                [Validation(Required=false)]
                public double? MaxMemoryPct { get; set; }

                /// <summary>
                /// <para>The amount of memory requested by the job at the snapshot time, in MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>409600</para>
                /// </summary>
                [NameInMap("memoryRequest")]
                [Validation(Required=false)]
                public long? MemoryRequest { get; set; }

                /// <summary>
                /// <para>The memory usage of the job at the snapshot time. Unit: MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>409600</para>
                /// </summary>
                [NameInMap("memoryUsage")]
                [Validation(Required=false)]
                public long? MemoryUsage { get; set; }

                /// <summary>
                /// <para>The memory fulfillment ratio of the job at the snapshot time. This is calculated by dividing the memory usage by the memory request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("memoryUsageToRequestRatio")]
                [Validation(Required=false)]
                public double? MemoryUsageToRequestRatio { get; set; }

                /// <summary>
                /// <para>The CPU usage percentage of a subscription job at the snapshot time. This value is calculated by dividing the CPU usage by the sum of the reserved CPU guarantee and the elastic reserved CPU. This parameter is not available for pay-as-you-go jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.6</para>
                /// </summary>
                [NameInMap("minCpuPct")]
                [Validation(Required=false)]
                public double? MinCpuPct { get; set; }

                /// <summary>
                /// <para>The memory usage percentage of a subscription job at the observation time. This value is calculated by dividing the memory usage by the sum of the reserved memory guarantee and the elastic reserved memory. This parameter is not available for pay-as-you-go jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.6</para>
                /// </summary>
                [NameInMap("minMemoryPct")]
                [Validation(Required=false)]
                public double? MinMemoryPct { get; set; }

                /// <summary>
                /// <para>The job priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("priority")]
                [Validation(Required=false)]
                public long? Priority { get; set; }

                /// <summary>
                /// <para>The project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>projectA</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The nickname of the computing quota that the job uses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>quota_A</para>
                /// </summary>
                [NameInMap("quotaNickname")]
                [Validation(Required=false)]
                public string QuotaNickname { get; set; }

                /// <summary>
                /// <para>The quota type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>subscription</para>
                /// </summary>
                [NameInMap("quotaType")]
                [Validation(Required=false)]
                public string QuotaType { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-chengdu</para>
                /// </summary>
                [NameInMap("region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The time when the job started running.</para>
                /// <remarks>
                /// <para>The time when the job acquired its first computing resource.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1736821805</para>
                /// </summary>
                [NameInMap("runningAtTime")]
                [Validation(Required=false)]
                public long? RunningAtTime { get; set; }

                /// <summary>
                /// <para>The runtime duration, in seconds. This is the duration from when the job started running to the snapshot time. If the job has not started, this parameter is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>43</para>
                /// </summary>
                [NameInMap("runningTime")]
                [Validation(Required=false)]
                public long? RunningTime { get; set; }

                /// <summary>
                /// <para>The signature of the SQL job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>signatureabc</para>
                /// </summary>
                [NameInMap("signature")]
                [Validation(Required=false)]
                public string Signature { get; set; }

                /// <summary>
                /// <para>The snapshot time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1736821848</para>
                /// </summary>
                [NameInMap("snapshotTime")]
                [Validation(Required=false)]
                public long? SnapshotTime { get; set; }

                /// <summary>
                /// <para>The job status.</para>
                /// <remarks>
                /// <para>The status of a snapshot job can only be \<c>running\\</c>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The time when the job was submitted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1736821785</para>
                /// </summary>
                [NameInMap("submittedAtTime")]
                [Validation(Required=false)]
                public long? SubmittedAtTime { get; set; }

                /// <summary>
                /// <para>The tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>213065738244354</para>
                /// </summary>
                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>The total duration, in seconds. This is the duration from when the job was submitted to the snapshot time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>63</para>
                /// </summary>
                [NameInMap("totalTime")]
                [Validation(Required=false)]
                public long? TotalTime { get; set; }

                /// <summary>
                /// <para>The waiting duration, in seconds. This is the duration from when the job was submitted to when it started running. If the job has not started, this is the duration from the submission time to the snapshot time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("waitingTime")]
                [Validation(Required=false)]
                public long? WaitingTime { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
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
            /// <para>123</para>
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
        /// <para>异常信息</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description><para>1xx: Informational - The request has been received and the process is continuing.</para>
        /// </description></item>
        /// <item><description><para>2xx: Success - The request was successfully received, understood, and accepted.</para>
        /// </description></item>
        /// <item><description><para>3xx: Redirection - Further action must be taken to complete the request.</para>
        /// </description></item>
        /// <item><description><para>4xx: Client Error - The request contains bad syntax or cannot be fulfilled.</para>
        /// </description></item>
        /// <item><description><para>5xx: Server Error - The server failed to fulfill an apparently valid request.</para>
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
        /// <para>0b87b7e716665825896565060e87a4</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
