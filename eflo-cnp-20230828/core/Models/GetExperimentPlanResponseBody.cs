// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class GetExperimentPlanResponseBody : TeaModel {
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
        public GetExperimentPlanResponseBodyData Data { get; set; }
        public class GetExperimentPlanResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Creation time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-07 02:08:54</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Plan ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>189</para>
            /// </summary>
            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public long? PlanId { get; set; }

            /// <summary>
            /// <para>Test plan pipeline</para>
            /// </summary>
            [NameInMap("PlanPipeline")]
            [Validation(Required=false)]
            public List<GetExperimentPlanResponseBodyDataPlanPipeline> PlanPipeline { get; set; }
            public class GetExperimentPlanResponseBodyDataPlanPipeline : TeaModel {
                /// <summary>
                /// <para>Configured environment parameters</para>
                /// </summary>
                [NameInMap("EnvParams")]
                [Validation(Required=false)]
                public GetExperimentPlanResponseBodyDataPlanPipelineEnvParams EnvParams { get; set; }
                public class GetExperimentPlanResponseBodyDataPlanPipelineEnvParams : TeaModel {
                    /// <summary>
                    /// <para>CPU allocation</para>
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
                    /// <para>Memory GB allocation</para>
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
                    public List<GetExperimentPlanResponseBodyDataPlanPipelineEnvParamsResourceNodes> ResourceNodes { get; set; }
                    public class GetExperimentPlanResponseBodyDataPlanPipelineEnvParamsResourceNodes : TeaModel {
                        /// <summary>
                        /// <para>Node name</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ods_galaxy_gateway_tickets</para>
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
                        /// <para>Memory of the current request</para>
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
                    /// <para>Shared memory GB allocation</para>
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
                /// <para>Node order number</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PipelineOrder")]
                [Validation(Required=false)]
                public int? PipelineOrder { get; set; }

                /// <summary>
                /// <para>Resource ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>36</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public long? ResourceId { get; set; }

                /// <summary>
                /// <para>Resource name</para>
                /// 
                /// <b>Example:</b>
                /// <para>PPU</para>
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <para>Usage scenario, e.g., &quot;baseline&quot;</para>
                /// 
                /// <b>Example:</b>
                /// <para>baseline</para>
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// <para>Configured workload parameters</para>
                /// </summary>
                [NameInMap("SettingParams")]
                [Validation(Required=false)]
                public Dictionary<string, string> SettingParams { get; set; }

                /// <summary>
                /// <para>Workload ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>14</para>
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

            }

            /// <summary>
            /// <para>Resource group ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmvmpzi7lmxhq</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Associated resource ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>260860230684</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public long? ResourceId { get; set; }

            /// <summary>
            /// <para>Associated test plan template ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>2162</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// <para>Associated test plan template name</para>
            /// 
            /// <b>Example:</b>
            /// <para>MM</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>Update time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-07 02:08:54</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>6DBAC169-93D1-5DCD-8109-30FB623B3197</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total count of the query</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
