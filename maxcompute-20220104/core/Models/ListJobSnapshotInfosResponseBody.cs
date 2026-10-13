// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListJobSnapshotInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
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
                /// <para>The requested CPU resources of the job at the snapshot time. Unit: Core.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("cpuRequest")]
                [Validation(Required=false)]
                public long? CpuRequest { get; set; }

                /// <summary>
                /// <para>The CPU usage of the job at the snapshot time. Unit: Core.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("cpuUsage")]
                [Validation(Required=false)]
                public long? CpuUsage { get; set; }

                /// <summary>
                /// <para>The CPU fulfillment rate of the job at the snapshot time, which is calculated as CPU usage divided by requested CPU resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("cpuUsageToRequestRatio")]
                [Validation(Required=false)]
                public double? CpuUsageToRequestRatio { get; set; }

                /// <summary>
                /// <para>The upstream node IDs.</para>
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
                /// <para>The job types.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SQL</para>
                /// </summary>
                [NameInMap("jobType")]
                [Validation(Required=false)]
                public string JobType { get; set; }

                /// <summary>
                /// <para>Ignore this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("maxCpuPct")]
                [Validation(Required=false)]
                public double? MaxCpuPct { get; set; }

                /// <summary>
                /// <para>Ignore this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("maxMemoryPct")]
                [Validation(Required=false)]
                public double? MaxMemoryPct { get; set; }

                /// <summary>
                /// <para>The requested memory resources of the job at the snapshot time. Unit: MB.</para>
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
                /// <para>The memory fulfillment rate of the job at the snapshot time, which is calculated as memory usage divided by requested memory resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("memoryUsageToRequestRatio")]
                [Validation(Required=false)]
                public double? MemoryUsageToRequestRatio { get; set; }

                /// <summary>
                /// <para>The CPU usage ratio of a subscription job at the snapshot time, which is calculated as CPU usage divided by the sum of reserved CPU and elastic reserved CPU. This parameter is not returned for pay-as-you-go jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.6</para>
                /// </summary>
                [NameInMap("minCpuPct")]
                [Validation(Required=false)]
                public double? MinCpuPct { get; set; }

                /// <summary>
                /// <para>The memory usage ratio of a subscription job at the observation time, which is calculated as memory usage divided by the sum of reserved memory and elastic reserved memory. This parameter is not returned for pay-as-you-go jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.6</para>
                /// </summary>
                [NameInMap("minMemoryPct")]
                [Validation(Required=false)]
                public double? MinMemoryPct { get; set; }

                /// <summary>
                /// <para>The job priorities.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("priority")]
                [Validation(Required=false)]
                public long? Priority { get; set; }

                /// <summary>
                /// <para>The project names.</para>
                /// 
                /// <b>Example:</b>
                /// <para>projectA</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The nickname of the compute quota used by the job.</para>
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
                /// <para>The time when the job obtained the first compute resource. The value is a UNIX timestamp in seconds.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1736821805</para>
                /// </summary>
                [NameInMap("runningAtTime")]
                [Validation(Required=false)]
                public long? RunningAtTime { get; set; }

                /// <summary>
                /// <para>The running duration, which is the time from when the job started running to the snapshot time. If the job has not started running, this parameter is empty. Unit: s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>43</para>
                /// </summary>
                [NameInMap("runningTime")]
                [Validation(Required=false)]
                public long? RunningTime { get; set; }

                /// <summary>
                /// <para>The SQL job signatures.</para>
                /// 
                /// <b>Example:</b>
                /// <para>signatureabc</para>
                /// </summary>
                [NameInMap("signature")]
                [Validation(Required=false)]
                public string Signature { get; set; }

                /// <summary>
                /// <para>The snapshot time. The value is a UNIX timestamp, Unit: s.</para>
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
                /// <para>The status of a job in a snapshot is always running.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The time when the job was submitted. The value is a UNIX timestamp, Unit: s.</para>
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
                /// <para>The total duration, which is the time from when the job was submitted to the snapshot time. Unit: s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>63</para>
                /// </summary>
                [NameInMap("totalTime")]
                [Validation(Required=false)]
                public long? TotalTime { get; set; }

                /// <summary>
                /// <para>The waiting duration, which is the time from when the job was submitted to when it started running. If the job has not started running, the value is the time from when the job was submitted to the snapshot time. Unit: s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("waitingTime")]
                [Validation(Required=false)]
                public long? WaitingTime { get; set; }

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
            /// <para>The total number of returned entries.</para>
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
        /// <para>Error message</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description>1xx: Informational. The request was received and is being processed.</description></item>
        /// <item><description>2xx: Success. The request was successfully received, understood, and accepted by the server.</description></item>
        /// <item><description>3xx: Redirection. The request was redirected, and further action is required to complete it.</description></item>
        /// <item><description>4xx: Client error. The request contains invalid parameters, bad syntax, or specific request conditions cannot be met.</description></item>
        /// <item><description>5xx: Server error. The server failed to fulfill the request due to other reasons.</description></item>
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
