// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class GetExperimentResponseBody : TeaModel {
        /// <summary>
        /// <para>Access denied detail</para>
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
        public GetExperimentResponseBodyData Data { get; set; }
        public class GetExperimentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Creation time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-29 02:16:35</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Task end time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-29 02:26:35</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>Running environment parameters</para>
            /// </summary>
            [NameInMap("EnvParams")]
            [Validation(Required=false)]
            public GetExperimentResponseBodyDataEnvParams EnvParams { get; set; }
            public class GetExperimentResponseBodyDataEnvParams : TeaModel {
                /// <summary>
                /// <para>CPU allocation number</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("CpuPerWorker")]
                [Validation(Required=false)]
                public int? CpuPerWorker { get; set; }

                /// <summary>
                /// <para>cudaVersion</para>
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
                /// <para>GPU allocation number</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("GpuPerWorker")]
                [Validation(Required=false)]
                public int? GpuPerWorker { get; set; }

                /// <summary>
                /// <para>Memory Per Worker</para>
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
                public List<GetExperimentResponseBodyDataEnvParamsResourceNodes> ResourceNodes { get; set; }
                public class GetExperimentResponseBodyDataEnvParamsResourceNodes : TeaModel {
                    /// <summary>
                    /// <para>Node name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>p-jt-waf-app1</para>
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
                /// <para>Share Memory</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("ShareMemory")]
                [Validation(Required=false)]
                public int? ShareMemory { get; set; }

                /// <summary>
                /// <para>Worker number</para>
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
            /// <para>1726882991828688898</para>
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
            /// <para>Parsed workload parameters</para>
            /// </summary>
            [NameInMap("GetParams")]
            [Validation(Required=false)]
            public Dictionary<string, string> GetParams { get; set; }

            /// <summary>
            /// <para>cluster info</para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public GetExperimentResponseBodyDataResource Resource { get; set; }
            public class GetExperimentResponseBodyDataResource : TeaModel {
                /// <summary>
                /// <para>Used CPU</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("CpuCoreLimit")]
                [Validation(Required=false)]
                public int? CpuCoreLimit { get; set; }

                /// <summary>
                /// <para>Used GPU</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("GpuLimit")]
                [Validation(Required=false)]
                public int? GpuLimit { get; set; }

                /// <summary>
                /// <para>Instance type</para>
                /// </summary>
                [NameInMap("MachineType")]
                [Validation(Required=false)]
                public GetExperimentResponseBodyDataResourceMachineType MachineType { get; set; }
                public class GetExperimentResponseBodyDataResourceMachineType : TeaModel {
                    /// <summary>
                    /// <para>Number of network bonds</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("BondNum")]
                    [Validation(Required=false)]
                    public int? BondNum { get; set; }

                    /// <summary>
                    /// <para>CPU information</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2x Intel Icelake 8369B 32C CPU</para>
                    /// </summary>
                    [NameInMap("CpuInfo")]
                    [Validation(Required=false)]
                    public string CpuInfo { get; set; }

                    /// <summary>
                    /// <para>Disk information</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2x 480GB SATA SSD \n 4x 3.84TB NVMe SSD</para>
                    /// </summary>
                    [NameInMap("DiskInfo")]
                    [Validation(Required=false)]
                    public string DiskInfo { get; set; }

                    /// <summary>
                    /// <para>GPU information</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8x NVIDIA SXM4 80GB A100 GPU</para>
                    /// </summary>
                    [NameInMap("GpuInfo")]
                    [Validation(Required=false)]
                    public string GpuInfo { get; set; }

                    /// <summary>
                    /// <para>Memory information</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>32x 64GB DDR4 3200 Memory</para>
                    /// </summary>
                    [NameInMap("MemoryInfo")]
                    [Validation(Required=false)]
                    public string MemoryInfo { get; set; }

                    /// <summary>
                    /// <para>Specification name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>efg1.nvga1n</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Network information</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1x 100Gbps DP NIC for VPC \n 4x 100Gbps DP RoCE NIC</para>
                    /// </summary>
                    [NameInMap("NetworkInfo")]
                    [Validation(Required=false)]
                    public string NetworkInfo { get; set; }

                    /// <summary>
                    /// <para>Network mode</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("NetworkMode")]
                    [Validation(Required=false)]
                    public string NetworkMode { get; set; }

                    /// <summary>
                    /// <para>Number of nodes</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("NodeCount")]
                    [Validation(Required=false)]
                    public int? NodeCount { get; set; }

                    /// <summary>
                    /// <para>Type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Public</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>Used memory</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("MaxCpuCore")]
                [Validation(Required=false)]
                public int? MaxCpuCore { get; set; }

                /// <summary>
                /// <para>Used memory</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("MaxGpu")]
                [Validation(Required=false)]
                public int? MaxGpu { get; set; }

                /// <summary>
                /// <para>Used memory</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("MaxMemory")]
                [Validation(Required=false)]
                public long? MaxMemory { get; set; }

                /// <summary>
                /// <para>Used memory</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("MemoryLimit")]
                [Validation(Required=false)]
                public long? MemoryLimit { get; set; }

                /// <summary>
                /// <para>Cluster ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>189</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public long? ResourceId { get; set; }

                /// <summary>
                /// <para>Cluster name</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.r8y.4xlarge</para>
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <para>Resource node list</para>
                /// </summary>
                [NameInMap("ResourceNodes")]
                [Validation(Required=false)]
                public List<GetExperimentResponseBodyDataResourceResourceNodes> ResourceNodes { get; set; }
                public class GetExperimentResponseBodyDataResourceResourceNodes : TeaModel {
                    /// <summary>
                    /// <para>Node name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>InputCheck</para>
                    /// </summary>
                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                }

                /// <summary>
                /// <para>User authorization parameters</para>
                /// </summary>
                [NameInMap("UserAccessParam")]
                [Validation(Required=false)]
                public GetExperimentResponseBodyDataResourceUserAccessParam UserAccessParam { get; set; }
                public class GetExperimentResponseBodyDataResourceUserAccessParam : TeaModel {
                    /// <summary>
                    /// <para>User ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dev</para>
                    /// </summary>
                    [NameInMap("AccessId")]
                    [Validation(Required=false)]
                    public string AccessId { get; set; }

                    /// <summary>
                    /// <para>User key</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("AccessKey")]
                    [Validation(Required=false)]
                    public string AccessKey { get; set; }

                    /// <summary>
                    /// <para>Endpoint</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Endpoint")]
                    [Validation(Required=false)]
                    public string Endpoint { get; set; }

                    /// <summary>
                    /// <para>Workspace ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123434542498</para>
                    /// </summary>
                    [NameInMap("WorkspaceId")]
                    [Validation(Required=false)]
                    public string WorkspaceId { get; set; }

                }

            }

            /// <summary>
            /// <para>Resource name</para>
            /// 
            /// <b>Example:</b>
            /// <para>cifnews-guoyuan</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <para>Task results</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public GetExperimentResponseBodyDataResults Results { get; set; }
            public class GetExperimentResponseBodyDataResults : TeaModel {
                /// <summary>
                /// <para>Duration</para>
                /// 
                /// <b>Example:</b>
                /// <para>764</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

                /// <summary>
                /// <para>Error node</para>
                /// </summary>
                [NameInMap("ErrorWorker")]
                [Validation(Required=false)]
                public List<GetExperimentResponseBodyDataResultsErrorWorker> ErrorWorker { get; set; }
                public class GetExperimentResponseBodyDataResultsErrorWorker : TeaModel {
                    /// <summary>
                    /// <para>error flag</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("ErrorFlag")]
                    [Validation(Required=false)]
                    public bool? ErrorFlag { get; set; }

                    /// <summary>
                    /// <para>error message</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Connection reset</para>
                    /// </summary>
                    [NameInMap("ErrorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                    /// <summary>
                    /// <para>Experiment ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>97</para>
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
                    /// <para>Service address</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>60.188.98.209</para>
                    /// </summary>
                    [NameInMap("Hostname")]
                    [Validation(Required=false)]
                    public string Hostname { get; set; }

                    /// <summary>
                    /// <para>Pod name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hzs-forge-sdxl-online-7ff4d86444-pc95h</para>
                    /// </summary>
                    [NameInMap("PodName")]
                    [Validation(Required=false)]
                    public string PodName { get; set; }

                    /// <summary>
                    /// <para>Samples Per Second</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>23</para>
                    /// </summary>
                    [NameInMap("SamplesPerSecond")]
                    [Validation(Required=false)]
                    public double? SamplesPerSecond { get; set; }

                    /// <summary>
                    /// <para>TFLOPS</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("Tflops")]
                    [Validation(Required=false)]
                    public double? Tflops { get; set; }

                    /// <summary>
                    /// <para>Whether there is a warning</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("WarningFlag")]
                    [Validation(Required=false)]
                    public bool? WarningFlag { get; set; }

                    /// <summary>
                    /// <para>Warning message</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>warning message</para>
                    /// </summary>
                    [NameInMap("WarningMsg")]
                    [Validation(Required=false)]
                    public string WarningMsg { get; set; }

                }

                /// <summary>
                /// <para>Parameter name</para>
                /// 
                /// <b>Example:</b>
                /// <para>1748274952976261121</para>
                /// </summary>
                [NameInMap("ExperimentId")]
                [Validation(Required=false)]
                public long? ExperimentId { get; set; }

                /// <summary>
                /// <para>MFU</para>
                /// 
                /// <b>Example:</b>
                /// <para>54.2</para>
                /// </summary>
                [NameInMap("Mfu")]
                [Validation(Required=false)]
                public double? Mfu { get; set; }

                /// <summary>
                /// <para>Samples Per Second</para>
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
                /// <para>1000</para>
                /// </summary>
                [NameInMap("SecondsPerIteration")]
                [Validation(Required=false)]
                public double? SecondsPerIteration { get; set; }

                /// <summary>
                /// <para>Task individual result list</para>
                /// </summary>
                [NameInMap("TaskIndividualResultList")]
                [Validation(Required=false)]
                public List<GetExperimentResponseBodyDataResultsTaskIndividualResultList> TaskIndividualResultList { get; set; }
                public class GetExperimentResponseBodyDataResultsTaskIndividualResultList : TeaModel {
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
                    /// <para>error message</para>
                    /// </summary>
                    [NameInMap("ErrorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                    /// <summary>
                    /// <para>实验ID。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>48</para>
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
                    /// <para>节点主机名称。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>p-jt-waf-app1</para>
                    /// </summary>
                    [NameInMap("Hostname")]
                    [Validation(Required=false)]
                    public string Hostname { get; set; }

                    /// <summary>
                    /// <para>Pod名称。</para>
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
                    /// <para>28</para>
                    /// </summary>
                    [NameInMap("SamplesPerSecond")]
                    [Validation(Required=false)]
                    public double? SamplesPerSecond { get; set; }

                    /// <summary>
                    /// <para>TFLOPS value</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>16</para>
                    /// </summary>
                    [NameInMap("Tflops")]
                    [Validation(Required=false)]
                    public double? Tflops { get; set; }

                    /// <summary>
                    /// <para>Whether there is a warning</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("WarningFlag")]
                    [Validation(Required=false)]
                    public bool? WarningFlag { get; set; }

                    /// <summary>
                    /// <para>Warning message</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>warning message</para>
                    /// </summary>
                    [NameInMap("WarningMsg")]
                    [Validation(Required=false)]
                    public string WarningMsg { get; set; }

                }

                /// <summary>
                /// <para>Invalid task results</para>
                /// </summary>
                [NameInMap("TaskIndividualResultMap")]
                [Validation(Required=false)]
                public Dictionary<string, List<DataResultsTaskIndividualResultMapValue>> TaskIndividualResultMap { get; set; }

                /// <summary>
                /// <para>Warning bound list</para>
                /// </summary>
                [NameInMap("WarningBoundList")]
                [Validation(Required=false)]
                public List<GetExperimentResponseBodyDataResultsWarningBoundList> WarningBoundList { get; set; }
                public class GetExperimentResponseBodyDataResultsWarningBoundList : TeaModel {
                    /// <summary>
                    /// <para>Iteration</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Iteration")]
                    [Validation(Required=false)]
                    public int? Iteration { get; set; }

                    /// <summary>
                    /// <para>LOWER</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>14</para>
                    /// </summary>
                    [NameInMap("Lower")]
                    [Validation(Required=false)]
                    public double? Lower { get; set; }

                    /// <summary>
                    /// <para>UPPER</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>56</para>
                    /// </summary>
                    [NameInMap("Upper")]
                    [Validation(Required=false)]
                    public double? Upper { get; set; }

                }

                /// <summary>
                /// <para>Warning worker</para>
                /// </summary>
                [NameInMap("WarningWorker")]
                [Validation(Required=false)]
                public List<GetExperimentResponseBodyDataResultsWarningWorker> WarningWorker { get; set; }
                public class GetExperimentResponseBodyDataResultsWarningWorker : TeaModel {
                    /// <summary>
                    /// <para>Whether there is an error</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("ErrorFlag")]
                    [Validation(Required=false)]
                    public bool? ErrorFlag { get; set; }

                    /// <summary>
                    /// <para>Error message</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>error message</para>
                    /// </summary>
                    [NameInMap("ErrorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                    /// <summary>
                    /// <para>Experiment ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9</para>
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
                    /// <para>Service address</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>whza008403</para>
                    /// </summary>
                    [NameInMap("Hostname")]
                    [Validation(Required=false)]
                    public string Hostname { get; set; }

                    /// <summary>
                    /// <para>Pod name.</para>
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
                    /// <para>15</para>
                    /// </summary>
                    [NameInMap("SamplesPerSecond")]
                    [Validation(Required=false)]
                    public double? SamplesPerSecond { get; set; }

                    /// <summary>
                    /// <para>TFLOPS value</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>14</para>
                    /// </summary>
                    [NameInMap("Tflops")]
                    [Validation(Required=false)]
                    public double? Tflops { get; set; }

                    /// <summary>
                    /// <para>Whether there is an alarm</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("WarningFlag")]
                    [Validation(Required=false)]
                    public bool? WarningFlag { get; set; }

                    /// <summary>
                    /// <para>Alarm message</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>warging message</para>
                    /// </summary>
                    [NameInMap("WarningMsg")]
                    [Validation(Required=false)]
                    public string WarningMsg { get; set; }

                }

            }

            /// <summary>
            /// <para>Running workload parameters</para>
            /// </summary>
            [NameInMap("SetParams")]
            [Validation(Required=false)]
            public Dictionary<string, string> SetParams { get; set; }

            /// <summary>
            /// <para>Task start time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-29 02:16:35</para>
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
            /// <para>Experiment task</para>
            /// </summary>
            [NameInMap("Task")]
            [Validation(Required=false)]
            public GetExperimentResponseBodyDataTask Task { get; set; }
            public class GetExperimentResponseBodyDataTask : TeaModel {
                /// <summary>
                /// <para>Creation time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-03-05 18:24:08</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>End time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-03-05 18:34:08</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>Experiment parameters</para>
                /// </summary>
                [NameInMap("Params")]
                [Validation(Required=false)]
                public Dictionary<string, string> Params { get; set; }

                /// <summary>
                /// <para>Scene</para>
                /// 
                /// <b>Example:</b>
                /// <para>baseline</para>
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// <para>Start time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-03-05 18:24:08</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>Status</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Task ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>167420</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// <para>Update time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-03-05 18:24:08</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>Update time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-29 02:16:35</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>Workload information</para>
            /// </summary>
            [NameInMap("Workload")]
            [Validation(Required=false)]
            public GetExperimentResponseBodyDataWorkload Workload { get; set; }
            public class GetExperimentResponseBodyDataWorkload : TeaModel {
                /// <summary>
                /// <para>Default CPU allocation</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("DefaultCpuPerWorker")]
                [Validation(Required=false)]
                public int? DefaultCpuPerWorker { get; set; }

                /// <summary>
                /// <para>Default GPU allocation</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("DefaultGpuPerWorker")]
                [Validation(Required=false)]
                public int? DefaultGpuPerWorker { get; set; }

                /// <summary>
                /// <para>Default memory (GB) allocation</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("DefaultMemoryPerWorker")]
                [Validation(Required=false)]
                public int? DefaultMemoryPerWorker { get; set; }

                /// <summary>
                /// <para>Default shared memory (GB) allocation</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("DefaultShareMemory")]
                [Validation(Required=false)]
                public int? DefaultShareMemory { get; set; }

                /// <summary>
                /// <para>Workload cluster, AI, GPU</para>
                /// 
                /// <b>Example:</b>
                /// <para>AI</para>
                /// </summary>
                [NameInMap("Family")]
                [Validation(Required=false)]
                public string Family { get; set; }

                /// <summary>
                /// <para>JobKind</para>
                /// 
                /// <b>Example:</b>
                /// <para>PyTorchJob</para>
                /// </summary>
                [NameInMap("JobKind")]
                [Validation(Required=false)]
                public string JobKind { get; set; }

                /// <summary>
                /// <para>Parameter settings</para>
                /// </summary>
                [NameInMap("ParamSettings")]
                [Validation(Required=false)]
                public List<GetExperimentResponseBodyDataWorkloadParamSettings> ParamSettings { get; set; }
                public class GetExperimentResponseBodyDataWorkloadParamSettings : TeaModel {
                    /// <summary>
                    /// <para>Default parameter value</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("DefaultValue")]
                    [Validation(Required=false)]
                    public string DefaultValue { get; set; }

                    /// <summary>
                    /// <para>Parameter description</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>number</para>
                    /// </summary>
                    [NameInMap("ParamDesc")]
                    [Validation(Required=false)]
                    public string ParamDesc { get; set; }

                    /// <summary>
                    /// <para>Parameter name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ITERATION</para>
                    /// </summary>
                    [NameInMap("ParamName")]
                    [Validation(Required=false)]
                    public string ParamName { get; set; }

                    /// <summary>
                    /// <para>Parameter regular expression</para>
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
                    /// <para>Parameter value</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("ParamValue")]
                    [Validation(Required=false)]
                    public string ParamValue { get; set; }

                }

                /// <summary>
                /// <para>Workload usage scenario</para>
                /// 
                /// <b>Example:</b>
                /// <para>NLP-LLM</para>
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// <para>Scope</para>
                /// 
                /// <b>Example:</b>
                /// <para>common</para>
                /// </summary>
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                /// <summary>
                /// <para>Static configuration</para>
                /// </summary>
                [NameInMap("StaticConfig")]
                [Validation(Required=false)]
                public GetExperimentResponseBodyDataWorkloadStaticConfig StaticConfig { get; set; }
                public class GetExperimentResponseBodyDataWorkloadStaticConfig : TeaModel {
                    /// <summary>
                    /// <para>Framework</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pyTorch</para>
                    /// </summary>
                    [NameInMap("FrameWork")]
                    [Validation(Required=false)]
                    public string FrameWork { get; set; }

                    /// <summary>
                    /// <para>Operating system</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>linux</para>
                    /// </summary>
                    [NameInMap("Os")]
                    [Validation(Required=false)]
                    public string Os { get; set; }

                    /// <summary>
                    /// <para>Number of parameters</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7B</para>
                    /// </summary>
                    [NameInMap("Parameters")]
                    [Validation(Required=false)]
                    public string Parameters { get; set; }

                    /// <summary>
                    /// <para>Software stack</para>
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
                /// <para>Workload description</para>
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
                /// <para>Workload name</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("WorkloadName")]
                [Validation(Required=false)]
                public string WorkloadName { get; set; }

                /// <summary>
                /// <para>Workload name</para>
                /// 
                /// <b>Example:</b>
                /// <para>AI</para>
                /// </summary>
                [NameInMap("WorkloadType")]
                [Validation(Required=false)]
                public string WorkloadType { get; set; }

            }

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
        /// <para>RequestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>E67E2E4C-2B47-5C55-AA17-1D771E070AEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>total</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
