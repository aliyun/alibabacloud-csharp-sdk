// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ReadSchedulerxDesignateDetailResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public ReadSchedulerxDesignateDetailResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class ReadSchedulerxDesignateDetailResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>edas:ReadSchedulerxDesignateDetail</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>209312833131416xxx</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1827811800526xxx</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SubUser</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AQFn/cLPZ/3Cz0YxQkZBMjVGLTY0REUtNTlGNS05NzUwLTgyMUE4M0MwMTFDRQ==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ImplicitDeny</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AccountLevelIdentityBasedPolicy</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ReadSchedulerxDesignateDetailResponseBodyData Data { get; set; }
        public class ReadSchedulerxDesignateDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("DesignateDetailVos")]
            [Validation(Required=false)]
            public List<ReadSchedulerxDesignateDetailResponseBodyDataDesignateDetailVos> DesignateDetailVos { get; set; }
            public class ReadSchedulerxDesignateDetailResponseBodyDataDesignateDetailVos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>FREE</para>
                /// </summary>
                [NameInMap("Busy")]
                [Validation(Required=false)]
                public string Busy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Checked")]
                [Validation(Required=false)]
                public bool? Checked { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10.52.169.25</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Metrics")]
                [Validation(Required=false)]
                public ReadSchedulerxDesignateDetailResponseBodyDataDesignateDetailVosMetrics Metrics { get; set; }
                public class ReadSchedulerxDesignateDetailResponseBodyDataDesignateDetailVosMetrics : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CpuLoad1")]
                    [Validation(Required=false)]
                    public double? CpuLoad1 { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CpuLoad5")]
                    [Validation(Required=false)]
                    public double? CpuLoad5 { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CpuProcessors")]
                    [Validation(Required=false)]
                    public int? CpuProcessors { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1024</para>
                    /// </summary>
                    [NameInMap("DiskMax")]
                    [Validation(Required=false)]
                    public int? DiskMax { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.19142496008515167</para>
                    /// </summary>
                    [NameInMap("DiskUsage")]
                    [Validation(Required=false)]
                    public double? DiskUsage { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.14865875</para>
                    /// </summary>
                    [NameInMap("DiskUsed")]
                    [Validation(Required=false)]
                    public int? DiskUsed { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>56</para>
                    /// </summary>
                    [NameInMap("ExecCount")]
                    [Validation(Required=false)]
                    public long? ExecCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.06072874493927125</para>
                    /// </summary>
                    [NameInMap("Heap1Usage")]
                    [Validation(Required=false)]
                    public double? Heap1Usage { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>14</para>
                    /// </summary>
                    [NameInMap("Heap1Used")]
                    [Validation(Required=false)]
                    public double? Heap1Used { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.06477732793522267</para>
                    /// </summary>
                    [NameInMap("Heap5Usage")]
                    [Validation(Required=false)]
                    public double? Heap5Usage { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>500</para>
                    /// </summary>
                    [NameInMap("HeapMax")]
                    [Validation(Required=false)]
                    public int? HeapMax { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>72</para>
                    /// </summary>
                    [NameInMap("SharePoolAvailableSize")]
                    [Validation(Required=false)]
                    public int? SharePoolAvailableSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("SharePoolQueueSize")]
                    [Validation(Required=false)]
                    public int? SharePoolQueueSize { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>fasle</para>
                /// </summary>
                [NameInMap("Offline")]
                [Validation(Required=false)]
                public bool? Offline { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pod</para>
                /// </summary>
                [NameInMap("Starter")]
                [Validation(Required=false)]
                public string Starter { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.12.5</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Invalid parameter: jobId=368 invalid</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>883AFE93-FB03-4FA9-A958-E750C6DE120C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
