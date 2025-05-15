// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class ListWorkloadsResponseBody : TeaModel {
        /// <summary>
        /// <para>Access Denied Information</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListWorkloadsResponseBodyData> Data { get; set; }
        public class ListWorkloadsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Default CPU Allocation</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("DefaultCpuPerWorker")]
            [Validation(Required=false)]
            public int? DefaultCpuPerWorker { get; set; }

            /// <summary>
            /// <para>Default GPU Allocation</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("DefaultGpuPerWorker")]
            [Validation(Required=false)]
            public int? DefaultGpuPerWorker { get; set; }

            /// <summary>
            /// <para>Default Memory (GB) Allocation</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("DefaultMemoryPerWorker")]
            [Validation(Required=false)]
            public int? DefaultMemoryPerWorker { get; set; }

            /// <summary>
            /// <para>Default Shared Memory (GB) Allocation</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("DefaultShareMemory")]
            [Validation(Required=false)]
            public int? DefaultShareMemory { get; set; }

            /// <summary>
            /// <para>Workload Cluster, AI, GPU</para>
            /// 
            /// <b>Example:</b>
            /// <para>AI</para>
            /// </summary>
            [NameInMap("Family")]
            [Validation(Required=false)]
            public string Family { get; set; }

            /// <summary>
            /// <para>Training Job Type</para>
            /// 
            /// <b>Example:</b>
            /// <para>PyTorchJob</para>
            /// </summary>
            [NameInMap("JobKind")]
            [Validation(Required=false)]
            public string JobKind { get; set; }

            /// <summary>
            /// <para>Parameter Settings</para>
            /// </summary>
            [NameInMap("ParamSettings")]
            [Validation(Required=false)]
            public List<ListWorkloadsResponseBodyDataParamSettings> ParamSettings { get; set; }
            public class ListWorkloadsResponseBodyDataParamSettings : TeaModel {
                /// <summary>
                /// <para>Default Parameter Value</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <para>Parameter Description</para>
                /// 
                /// <b>Example:</b>
                /// <para>number</para>
                /// </summary>
                [NameInMap("ParamDesc")]
                [Validation(Required=false)]
                public string ParamDesc { get; set; }

                /// <summary>
                /// <para>Parameter Name</para>
                /// 
                /// <b>Example:</b>
                /// <para>ITERATION</para>
                /// </summary>
                [NameInMap("ParamName")]
                [Validation(Required=false)]
                public string ParamName { get; set; }

                /// <summary>
                /// <para>Parameter Regular Expression</para>
                /// 
                /// <b>Example:</b>
                /// <para>[0-9]+</para>
                /// </summary>
                [NameInMap("ParamRegex")]
                [Validation(Required=false)]
                public string ParamRegex { get; set; }

                /// <summary>
                /// <para>Parameter type</para>
                /// 
                /// <b>Example:</b>
                /// <para>number</para>
                /// </summary>
                [NameInMap("ParamType")]
                [Validation(Required=false)]
                public string ParamType { get; set; }

                /// <summary>
                /// <para>Parameter Value</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ParamValue")]
                [Validation(Required=false)]
                public string ParamValue { get; set; }

            }

            /// <summary>
            /// <para>Workload Usage Scenario</para>
            /// 
            /// <b>Example:</b>
            /// <para>NLP-LLM</para>
            /// </summary>
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <para>Scope Identifier for Workload Usage</para>
            /// 
            /// <b>Example:</b>
            /// <para>common</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>Static Configuration</para>
            /// </summary>
            [NameInMap("StaticConfig")]
            [Validation(Required=false)]
            public ListWorkloadsResponseBodyDataStaticConfig StaticConfig { get; set; }
            public class ListWorkloadsResponseBodyDataStaticConfig : TeaModel {
                /// <summary>
                /// <para>Framework</para>
                /// 
                /// <b>Example:</b>
                /// <para>PyTorch</para>
                /// </summary>
                [NameInMap("FrameWork")]
                [Validation(Required=false)]
                public string FrameWork { get; set; }

                /// <summary>
                /// <para>Operating System</para>
                /// 
                /// <b>Example:</b>
                /// <para>linux</para>
                /// </summary>
                [NameInMap("Os")]
                [Validation(Required=false)]
                public string Os { get; set; }

                /// <summary>
                /// <para>Number of Parameters</para>
                /// 
                /// <b>Example:</b>
                /// <para>7B</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

                /// <summary>
                /// <para>Software Stack</para>
                /// 
                /// <b>Example:</b>
                /// <para>python</para>
                /// </summary>
                [NameInMap("SoftwareStack")]
                [Validation(Required=false)]
                public string SoftwareStack { get; set; }

            }

            /// <summary>
            /// <para>Version ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public long? VersionId { get; set; }

            /// <summary>
            /// <para>Workload Description</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("WorkloadDescription")]
            [Validation(Required=false)]
            public string WorkloadDescription { get; set; }

            /// <summary>
            /// <para>Workload ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("WorkloadId")]
            [Validation(Required=false)]
            public long? WorkloadId { get; set; }

            /// <summary>
            /// <para>Workload Name</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("WorkloadName")]
            [Validation(Required=false)]
            public string WorkloadName { get; set; }

            /// <summary>
            /// <para>Workload Type</para>
            /// 
            /// <b>Example:</b>
            /// <para>AI</para>
            /// </summary>
            [NameInMap("WorkloadType")]
            [Validation(Required=false)]
            public string WorkloadType { get; set; }

        }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>4AC08332-436C-57A3-9FBA-26772B1A9901</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>total</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
