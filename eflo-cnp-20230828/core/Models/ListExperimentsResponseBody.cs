// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class ListExperimentsResponseBody : TeaModel {
        /// <summary>
        /// <para>Access denied information</para>
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
        public List<ListExperimentsResponseBodyData> Data { get; set; }
        public class ListExperimentsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Creation time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-22 10:18:10</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Task end time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-22 10:28:10</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>Environment parameters in operation</para>
            /// </summary>
            [NameInMap("EnvParams")]
            [Validation(Required=false)]
            public ListExperimentsResponseBodyDataEnvParams EnvParams { get; set; }
            public class ListExperimentsResponseBodyDataEnvParams : TeaModel {
                /// <summary>
                /// <para>Number of CPUs allocated</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("CpuPerWorker")]
                [Validation(Required=false)]
                public int? CpuPerWorker { get; set; }

                /// <summary>
                /// <para>CUDA version</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("CudaVersion")]
                [Validation(Required=false)]
                public string CudaVersion { get; set; }

                /// <summary>
                /// <para>Additional parameters</para>
                /// </summary>
                [NameInMap("ExtendParam")]
                [Validation(Required=false)]
                public Dictionary<string, string> ExtendParam { get; set; }

                /// <summary>
                /// <para>GPU driver version</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("GpuDriverVersion")]
                [Validation(Required=false)]
                public string GpuDriverVersion { get; set; }

                /// <summary>
                /// <para>Number of GPUs allocated</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("GpuPerWorker")]
                [Validation(Required=false)]
                public int? GpuPerWorker { get; set; }

                /// <summary>
                /// <para>Amount of memory (GB) allocated</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("MemoryPerWorker")]
                [Validation(Required=false)]
                public int? MemoryPerWorker { get; set; }

                /// <summary>
                /// <para>NCCL version</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("NCCLVersion")]
                [Validation(Required=false)]
                public string NCCLVersion { get; set; }

                /// <summary>
                /// <para>PyTorch version</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("PyTorchVersion")]
                [Validation(Required=false)]
                public string PyTorchVersion { get; set; }

                /// <summary>
                /// <para>Specified nodes</para>
                /// </summary>
                [NameInMap("ResourceNodes")]
                [Validation(Required=false)]
                public List<ListExperimentsResponseBodyDataEnvParamsResourceNodes> ResourceNodes { get; set; }
                public class ListExperimentsResponseBodyDataEnvParamsResourceNodes : TeaModel {
                    /// <summary>
                    /// <para>Node name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>lingj1xxnjt1k4nv-mg18v52pydyuumae-0</para>
                    /// </summary>
                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                    /// <summary>
                    /// <para>Requested CPU</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>90</para>
                    /// </summary>
                    [NameInMap("RequestCPU")]
                    [Validation(Required=false)]
                    public int? RequestCPU { get; set; }

                    /// <summary>
                    /// <para>Requested GPU</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("RequestGPU")]
                    [Validation(Required=false)]
                    public int? RequestGPU { get; set; }

                    /// <summary>
                    /// <para>Requested memory</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>500</para>
                    /// </summary>
                    [NameInMap("RequestMemory")]
                    [Validation(Required=false)]
                    public int? RequestMemory { get; set; }

                    /// <summary>
                    /// <para>Total CPU</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>90</para>
                    /// </summary>
                    [NameInMap("TotalCPU")]
                    [Validation(Required=false)]
                    public int? TotalCPU { get; set; }

                    /// <summary>
                    /// <para>Total GPU</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("TotalGPU")]
                    [Validation(Required=false)]
                    public int? TotalGPU { get; set; }

                    /// <summary>
                    /// <para>Total memory</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>500</para>
                    /// </summary>
                    [NameInMap("TotalMemory")]
                    [Validation(Required=false)]
                    public long? TotalMemory { get; set; }

                }

                /// <summary>
                /// <para>Amount of shared memory (GB) allocated</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("ShareMemory")]
                [Validation(Required=false)]
                public int? ShareMemory { get; set; }

                /// <summary>
                /// <para>Number of nodes</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("WorkerNum")]
                [Validation(Required=false)]
                public int? WorkerNum { get; set; }

            }

            /// <summary>
            /// <para>Experiment ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684537476910997506</para>
            /// </summary>
            [NameInMap("ExperimentId")]
            [Validation(Required=false)]
            public long? ExperimentId { get; set; }

            /// <summary>
            /// <para>Experiment name</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ExperimentName")]
            [Validation(Required=false)]
            public string ExperimentName { get; set; }

            /// <summary>
            /// <para>Experiment type</para>
            /// 
            /// <b>Example:</b>
            /// <para>AI</para>
            /// </summary>
            [NameInMap("ExperimentType")]
            [Validation(Required=false)]
            public string ExperimentType { get; set; }

            /// <summary>
            /// <para>Parsed load parameters</para>
            /// </summary>
            [NameInMap("GetParams")]
            [Validation(Required=false)]
            public Dictionary<string, string> GetParams { get; set; }

            /// <summary>
            /// <para>Resource name</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.r8y.4xlarge</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <para>Task results</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public ListExperimentsResponseBodyDataResults Results { get; set; }
            public class ListExperimentsResponseBodyDataResults : TeaModel {
                /// <summary>
                /// <para>Duration</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

                /// <summary>
                /// <para>Error nodes</para>
                /// </summary>
                [NameInMap("ErrorWorker")]
                [Validation(Required=false)]
                public List<ListExperimentsResponseBodyDataResultsErrorWorker> ErrorWorker { get; set; }
                public class ListExperimentsResponseBodyDataResultsErrorWorker : TeaModel {
                    /// <summary>
                    /// <para>Whether there is an error</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("ErrorFlag")]
                    [Validation(Required=false)]
                    public bool? ErrorFlag { get; set; }

                    /// <summary>
                    /// <para>Error information</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>error msg</para>
                    /// </summary>
                    [NameInMap("ErrorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                    /// <summary>
                    /// <para>Experiment ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>176</para>
                    /// </summary>
                    [NameInMap("ExperimentId")]
                    [Validation(Required=false)]
                    public long? ExperimentId { get; set; }

                    /// <summary>
                    /// <para>GPU name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8x OAM 810 GPU</para>
                    /// </summary>
                    [NameInMap("GpuName")]
                    [Validation(Required=false)]
                    public string GpuName { get; set; }

                    /// <summary>
                    /// <para>Number of GPUs</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("GpuNum")]
                    [Validation(Required=false)]
                    public int? GpuNum { get; set; }

                    /// <summary>
                    /// <para>Host IP</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>etcd_cluster_c0n2</para>
                    /// </summary>
                    [NameInMap("Hostname")]
                    [Validation(Required=false)]
                    public string Hostname { get; set; }

                    /// <summary>
                    /// <para>Pod name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>fluxserv-6fc89b45cf-w8wq6</para>
                    /// </summary>
                    [NameInMap("PodName")]
                    [Validation(Required=false)]
                    public string PodName { get; set; }

                    /// <summary>
                    /// <para>Throughput</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>65</para>
                    /// </summary>
                    [NameInMap("SamplesPerSecond")]
                    [Validation(Required=false)]
                    public double? SamplesPerSecond { get; set; }

                    /// <summary>
                    /// <para>TFLOPS value</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>42</para>
                    /// </summary>
                    [NameInMap("Tflops")]
                    [Validation(Required=false)]
                    public double? Tflops { get; set; }

                    /// <summary>
                    /// <para>Whether there is an alarm</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("WarningFlag")]
                    [Validation(Required=false)]
                    public bool? WarningFlag { get; set; }

                    /// <summary>
                    /// <para>Alarm information</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>warning msg</para>
                    /// </summary>
                    [NameInMap("WarningMsg")]
                    [Validation(Required=false)]
                    public string WarningMsg { get; set; }

                }

                /// <summary>
                /// <para>Parameter name</para>
                /// 
                /// <b>Example:</b>
                /// <para>440</para>
                /// </summary>
                [NameInMap("ExperimentId")]
                [Validation(Required=false)]
                public long? ExperimentId { get; set; }

                /// <summary>
                /// <para>MFU</para>
                /// 
                /// <b>Example:</b>
                /// <para>34</para>
                /// </summary>
                [NameInMap("Mfu")]
                [Validation(Required=false)]
                public double? Mfu { get; set; }

                /// <summary>
                /// <para>Samples per second</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("SamplesPerSecond")]
                [Validation(Required=false)]
                public double? SamplesPerSecond { get; set; }

                /// <summary>
                /// <para>Seconds per iteration</para>
                /// 
                /// <b>Example:</b>
                /// <para>89</para>
                /// </summary>
                [NameInMap("SecondsPerIteration")]
                [Validation(Required=false)]
                public double? SecondsPerIteration { get; set; }

                /// <summary>
                /// <para>Warning worker</para>
                /// </summary>
                [NameInMap("WarningWorker")]
                [Validation(Required=false)]
                public List<ListExperimentsResponseBodyDataResultsWarningWorker> WarningWorker { get; set; }
                public class ListExperimentsResponseBodyDataResultsWarningWorker : TeaModel {
                    /// <summary>
                    /// <para>Whether there is an error</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("ErrorFlag")]
                    [Validation(Required=false)]
                    public bool? ErrorFlag { get; set; }

                    /// <summary>
                    /// <para>Error message</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>error msg</para>
                    /// </summary>
                    [NameInMap("ErrorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                    /// <summary>
                    /// <para>Experiment ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>113</para>
                    /// </summary>
                    [NameInMap("ExperimentId")]
                    [Validation(Required=false)]
                    public long? ExperimentId { get; set; }

                    /// <summary>
                    /// <para>GPU name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8x OAM 810 GPU</para>
                    /// </summary>
                    [NameInMap("GpuName")]
                    [Validation(Required=false)]
                    public string GpuName { get; set; }

                    /// <summary>
                    /// <para>Number of GPUs</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>90</para>
                    /// </summary>
                    [NameInMap("GpuNum")]
                    [Validation(Required=false)]
                    public int? GpuNum { get; set; }

                    /// <summary>
                    /// <para>Host IP</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>101.66.165.102</para>
                    /// </summary>
                    [NameInMap("Hostname")]
                    [Validation(Required=false)]
                    public string Hostname { get; set; }

                    /// <summary>
                    /// <para>Pod name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hzs-forge-sdxl-online-7ff4d86444-pc95h</para>
                    /// </summary>
                    [NameInMap("PodName")]
                    [Validation(Required=false)]
                    public string PodName { get; set; }

                    /// <summary>
                    /// <para>Throughput</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>53</para>
                    /// </summary>
                    [NameInMap("SamplesPerSecond")]
                    [Validation(Required=false)]
                    public double? SamplesPerSecond { get; set; }

                    /// <summary>
                    /// <para>TFLOPS value</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>43</para>
                    /// </summary>
                    [NameInMap("Tflops")]
                    [Validation(Required=false)]
                    public double? Tflops { get; set; }

                    /// <summary>
                    /// <para>Whether there is an alarm</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("WarningFlag")]
                    [Validation(Required=false)]
                    public bool? WarningFlag { get; set; }

                    /// <summary>
                    /// <para>Alarm message</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>warning msg</para>
                    /// </summary>
                    [NameInMap("WarningMsg")]
                    [Validation(Required=false)]
                    public string WarningMsg { get; set; }

                }

            }

            /// <summary>
            /// <para>Load parameters in operation</para>
            /// </summary>
            [NameInMap("SetParams")]
            [Validation(Required=false)]
            public Dictionary<string, string> SetParams { get; set; }

            /// <summary>
            /// <para>Task start time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-22 10:18:10</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>Status</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Update time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-22 10:18:10</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>Workload name</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("WorkloadName")]
            [Validation(Required=false)]
            public string WorkloadName { get; set; }

        }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>5514CB39-B7C0-5B89-8534-2DE1E0F2B7AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
