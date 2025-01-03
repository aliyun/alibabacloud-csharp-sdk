// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class CreateExperimentPlanTemplateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateExperimentPlanTemplateResponseBodyData Data { get; set; }
        public class CreateExperimentPlanTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-11-19T02:01:05Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12312312312312</para>
            /// </summary>
            [NameInMap("CreatorUid")]
            [Validation(Required=false)]
            public long? CreatorUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsDelete")]
            [Validation(Required=false)]
            public int? IsDelete { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("PrivacyLevel")]
            [Validation(Required=false)]
            public string PrivacyLevel { get; set; }

            [NameInMap("TemplateDescription")]
            [Validation(Required=false)]
            public string TemplateDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>17615126</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            [NameInMap("TemplatePipelineParam")]
            [Validation(Required=false)]
            public List<CreateExperimentPlanTemplateResponseBodyDataTemplatePipelineParam> TemplatePipelineParam { get; set; }
            public class CreateExperimentPlanTemplateResponseBodyDataTemplatePipelineParam : TeaModel {
                [NameInMap("EnvParams")]
                [Validation(Required=false)]
                public CreateExperimentPlanTemplateResponseBodyDataTemplatePipelineParamEnvParams EnvParams { get; set; }
                public class CreateExperimentPlanTemplateResponseBodyDataTemplatePipelineParamEnvParams : TeaModel {
                    /// <summary>
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
                    /// <para>GpuDriverVersion</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.0.0</para>
                    /// </summary>
                    [NameInMap("GpuDriverVersion")]
                    [Validation(Required=false)]
                    public string GpuDriverVersion { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("GpuPerWorker")]
                    [Validation(Required=false)]
                    public int? GpuPerWorker { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>500</para>
                    /// </summary>
                    [NameInMap("MemoryPerWorker")]
                    [Validation(Required=false)]
                    public int? MemoryPerWorker { get; set; }

                    /// <summary>
                    /// <para>NCCLVersion</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.0.0</para>
                    /// </summary>
                    [NameInMap("NCCLVersion")]
                    [Validation(Required=false)]
                    public string NCCLVersion { get; set; }

                    /// <summary>
                    /// <para>PyTorchVersion</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.0.0</para>
                    /// </summary>
                    [NameInMap("PyTorchVersion")]
                    [Validation(Required=false)]
                    public string PyTorchVersion { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>500</para>
                    /// </summary>
                    [NameInMap("ShareMemory")]
                    [Validation(Required=false)]
                    public int? ShareMemory { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("WorkerNum")]
                    [Validation(Required=false)]
                    public int? WorkerNum { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PipelineOrder")]
                [Validation(Required=false)]
                public int? PipelineOrder { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>baseline</para>
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                [NameInMap("SettingParams")]
                [Validation(Required=false)]
                public Dictionary<string, string> SettingParams { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>13</para>
                /// </summary>
                [NameInMap("WorkloadId")]
                [Validation(Required=false)]
                public long? WorkloadId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("WorkloadName")]
                [Validation(Required=false)]
                public string WorkloadName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-10-16T01:58Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public long? VersionId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5514CB39-B7C0-5B89-8534-2DE1E0F2B7AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
