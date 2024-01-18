// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class SetSchedulerInfoRequest : TeaModel {
        /// <summary>
        /// The ID of the E-HPC cluster.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to query the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The information about PBS schedulers.
        /// </summary>
        [NameInMap("PbsInfo")]
        [Validation(Required=false)]
        public List<SetSchedulerInfoRequestPbsInfo> PbsInfo { get; set; }
        public class SetSchedulerInfoRequestPbsInfo : TeaModel {
            /// <summary>
            /// The information about limits on the queue.
            /// </summary>
            [NameInMap("AclLimit")]
            [Validation(Required=false)]
            public List<SetSchedulerInfoRequestPbsInfoAclLimit> AclLimit { get; set; }
            public class SetSchedulerInfoRequestPbsInfoAclLimit : TeaModel {
                /// <summary>
                /// The user that can use the queue. Separate multiple users with commas (`,`).
                /// 
                /// If you specify users, you must specify the PbsInfo.N.AclLimit.N.Queue parameter.
                /// </summary>
                [NameInMap("AclUsers")]
                [Validation(Required=false)]
                public string AclUsers { get; set; }

                /// <summary>
                /// AclLimit specifies the queue that has limits when it is used. Valid values of N: 0 to 100.
                /// 
                /// If you set `PbsInfo.N.AclLimit.N.Queue` to `workq` and `PbsInfo.N.AclLimit.N.AclUsers` to `user1,user2`, workq can be used only by user1 and user2.
                /// </summary>
                [NameInMap("Queue")]
                [Validation(Required=false)]
                public string Queue { get; set; }

            }

            /// <summary>
            /// The retention period of jobs. After the retention period is exceeded, job data is deleted. Unit: days.\
            /// Valid values: 1 to 30.\
            /// Default value: 14.
            /// </summary>
            [NameInMap("JobHistoryDuration")]
            [Validation(Required=false)]
            public int? JobHistoryDuration { get; set; }

            /// <summary>
            /// The information about the nodes that are used by cluster users.
            /// </summary>
            [NameInMap("ResourceLimit")]
            [Validation(Required=false)]
            public List<SetSchedulerInfoRequestPbsInfoResourceLimit> ResourceLimit { get; set; }
            public class SetSchedulerInfoRequestPbsInfoResourceLimit : TeaModel {
                /// <summary>
                /// The maximum number of vCPUs that can be used for nodes in a queue.
                /// </summary>
                [NameInMap("Cpus")]
                [Validation(Required=false)]
                public int? Cpus { get; set; }

                /// <summary>
                /// The maximum number of jobs that can be submitted to the cluster. If the total number of running jobs and queuing jobs exceeds the value, no more jobs can be submitted.
                /// </summary>
                [NameInMap("MaxJobs")]
                [Validation(Required=false)]
                public int? MaxJobs { get; set; }

                /// <summary>
                /// The maximum memory resources that can be used in a queue. Units:
                /// 
                /// *   gb
                /// *   mb
                /// *   kb
                /// </summary>
                [NameInMap("Mem")]
                [Validation(Required=false)]
                public string Mem { get; set; }

                /// <summary>
                /// The maximum number of nodes that can be used in a queue.
                /// </summary>
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public int? Nodes { get; set; }

                /// <summary>
                /// PbsInfo specifies the number of PBS schedulers that can be configured in the cluster. Valid values of N: 0 to 100.
                /// 
                /// ResourceLimit specifies the maximum number of queue resources that can be used. Valid values of N: 0 to 100.
                /// 
                /// Queue specifies the name of the queue that is used to run jobs.
                /// 
                /// If one of the User, Cpus, Nodes, and Mem parameters is set in ResourceLimit, you must specify the Queue parameter.
                /// </summary>
                [NameInMap("Queue")]
                [Validation(Required=false)]
                public string Queue { get; set; }

                /// <summary>
                /// The name of the user that runs jobs.
                /// </summary>
                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

            /// <summary>
            /// PbsInfo specifies the number of PBS schedulers that can be configured in the cluster. Valid values of N: 0 to 100.
            /// 
            /// SchedInterval specifies the scheduling period. Unit: seconds.
            /// 
            /// A scheduling period is the interval between two consecutive running jobs. If you set SchedInterval to 60, another job can be run 60 seconds after a job starts running.
            /// 
            /// Default value: 60.
            /// </summary>
            [NameInMap("SchedInterval")]
            [Validation(Required=false)]
            public int? SchedInterval { get; set; }

            /// <summary>
            /// The maximum number of jobs that can be scheduled in the cluster. If the total number of running jobs and queuing jobs exceeds the value, no more jobs can be submitted. Default value: 20000.
            /// </summary>
            [NameInMap("SchedMaxJobs")]
            [Validation(Required=false)]
            public int? SchedMaxJobs { get; set; }

            /// <summary>
            /// The maximum number of queuing jobs that can be scheduled in the cluster. If the number of queuing jobs exceeds the value, no more jobs can be submitted. Default value: 10000.
            /// </summary>
            [NameInMap("SchedMaxQueuedJobs")]
            [Validation(Required=false)]
            public int? SchedMaxQueuedJobs { get; set; }

        }

        /// <summary>
        /// The region ID.
        /// 
        /// You can call the [ListRegions](~~188593~~) operation to obtain the IDs of regions supported by Elastic High Performance Computing (E-HPC).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The scheduler information.
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public List<SetSchedulerInfoRequestScheduler> Scheduler { get; set; }
        public class SetSchedulerInfoRequestScheduler : TeaModel {
            /// <summary>
            /// The name of the scheduler. Valid values:
            /// 
            /// *   pbs
            /// *   pbs19
            /// *   slurm
            /// *   slurm19
            /// *   slurm20
            /// 
            /// >  If you set Scheduler.N.SchedName to pbs or pbs19, you must specify at least one of the PbsInfo.N.SchedInterval, PbsInfo.N.JobHistoryDuration, PbsInfo.N.ResourceLimit, and PbsInfo.N.AclLimit parameters. If you set Scheduler.N.SchedName to slurm, slurm19, or slurm20, you must specify at least one of the SlurmInfo.N.SchedInterval and SlurmInfo.N.BackfillInterval parameters.
            /// </summary>
            [NameInMap("SchedName")]
            [Validation(Required=false)]
            public string SchedName { get; set; }

        }

        /// <summary>
        /// The information about Slurm schedulers.
        /// </summary>
        [NameInMap("SlurmInfo")]
        [Validation(Required=false)]
        public List<SetSchedulerInfoRequestSlurmInfo> SlurmInfo { get; set; }
        public class SetSchedulerInfoRequestSlurmInfo : TeaModel {
            /// <summary>
            /// The backfill scheduling period. Unit: seconds.
            /// 
            /// Default value: 60.
            /// </summary>
            [NameInMap("BackfillInterval")]
            [Validation(Required=false)]
            public int? BackfillInterval { get; set; }

            /// <summary>
            /// SlurmInfo specifies the number of Slurm schedulers that can be configured in the cluster. Valid values of N: 0 to 100.
            /// 
            /// SchedInterval specifies the scheduling period. Unit: seconds.
            /// 
            /// Default value: 60.
            /// </summary>
            [NameInMap("SchedInterval")]
            [Validation(Required=false)]
            public int? SchedInterval { get; set; }

        }

    }

}
