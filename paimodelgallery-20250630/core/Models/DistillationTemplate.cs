// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIModelGallery20250630.Models
{
    public class DistillationTemplate : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>easydistill</para>
        /// </summary>
        [NameInMap("AlgorithmName")]
        [Validation(Required=false)]
        public string AlgorithmName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pai</para>
        /// </summary>
        [NameInMap("AlgorithmProvider")]
        [Validation(Required=false)]
        public string AlgorithmProvider { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>v2.0.0</para>
        /// </summary>
        [NameInMap("AlgorithmVersion")]
        [Validation(Required=false)]
        public string AlgorithmVersion { get; set; }

        [NameInMap("CapabilityTags")]
        [Validation(Required=false)]
        public List<string> CapabilityTags { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>reasoning</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>job_type: advanced_cot_distill</para>
        /// </summary>
        [NameInMap("DefaultConfig")]
        [Validation(Required=false)]
        public string DefaultConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>面向数学、逻辑、代码等需要多步推理的场景，产出 SFT 数据集。</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("InputDatasetMustBeDirectory")]
        [Validation(Required=false)]
        public bool? InputDatasetMustBeDirectory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://pai-quickstart-cn-hangzhou.oss-cn-hangzhou-internal.aliyuncs.com/public_datasets/distillation_examples/advanced_cot_distill/input.jsonl</para>
        /// </summary>
        [NameInMap("InputExampleUri")]
        [Validation(Required=false)]
        public string InputExampleUri { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>advanced_cot_distill</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        [NameInMap("ModelSlots")]
        [Validation(Required=false)]
        public List<DistillationTemplateModelSlots> ModelSlots { get; set; }
        public class DistillationTemplateModelSlots : TeaModel {
            [NameInMap("Backends")]
            [Validation(Required=false)]
            public List<DistillationTemplateModelSlotsBackends> Backends { get; set; }
            public class DistillationTemplateModelSlotsBackends : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>distillation</para>
                /// </summary>
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pai_token</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>用于生成蒸馏数据的教师模型，建议选择推理能力强的模型。</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>backend</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>教师模型</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("OrderNumber")]
        [Validation(Required=false)]
        public int? OrderNumber { get; set; }

        [NameInMap("PipelineStages")]
        [Validation(Required=false)]
        public List<DistillationTemplatePipelineStages> PipelineStages { get; set; }
        public class DistillationTemplatePipelineStages : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>由教师模型对每个问题生成带推理过程的回答。</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cot_distill</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>生成思维链</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("PresetConfig")]
        [Validation(Required=false)]
        public List<DistillationTemplatePresetConfig> PresetConfig { get; set; }
        public class DistillationTemplatePresetConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>任务类型</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>advanced_cot_distill</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://pai-quickstart-cn-hangzhou.oss-cn-hangzhou-internal.aliyuncs.com/public_datasets/distillation_examples/custom_distill/processor_example.py</para>
        /// </summary>
        [NameInMap("ProcessorExampleUri")]
        [Validation(Required=false)]
        public string ProcessorExampleUri { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>advanced_cot_distill</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>scenario</para>
        /// </summary>
        [NameInMap("TemplateKind")]
        [Validation(Required=false)]
        public string TemplateKind { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>思维链推理蒸馏</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("TrainingOptions")]
        [Validation(Required=false)]
        public List<DistillationTemplateTrainingOptions> TrainingOptions { get; set; }
        public class DistillationTemplateTrainingOptions : TeaModel {
            [NameInMap("ModelTasks")]
            [Validation(Required=false)]
            public List<string> ModelTasks { get; set; }

            [NameInMap("TrainingMethods")]
            [Validation(Required=false)]
            public List<string> TrainingMethods { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sft</para>
            /// </summary>
            [NameInMap("TrainingType")]
            [Validation(Required=false)]
            public string TrainingType { get; set; }

        }

    }

}
