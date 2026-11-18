// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class ListExecutorsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of executors.</para>
        /// </summary>
        [NameInMap("Executors")]
        [Validation(Required=false)]
        public List<ListExecutorsResponseBodyExecutors> Executors { get; set; }
        public class ListExecutorsResponseBodyExecutors : TeaModel {
            /// <summary>
            /// <para>The resource type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Standard: Standard.</description></item>
            /// <item><description>Dedicated: Dedicated. A whitelist is required.</description></item>
            /// <item><description>Economic: Economic. A whitelist is required.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("AllocationSpec")]
            [Validation(Required=false)]
            public string AllocationSpec { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alphafold3</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The executor index.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ArrayIndex")]
            [Validation(Required=false)]
            public int? ArrayIndex { get; set; }

            /// <summary>
            /// <para>The retention period of compute resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("BlockDuration")]
            [Validation(Required=false)]
            public int? BlockDuration { get; set; }

            /// <summary>
            /// <para>The creation time. The time is in the YYYY-MM-DD HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-02-20 10:04:10</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The end time. The time is in the YYYY-MM-DD HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-02-20 10:04:18</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The executor ID. The format is JobId-TaskName-ArrayIndex.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-xxxx-Task0-1</para>
            /// </summary>
            [NameInMap("ExecutorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }

            /// <summary>
            /// <para>The expiration time. The time is returned in the YYYY-MM-DD HH:mm:ss format based on the UTC+8 time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>202******:00</para>
            /// </summary>
            [NameInMap("ExpirationTime")]
            [Validation(Required=false)]
            public string ExpirationTime { get; set; }

            /// <summary>
            /// <para>The list of public IP addresses of the node.</para>
            /// </summary>
            [NameInMap("ExternalIpAddress")]
            [Validation(Required=false)]
            public List<string> ExternalIpAddress { get; set; }

            /// <summary>
            /// <para>The list of hostnames.</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public List<string> HostName { get; set; }

            /// <summary>
            /// <para>The executor image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-f8z0dfa96luxxxxx</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// <para>The list of internal IP addresses.</para>
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public List<string> IpAddress { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-hy1nggvyukuvkr******</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The job name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testJob</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>Indicates whether the execution instance is preemptible.</para>
            /// </summary>
            [NameInMap("Preemptible")]
            [Validation(Required=false)]
            public bool? Preemptible { get; set; }

            /// <summary>
            /// <para>The resource information.</para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public ListExecutorsResponseBodyExecutorsResource Resource { get; set; }
            public class ListExecutorsResponseBodyExecutorsResource : TeaModel {
                /// <summary>
                /// <para>The number of CPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Cores")]
                [Validation(Required=false)]
                public float? Cores { get; set; }

                /// <summary>
                /// <para>The array of cloud disks.</para>
                /// </summary>
                [NameInMap("Disks")]
                [Validation(Required=false)]
                public List<ListExecutorsResponseBodyExecutorsResourceDisks> Disks { get; set; }
                public class ListExecutorsResponseBodyExecutorsResourceDisks : TeaModel {
                    /// <summary>
                    /// <para>The cloud disk size.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public int? Size { get; set; }

                    /// <summary>
                    /// <para>The cloud disk type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>System: System cloud disk.</description></item>
                    /// <item><description>Data: Data cloud disk.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>System</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The instance type of the runtime environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.c7a.8xlarge</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The total memory resources. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public float? Memory { get; set; }

            }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECI</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The start time. The time is in the YYYY-MM-DD HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-02-20 10:04:13</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The executor status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: Queued.</description></item>
            /// <item><description>Initing: Initializing.</description></item>
            /// <item><description>Succeeded: Succeeded.</description></item>
            /// <item><description>Failed: Failed.</description></item>
            /// <item><description>Running: Running.</description></item>
            /// <item><description>Exception: Scheduling exception.</description></item>
            /// <item><description>Retrying: Retrying.</description></item>
            /// <item><description>Expired: Timed out.</description></item>
            /// <item><description>Suspended: Job suspended.</description></item>
            /// <item><description>Restarting: Job restarting.</description></item>
            /// <item><description>Deleted: Deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The description of the status reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ExecutorReady</para>
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            /// <summary>
            /// <para>The list of executor tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListExecutorsResponseBodyExecutorsTags> Tags { get; set; }
            public class ListExecutorsResponseBodyExecutorsTags : TeaModel {
                /// <summary>
                /// <para>The executor tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The executor tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Task0</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>Indicates whether the job is a long-running job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("TaskSustainable")]
            [Validation(Required=false)]
            public bool? TaskSustainable { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-xxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-xxx</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in the paging Settings for a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>896D338C-E4F4-41EC-A154-D605E5DE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
