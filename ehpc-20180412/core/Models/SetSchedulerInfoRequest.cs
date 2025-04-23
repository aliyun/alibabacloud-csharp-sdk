// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class SetSchedulerInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the E-HPC cluster.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> operation to query the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The information about PBS schedulers.</para>
        /// </summary>
        [NameInMap("PbsInfo")]
        [Validation(Required=false)]
        public List<SetSchedulerInfoRequestPbsInfo> PbsInfo { get; set; }
        public class SetSchedulerInfoRequestPbsInfo : TeaModel {
            /// <summary>
            /// <para>The information about limits on the queue.</para>
            /// </summary>
            [NameInMap("AclLimit")]
            [Validation(Required=false)]
            public List<SetSchedulerInfoRequestPbsInfoAclLimit> AclLimit { get; set; }
            public class SetSchedulerInfoRequestPbsInfoAclLimit : TeaModel {
                /// <summary>
                /// <para>The user that can use the queue. Separate multiple users with commas (<c>,</c>).</para>
                /// <para>If you specify users, you must specify the PbsInfo.N.AclLimit.N.Queue parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user1,user2</para>
                /// </summary>
                [NameInMap("AclUsers")]
                [Validation(Required=false)]
                public string AclUsers { get; set; }

                /// <summary>
                /// <para>AclLimit specifies the queue that has limits when it is used. Valid values of N: 0 to 100.</para>
                /// <para>If you set <c>PbsInfo.N.AclLimit.N.Queue</c> to <c>workq</c> and <c>PbsInfo.N.AclLimit.N.AclUsers</c> to <c>user1,user2</c>, workq can be used only by user1 and user2.</para>
                /// 
                /// <b>Example:</b>
                /// <para>workq</para>
                /// </summary>
                [NameInMap("Queue")]
                [Validation(Required=false)]
                public string Queue { get; set; }

            }

            /// <summary>
            /// <para>The retention period of jobs. After the retention period is exceeded, job data is deleted. Unit: days.\
            /// Valid values: 1 to 30.\
            /// Default value: 14.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14</para>
            /// </summary>
            [NameInMap("JobHistoryDuration")]
            [Validation(Required=false)]
            public int? JobHistoryDuration { get; set; }

            /// <summary>
            /// <para>The information about the nodes that are used by cluster users.</para>
            /// </summary>
            [NameInMap("ResourceLimit")]
            [Validation(Required=false)]
            public List<SetSchedulerInfoRequestPbsInfoResourceLimit> ResourceLimit { get; set; }
            public class SetSchedulerInfoRequestPbsInfoResourceLimit : TeaModel {
                /// <summary>
                /// <para>The maximum number of vCPUs that can be used for nodes in a queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Cpus")]
                [Validation(Required=false)]
                public int? Cpus { get; set; }

                /// <summary>
                /// <para>The maximum number of jobs that can be submitted to the cluster. If the total number of running jobs and queuing jobs exceeds the value, no more jobs can be submitted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("MaxJobs")]
                [Validation(Required=false)]
                public int? MaxJobs { get; set; }

                /// <summary>
                /// <para>The maximum memory resources that can be used in a queue. Units:</para>
                /// <list type="bullet">
                /// <item><description>gb</description></item>
                /// <item><description>mb</description></item>
                /// <item><description>kb</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2gb</para>
                /// </summary>
                [NameInMap("Mem")]
                [Validation(Required=false)]
                public string Mem { get; set; }

                /// <summary>
                /// <para>The maximum number of nodes that can be used in a queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public int? Nodes { get; set; }

                /// <summary>
                /// <para>PbsInfo specifies the number of PBS schedulers that can be configured in the cluster. Valid values of N: 0 to 100.</para>
                /// <para>ResourceLimit specifies the maximum number of queue resources that can be used. Valid values of N: 0 to 100.</para>
                /// <para>Queue specifies the name of the queue that is used to run jobs.</para>
                /// <para>If one of the User, Cpus, Nodes, and Mem parameters is set in ResourceLimit, you must specify the Queue parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>workq</para>
                /// </summary>
                [NameInMap("Queue")]
                [Validation(Required=false)]
                public string Queue { get; set; }

                /// <summary>
                /// <para>The name of the user that runs jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user1</para>
                /// </summary>
                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

            /// <summary>
            /// <para>PbsInfo specifies the number of PBS schedulers that can be configured in the cluster. Valid values of N: 0 to 100.</para>
            /// <para>SchedInterval specifies the scheduling period. Unit: seconds.</para>
            /// <para>A scheduling period is the interval between two consecutive running jobs. If you set SchedInterval to 60, another job can be run 60 seconds after a job starts running.</para>
            /// <para>Default value: 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("SchedInterval")]
            [Validation(Required=false)]
            public int? SchedInterval { get; set; }

            /// <summary>
            /// <para>The maximum number of jobs that can be scheduled in the cluster. If the total number of running jobs and queuing jobs exceeds the value, no more jobs can be submitted. Default value: 20000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20000</para>
            /// </summary>
            [NameInMap("SchedMaxJobs")]
            [Validation(Required=false)]
            public int? SchedMaxJobs { get; set; }

            /// <summary>
            /// <para>The maximum number of queuing jobs that can be scheduled in the cluster. If the number of queuing jobs exceeds the value, no more jobs can be submitted. Default value: 10000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("SchedMaxQueuedJobs")]
            [Validation(Required=false)]
            public int? SchedMaxQueuedJobs { get; set; }

        }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/188593.html">ListRegions</a> operation to obtain the IDs of regions supported by Elastic High Performance Computing (E-HPC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The scheduler information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public List<SetSchedulerInfoRequestScheduler> Scheduler { get; set; }
        public class SetSchedulerInfoRequestScheduler : TeaModel {
            /// <summary>
            /// <para>The name of the scheduler. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>pbs</description></item>
            /// <item><description>pbs19</description></item>
            /// <item><description>slurm</description></item>
            /// <item><description>slurm19</description></item>
            /// <item><description>slurm20</description></item>
            /// </list>
            /// <remarks>
            /// <para> If you set Scheduler.N.SchedName to pbs or pbs19, you must specify at least one of the PbsInfo.N.SchedInterval, PbsInfo.N.JobHistoryDuration, PbsInfo.N.ResourceLimit, and PbsInfo.N.AclLimit parameters. If you set Scheduler.N.SchedName to slurm, slurm19, or slurm20, you must specify at least one of the SlurmInfo.N.SchedInterval and SlurmInfo.N.BackfillInterval parameters.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pbs</para>
            /// </summary>
            [NameInMap("SchedName")]
            [Validation(Required=false)]
            public string SchedName { get; set; }

        }

        /// <summary>
        /// <para>The information about Slurm schedulers.</para>
        /// </summary>
        [NameInMap("SlurmInfo")]
        [Validation(Required=false)]
        public List<SetSchedulerInfoRequestSlurmInfo> SlurmInfo { get; set; }
        public class SetSchedulerInfoRequestSlurmInfo : TeaModel {
            /// <summary>
            /// <para>The backfill scheduling period. Unit: seconds.</para>
            /// <para>Default value: 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("BackfillInterval")]
            [Validation(Required=false)]
            public int? BackfillInterval { get; set; }

            /// <summary>
            /// <para>SlurmInfo specifies the number of Slurm schedulers that can be configured in the cluster. Valid values of N: 0 to 100.</para>
            /// <para>SchedInterval specifies the scheduling period. Unit: seconds.</para>
            /// <para>Default value: 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("SchedInterval")]
            [Validation(Required=false)]
            public int? SchedInterval { get; set; }

        }

    }

}
