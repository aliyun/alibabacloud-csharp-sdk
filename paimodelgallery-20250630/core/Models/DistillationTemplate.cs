// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIModelGallery20250630.Models
{
    public class DistillationTemplate : TeaModel {
        /// <summary>
        /// <para>The algorithm name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>easydistill</para>
        /// </summary>
        [NameInMap("AlgorithmName")]
        [Validation(Required=false)]
        public string AlgorithmName { get; set; }

        /// <summary>
        /// <para>The algorithm provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pai</para>
        /// </summary>
        [NameInMap("AlgorithmProvider")]
        [Validation(Required=false)]
        public string AlgorithmProvider { get; set; }

        /// <summary>
        /// <para>The algorithm version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2.0.0</para>
        /// </summary>
        [NameInMap("AlgorithmVersion")]
        [Validation(Required=false)]
        public string AlgorithmVersion { get; set; }

        /// <summary>
        /// <para>The list of capability tags used for displaying scenario cards.</para>
        /// </summary>
        [NameInMap("CapabilityTags")]
        [Validation(Required=false)]
        public List<string> CapabilityTags { get; set; }

        /// <summary>
        /// <para>The template category. The frontend uses this value to filter scenario cards.</para>
        /// 
        /// <b>Example:</b>
        /// <para>reasoning</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The raw YAML content of the EasyDistill default configurations. The frontend uses this content for rendering the configuration form and supports recovering to default configurations. The model and credential fields are intentionally left empty and are populated by the user in the form upon commit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job_type: advanced_cot_distill</para>
        /// </summary>
        [NameInMap("DefaultConfig")]
        [Validation(Required=false)]
        public string DefaultConfig { get; set; }

        /// <summary>
        /// <para>The template description, localized based on the requested language. The description specifies the applicable scenarios and outputs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Designed for scenarios that require multi-step reasoning such as math, logic, and code. Produces an SFT dataset</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether the input data must be an entire directory. If this parameter is set to true, only a directory can be selected on the form, not a single file. If this parameter is absent or set to false, either a file or a directory can be selected. This value is true when seed files reference other files in the same directory by relative path.</para>
        /// </summary>
        [NameInMap("InputDatasetMustBeDirectory")]
        [Validation(Required=false)]
        public bool? InputDatasetMustBeDirectory { get; set; }

        /// <summary>
        /// <para>The OSS address of the sample input data, rendered based on the region. Users can download the sample and prepare their own data in the same format. An empty value indicates that the template does not provide a sample.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://pai-quickstart-cn-hangzhou.oss-cn-hangzhou-internal.aliyuncs.com/public_datasets/distillation_examples/advanced_cot_distill/input.jsonl</para>
        /// </summary>
        [NameInMap("InputExampleUri")]
        [Validation(Required=false)]
        public string InputExampleUri { get; set; }

        /// <summary>
        /// <para>The algorithm job type. The value is the same as TemplateId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>advanced_cot_distill</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The list of model slots that require user selection. The frontend uses this list to render the model selection form.</para>
        /// </summary>
        [NameInMap("ModelSlots")]
        [Validation(Required=false)]
        public List<DistillationTemplateModelSlots> ModelSlots { get; set; }
        public class DistillationTemplateModelSlots : TeaModel {
            /// <summary>
            /// <para>The list of model access methods supported by this slot.</para>
            /// </summary>
            [NameInMap("Backends")]
            [Validation(Required=false)]
            public List<DistillationTemplateModelSlotsBackends> Backends { get; set; }
            public class DistillationTemplateModelSlotsBackends : TeaModel {
                /// <summary>
                /// <para>The channel name of the PAI-Token gateway. The frontend uses this value to retrieve the list of available models for the channel. This value must be passed back as-is upon submission. This parameter is returned only when Type is pai_token.</para>
                /// 
                /// <b>Example:</b>
                /// <para>distillation</para>
                /// </summary>
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <para>The model access method. pai_token indicates the PAI-Token gateway, where the user selects from the list of available models for the channel. pai_eas indicates the user\&quot;s own PAI-EAS service instance, which requires the service address and token.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pai_token</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The slot description, localized based on the requested language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The teacher model used to generate distillation data. We recommend selecting a model with strong reasoning capabilities</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The slot identifier, which corresponds to the backend section name in the submitted configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>backend</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The slot display name, localized based on the requested language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Teacher model</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Specifies whether this slot is required. If this parameter is set to false, the user can skip the selection, and the algorithm falls back to other slots.</para>
            /// </summary>
            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

        }

        /// <summary>
        /// <para>The display order. A smaller value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("OrderNumber")]
        [Validation(Required=false)]
        public int? OrderNumber { get; set; }

        /// <summary>
        /// <para>The list of pipeline stages. The order of the stages represents the execution order.</para>
        /// </summary>
        [NameInMap("PipelineStages")]
        [Validation(Required=false)]
        public List<DistillationTemplatePipelineStages> PipelineStages { get; set; }
        public class DistillationTemplatePipelineStages : TeaModel {
            /// <summary>
            /// <para>The stage description, localized based on the requested language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The teacher model generates responses with reasoning processes for each question</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The stage identifier, which corresponds to the value of pipeline[].stage in the algorithm configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cot_distill</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The stage display name, localized based on the requested language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Generate chain of thought</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The content of the preset configuration card, displayed in order to show the key default configurations of the template.</para>
        /// </summary>
        [NameInMap("PresetConfig")]
        [Validation(Required=false)]
        public List<DistillationTemplatePresetConfig> PresetConfig { get; set; }
        public class DistillationTemplatePresetConfig : TeaModel {
            /// <summary>
            /// <para>The configuration item name, localized based on the requested language. Names are matched by position across languages, so the same row can have different names in different languages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Task type</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>The configuration item value, localized based on the requested language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>advanced_cot_distill</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The distillation template ID, which is the same as the algorithm job_type. Pass this value as TemplateId when creating a task plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>advanced_cot_distill</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The template display name, localized based on the requested language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Chain-of-thought reasoning distillation</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The capability declaration for the second stage (training the student model with the distilled data). An empty value indicates that the template supports only the distillation stage.</para>
        /// </summary>
        [NameInMap("TrainingOptions")]
        [Validation(Required=false)]
        public List<DistillationTemplateTrainingOptions> TrainingOptions { get; set; }
        public class DistillationTemplateTrainingOptions : TeaModel {
            /// <summary>
            /// <para>The range of Model Gallery tasks available for the student model.</para>
            /// </summary>
            [NameInMap("ModelTasks")]
            [Validation(Required=false)]
            public List<string> ModelTasks { get; set; }

            /// <summary>
            /// <para>The list of supported training method families.</para>
            /// </summary>
            [NameInMap("TrainingMethods")]
            [Validation(Required=false)]
            public List<string> TrainingMethods { get; set; }

            /// <summary>
            /// <para>The training type. The frontend uses this value to select the training workflow and display text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sft</para>
            /// </summary>
            [NameInMap("TrainingType")]
            [Validation(Required=false)]
            public string TrainingType { get; set; }

        }

    }

}
