// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class GetExperimentPlanTemplateResponseBody : TeaModel {
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
        public GetExperimentPlanTemplateResponseBodyData Data { get; set; }
        public class GetExperimentPlanTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Creation Time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-29 02:16:35</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Primary account UID</para>
            /// 
            /// <b>Example:</b>
            /// <para>12312312312312</para>
            /// </summary>
            [NameInMap("CreatorUid")]
            [Validation(Required=false)]
            public long? CreatorUid { get; set; }

            /// <summary>
            /// <para>Whether deleted</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsDelete")]
            [Validation(Required=false)]
            public int? IsDelete { get; set; }

            /// <summary>
            /// <para>Privacy Level</para>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("PrivacyLevel")]
            [Validation(Required=false)]
            public string PrivacyLevel { get; set; }

            /// <summary>
            /// <para>Template Code</para>
            /// 
            /// <b>Example:</b>
            /// <para>464086216</para>
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public long? TemplateCode { get; set; }

            /// <summary>
            /// <para>Template Description</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TemplateDescription")]
            [Validation(Required=false)]
            public string TemplateDescription { get; set; }

            /// <summary>
            /// <para>Template ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>17615126</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// <para>Template Name</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>Template Pipeline</para>
            /// </summary>
            [NameInMap("TemplatePipelineParam")]
            [Validation(Required=false)]
            public List<GetExperimentPlanTemplateResponseBodyDataTemplatePipelineParam> TemplatePipelineParam { get; set; }
            public class GetExperimentPlanTemplateResponseBodyDataTemplatePipelineParam : TeaModel {
                /// <summary>
                /// <para>Configured environment parameters</para>
                /// </summary>
                [NameInMap("EnvParams")]
                [Validation(Required=false)]
                public GetExperimentPlanTemplateResponseBodyDataTemplatePipelineParamEnvParams EnvParams { get; set; }
                public class GetExperimentPlanTemplateResponseBodyDataTemplatePipelineParamEnvParams : TeaModel {
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
                    /// <para>GPU allocation</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("GpuPerWorker")]
                    [Validation(Required=false)]
                    public int? GpuPerWorker { get; set; }

                    /// <summary>
                    /// <para>Allocated memory in GB</para>
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
                    public List<GetExperimentPlanTemplateResponseBodyDataTemplatePipelineParamEnvParamsResourceNodes> ResourceNodes { get; set; }
                    public class GetExperimentPlanTemplateResponseBodyDataTemplatePipelineParamEnvParamsResourceNodes : TeaModel {
                        /// <summary>
                        /// <para>Node name</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>exclusive_coud</para>
                        /// </summary>
                        [NameInMap("NodeName")]
                        [Validation(Required=false)]
                        public string NodeName { get; set; }

                        /// <summary>
                        /// <para>当前请求的cpu</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("RequestCPU")]
                        [Validation(Required=false)]
                        public int? RequestCPU { get; set; }

                        /// <summary>
                        /// <para>Requested GPU</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("RequestGPU")]
                        [Validation(Required=false)]
                        public int? RequestGPU { get; set; }

                        /// <summary>
                        /// <para>Requested memory</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1024</para>
                        /// </summary>
                        [NameInMap("RequestMemory")]
                        [Validation(Required=false)]
                        public int? RequestMemory { get; set; }

                        /// <summary>
                        /// <para>Total CPU</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("TotalCPU")]
                        [Validation(Required=false)]
                        public int? TotalCPU { get; set; }

                        /// <summary>
                        /// <para>Total GPU</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("TotalGPU")]
                        [Validation(Required=false)]
                        public int? TotalGPU { get; set; }

                        /// <summary>
                        /// <para>Total memory</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2048</para>
                        /// </summary>
                        [NameInMap("TotalMemory")]
                        [Validation(Required=false)]
                        public long? TotalMemory { get; set; }

                    }

                    /// <summary>
                    /// <para>Shared memory in GB</para>
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
                /// <para>Node sequence number</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PipelineOrder")]
                [Validation(Required=false)]
                public int? PipelineOrder { get; set; }

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

            }

            /// <summary>
            /// <para>Update Time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-22 10:18:10</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>Version ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public long? VersionId { get; set; }

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
