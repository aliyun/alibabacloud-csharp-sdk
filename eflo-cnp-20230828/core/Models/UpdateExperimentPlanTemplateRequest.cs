// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class UpdateExperimentPlanTemplateRequest : TeaModel {
        /// <summary>
        /// <para>Template code</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>349623</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// <para>Template pipeline</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TemplatePipeline")]
        [Validation(Required=false)]
        public List<UpdateExperimentPlanTemplateRequestTemplatePipeline> TemplatePipeline { get; set; }
        public class UpdateExperimentPlanTemplateRequestTemplatePipeline : TeaModel {
            /// <summary>
            /// <para>Configured environment parameters</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("EnvParams")]
            [Validation(Required=false)]
            public UpdateExperimentPlanTemplateRequestTemplatePipelineEnvParams EnvParams { get; set; }
            public class UpdateExperimentPlanTemplateRequestTemplatePipelineEnvParams : TeaModel {
                /// <summary>
                /// <para>CPU allocation count</para>
                /// <para>This parameter is required.</para>
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
                /// <para>GPU driver version</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("GpuDriverVersion")]
                [Validation(Required=false)]
                public string GpuDriverVersion { get; set; }

                /// <summary>
                /// <para>GPU allocation count</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("GpuPerWorker")]
                [Validation(Required=false)]
                public int? GpuPerWorker { get; set; }

                /// <summary>
                /// <para>Memory GB allocation count</para>
                /// <para>This parameter is required.</para>
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
                /// <para>Shared memory GB allocation count</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("ShareMemory")]
                [Validation(Required=false)]
                public int? ShareMemory { get; set; }

                /// <summary>
                /// <para>Number of nodes</para>
                /// <para>This parameter is required.</para>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PipelineOrder")]
            [Validation(Required=false)]
            public int? PipelineOrder { get; set; }

            /// <summary>
            /// <para>Usage scenario, e.g., &quot;baseline&quot;</para>
            /// <para>This parameter is required.</para>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14</para>
            /// </summary>
            [NameInMap("WorkloadId")]
            [Validation(Required=false)]
            public long? WorkloadId { get; set; }

            /// <summary>
            /// <para>Workload name</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("WorkloadName")]
            [Validation(Required=false)]
            public string WorkloadName { get; set; }

        }

    }

}
