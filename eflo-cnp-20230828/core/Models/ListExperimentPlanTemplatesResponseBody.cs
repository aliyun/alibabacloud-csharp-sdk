// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class ListExperimentPlanTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>Data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListExperimentPlanTemplatesResponseBodyData> Data { get; set; }
        public class ListExperimentPlanTemplatesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Creation time</para>
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
            /// <para>178154411231232</para>
            /// </summary>
            [NameInMap("CreatorUid")]
            [Validation(Required=false)]
            public long? CreatorUid { get; set; }

            /// <summary>
            /// <para>Whether it is deleted</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsDelete")]
            [Validation(Required=false)]
            public int? IsDelete { get; set; }

            /// <summary>
            /// <para>Privacy level</para>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("PrivacyLevel")]
            [Validation(Required=false)]
            public string PrivacyLevel { get; set; }

            /// <summary>
            /// <para>The template code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>475315534</para>
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public long? TemplateCode { get; set; }

            /// <summary>
            /// <para>Template description</para>
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
            /// <para>17815441</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// <para>Template name</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>Template pipeline</para>
            /// </summary>
            [NameInMap("TemplatePipelineParam")]
            [Validation(Required=false)]
            public List<ListExperimentPlanTemplatesResponseBodyDataTemplatePipelineParam> TemplatePipelineParam { get; set; }
            public class ListExperimentPlanTemplatesResponseBodyDataTemplatePipelineParam : TeaModel {
                /// <summary>
                /// <para>Configured environment parameters</para>
                /// </summary>
                [NameInMap("EnvParams")]
                [Validation(Required=false)]
                public ListExperimentPlanTemplatesResponseBodyDataTemplatePipelineParamEnvParams EnvParams { get; set; }
                public class ListExperimentPlanTemplatesResponseBodyDataTemplatePipelineParamEnvParams : TeaModel {
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
                    /// <para>Cuda Version</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.0.0</para>
                    /// </summary>
                    [NameInMap("CudaVersion")]
                    [Validation(Required=false)]
                    public string CudaVersion { get; set; }

                    /// <summary>
                    /// <para>The version of the GPU driver.</para>
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
                    /// <para>NCCL Version</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.0.0</para>
                    /// </summary>
                    [NameInMap("NCCLVersion")]
                    [Validation(Required=false)]
                    public string NCCLVersion { get; set; }

                    /// <summary>
                    /// <para>PyTorch Version</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.0.0</para>
                    /// </summary>
                    [NameInMap("PyTorchVersion")]
                    [Validation(Required=false)]
                    public string PyTorchVersion { get; set; }

                    /// <summary>
                    /// <para>Allocated shared memory in GB</para>
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
            /// <para>Update time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-29 02:16:35</para>
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
        /// <para>AAE4AFED-7AE6-52FA-80B6-448E63760552</para>
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
