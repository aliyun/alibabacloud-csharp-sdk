// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ReadSchedulerxDesignateInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the access denial.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public ReadSchedulerxDesignateInfoResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class ReadSchedulerxDesignateInfoResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The requested operation that was denied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>edas:ReadSchedulerxDesignateInfo</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The display name of the Principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>209312833131416xxx</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the Principal belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1827811800526xxx</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>The type of the Principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SubUser</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>The encoded diagnostic message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AQFn/cLPZ/3Cz0YxQkZBMjVGLTY0REUtNTlGNS05NzUwLTgyMUE4M0MwMTFDRQ==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>The type of permission denial.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ImplicitDeny</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>The type of Policy that caused the denial.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AccountLevelIdentityBasedPolicy</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The returned data object.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ReadSchedulerxDesignateInfoResponseBodyData Data { get; set; }
        public class ReadSchedulerxDesignateInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <list type="bullet">
            /// <item><description>The details of the designated Workers.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("DesignateDetailVos")]
            [Validation(Required=false)]
            public List<ReadSchedulerxDesignateInfoResponseBodyDataDesignateDetailVos> DesignateDetailVos { get; set; }
            public class ReadSchedulerxDesignateInfoResponseBodyDataDesignateDetailVos : TeaModel {
                /// <summary>
                /// <para>The status of the Worker. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>FREE</c>: The Worker is idle.</para>
                /// </description></item>
                /// <item><description><para><c>LOAD5_BUSY</c>: The 5-minute average CPU Load is high.</para>
                /// </description></item>
                /// <item><description><para><c>HEAP5_BUSY</c>: The 5-minute average Heap Memory usage is high.</para>
                /// </description></item>
                /// <item><description><para><c>DISK_BUSY</c>: The Disk Usage is high.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FREE</para>
                /// </summary>
                [NameInMap("Busy")]
                [Validation(Required=false)]
                public string Busy { get; set; }

                /// <summary>
                /// <para>Indicates whether the Worker is designated. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: The Worker is designated.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: The Worker is not designated.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Checked")]
                [Validation(Required=false)]
                public bool? Checked { get; set; }

                /// <summary>
                /// <para>The value of the key. The meaning of this parameter depends on the value of the <c>DesignateType</c> parameter.</para>
                /// <list type="bullet">
                /// <item><description><para>If <c>DesignateType</c> is <c>1</c>, this parameter indicates the address of the Worker.</para>
                /// </description></item>
                /// <item><description><para>If <c>DesignateType</c> is <c>2</c>, this parameter indicates the Tag of the Worker.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>10.52.169.25</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The performance metrics for the Worker.</para>
                /// </summary>
                [NameInMap("Metrics")]
                [Validation(Required=false)]
                public ReadSchedulerxDesignateInfoResponseBodyDataDesignateDetailVosMetrics Metrics { get; set; }
                public class ReadSchedulerxDesignateInfoResponseBodyDataDesignateDetailVosMetrics : TeaModel {
                    /// <summary>
                    /// <para>The most recent CPU Load.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CpuLoad1")]
                    [Validation(Required=false)]
                    public double? CpuLoad1 { get; set; }

                    /// <summary>
                    /// <para>The average CPU Load over the last five minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CpuLoad5")]
                    [Validation(Required=false)]
                    public double? CpuLoad5 { get; set; }

                    /// <summary>
                    /// <para>The number of available CPU cores.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CpuProcessors")]
                    [Validation(Required=false)]
                    public int? CpuProcessors { get; set; }

                    /// <summary>
                    /// <para>The total disk capacity, in MB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1024</para>
                    /// </summary>
                    [NameInMap("DiskMax")]
                    [Validation(Required=false)]
                    public int? DiskMax { get; set; }

                    /// <summary>
                    /// <para>The Disk Usage, as a percentage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.19142496008515167</para>
                    /// </summary>
                    [NameInMap("DiskUsage")]
                    [Validation(Required=false)]
                    public double? DiskUsage { get; set; }

                    /// <summary>
                    /// <para>The used disk space, in MB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>148</para>
                    /// </summary>
                    [NameInMap("DiskUsed")]
                    [Validation(Required=false)]
                    public int? DiskUsed { get; set; }

                    /// <summary>
                    /// <para>The number of task executions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>56</para>
                    /// </summary>
                    [NameInMap("ExecCount")]
                    [Validation(Required=false)]
                    public long? ExecCount { get; set; }

                    /// <summary>
                    /// <para>The most recent Heap Memory usage, as a percentage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.06072874493927125</para>
                    /// </summary>
                    [NameInMap("Heap1Usage")]
                    [Validation(Required=false)]
                    public double? Heap1Usage { get; set; }

                    /// <summary>
                    /// <para>The amount of Heap Memory used in the most recent measurement, in MB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>14</para>
                    /// </summary>
                    [NameInMap("Heap1Used")]
                    [Validation(Required=false)]
                    public double? Heap1Used { get; set; }

                    /// <summary>
                    /// <para>The average Heap Memory usage over the last five minutes, as a percentage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.06477732793522267</para>
                    /// </summary>
                    [NameInMap("Heap5Usage")]
                    [Validation(Required=false)]
                    public double? Heap5Usage { get; set; }

                    /// <summary>
                    /// <para>The maximum available Heap Memory, in MB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>500</para>
                    /// </summary>
                    [NameInMap("HeapMax")]
                    [Validation(Required=false)]
                    public int? HeapMax { get; set; }

                    /// <summary>
                    /// <para>The number of available resources in the shared pool.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>72</para>
                    /// </summary>
                    [NameInMap("SharePoolAvailableSize")]
                    [Validation(Required=false)]
                    public int? SharePoolAvailableSize { get; set; }

                    /// <summary>
                    /// <para>The size of the queue in the shared pool.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("SharePoolQueueSize")]
                    [Validation(Required=false)]
                    public int? SharePoolQueueSize { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the Worker is offline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fasle</para>
                /// </summary>
                [NameInMap("Offline")]
                [Validation(Required=false)]
                public bool? Offline { get; set; }

                /// <summary>
                /// <para>The number of Workers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <para>The startup mode of the Worker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pod</para>
                /// </summary>
                [NameInMap("Starter")]
                [Validation(Required=false)]
                public string Starter { get; set; }

                /// <summary>
                /// <para>The version of the Worker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.12.5</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The type of designated resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>1</c>: The task is designated to run on a specific Worker.</para>
            /// </description></item>
            /// <item><description><para><c>2</c>: The task is designated to run on Workers with a specific tag.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>The default configuration for a task is to designate a specific Worker (<c>1</c>).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DesignateType")]
            [Validation(Required=false)]
            public int? DesignateType { get; set; }

            /// <summary>
            /// <para>Indicates whether Failover is enabled. If enabled, the task can be scheduled on non-designated Workers if all designated Workers are offline. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>By default, Failover is disabled (false).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Transferable")]
            [Validation(Required=false)]
            public bool? Transferable { get; set; }

        }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jobId=xxx is not existed</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4F68ABED-AC31-4412-9297-D9A8F0401108</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
