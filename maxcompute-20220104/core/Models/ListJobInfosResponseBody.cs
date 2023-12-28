// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListJobInfosResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListJobInfosResponseBodyData Data { get; set; }
        public class ListJobInfosResponseBodyData : TeaModel {
            /// <summary>
            /// The list of the information about the jobs.
            /// </summary>
            [NameInMap("jobInfoList")]
            [Validation(Required=false)]
            public List<ListJobInfosResponseBodyDataJobInfoList> JobInfoList { get; set; }
            public class ListJobInfosResponseBodyDataJobInfoList : TeaModel {
                /// <summary>
                /// The cluster ID.
                /// </summary>
                [NameInMap("cluster")]
                [Validation(Required=false)]
                public string Cluster { get; set; }

                /// <summary>
                /// The CU snapshot proportion of the job.
                /// </summary>
                [NameInMap("cuSnapshot")]
                [Validation(Required=false)]
                public double? CuSnapshot { get; set; }

                /// <summary>
                /// The total number of used compute units (CUs).
                /// </summary>
                [NameInMap("cuUsage")]
                [Validation(Required=false)]
                public long? CuUsage { get; set; }

                /// <summary>
                /// The time when the job stops running.
                /// </summary>
                [NameInMap("endAtTime")]
                [Validation(Required=false)]
                public long? EndAtTime { get; set; }

                /// <summary>
                /// The node ID of DataWorks.
                /// </summary>
                [NameInMap("extNodeId")]
                [Validation(Required=false)]
                public string ExtNodeId { get; set; }

                /// <summary>
                /// The account of the node owner.
                /// </summary>
                [NameInMap("extNodeOnDuty")]
                [Validation(Required=false)]
                public string ExtNodeOnDuty { get; set; }

                /// <summary>
                /// The upstream platform.
                /// </summary>
                [NameInMap("extPlantFrom")]
                [Validation(Required=false)]
                public string ExtPlantFrom { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The account that commits the job.
                /// </summary>
                [NameInMap("jobOwner")]
                [Validation(Required=false)]
                public string JobOwner { get; set; }

                /// <summary>
                /// The type of the job.
                /// </summary>
                [NameInMap("jobType")]
                [Validation(Required=false)]
                public string JobType { get; set; }

                /// <summary>
                /// The memory snapshot proportion of the job.
                /// </summary>
                [NameInMap("memorySnapshot")]
                [Validation(Required=false)]
                public double? MemorySnapshot { get; set; }

                /// <summary>
                /// The total memory usage.
                /// </summary>
                [NameInMap("memoryUsage")]
                [Validation(Required=false)]
                public long? MemoryUsage { get; set; }

                /// <summary>
                /// The priority of the job.
                /// </summary>
                [NameInMap("priority")]
                [Validation(Required=false)]
                public long? Priority { get; set; }

                /// <summary>
                /// The name of the MaxCompute project.
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// The nickname of the quota that is used by the job.
                /// </summary>
                [NameInMap("quotaNickname")]
                [Validation(Required=false)]
                public string QuotaNickname { get; set; }

                /// <summary>
                /// The type of the quota.
                /// </summary>
                [NameInMap("quotaType")]
                [Validation(Required=false)]
                public string QuotaType { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The time when the job starts to run.
                /// </summary>
                [NameInMap("runningAtTime")]
                [Validation(Required=false)]
                public long? RunningAtTime { get; set; }

                /// <summary>
                /// The period for which the job runs.
                /// </summary>
                [NameInMap("runningTime")]
                [Validation(Required=false)]
                public long? RunningTime { get; set; }

                /// <summary>
                /// The signature of the SQL job.
                /// </summary>
                [NameInMap("signature")]
                [Validation(Required=false)]
                public string Signature { get; set; }

                /// <summary>
                /// The status of the job.
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The status of the snapshot.
                /// </summary>
                [NameInMap("statusSnapshot")]
                [Validation(Required=false)]
                public string StatusSnapshot { get; set; }

                /// <summary>
                /// The time when the job was committed.
                /// </summary>
                [NameInMap("submittedAtTime")]
                [Validation(Required=false)]
                public long? SubmittedAtTime { get; set; }

                /// <summary>
                /// The tags.
                /// </summary>
                [NameInMap("tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// The tenant ID.
                /// </summary>
                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// The total period for which the job runs.
                /// </summary>
                [NameInMap("totalTime")]
                [Validation(Required=false)]
                public long? TotalTime { get; set; }

                /// <summary>
                /// The duration for which the job waits to start.
                /// </summary>
                [NameInMap("waitingTime")]
                [Validation(Required=false)]
                public long? WaitingTime { get; set; }

            }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// Indicates whether the request was successful. If this parameter was not empty and the value of this parameter was not 200, the request failed.
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
