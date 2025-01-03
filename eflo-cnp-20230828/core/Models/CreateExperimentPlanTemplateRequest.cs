// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class CreateExperimentPlanTemplateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>private</para>
        /// </summary>
        [NameInMap("PrivacyLevel")]
        [Validation(Required=false)]
        public string PrivacyLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>The template installs jdk and tomcat on a new ECS instance.</para>
        /// </summary>
        [NameInMap("TemplateDescription")]
        [Validation(Required=false)]
        public string TemplateDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4724</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("TemplatePipeline")]
        [Validation(Required=false)]
        public List<CreateExperimentPlanTemplateRequestTemplatePipeline> TemplatePipeline { get; set; }
        public class CreateExperimentPlanTemplateRequestTemplatePipeline : TeaModel {
            [NameInMap("EnvParams")]
            [Validation(Required=false)]
            public CreateExperimentPlanTemplateRequestTemplatePipelineEnvParams EnvParams { get; set; }
            public class CreateExperimentPlanTemplateRequestTemplatePipelineEnvParams : TeaModel {
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
            /// <para>14</para>
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

    }

}
