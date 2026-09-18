// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIModelGallery20250630.Models
{
    public class DistillationTemplateSummary : TeaModel {
        /// <summary>
        /// <para>The list of capability tags, used for scenario card display.</para>
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
        /// <para>The template description, localized based on the language specified in the request. The description specifies applicable scenarios and outputs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Designed for scenarios that require multi-step reasoning, such as math, logic, and code. Produces an SFT dataset</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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
        /// <para>The display order. A smaller value indicates a higher position.</para>
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
        public List<DistillationTemplateSummaryPipelineStages> PipelineStages { get; set; }
        public class DistillationTemplateSummaryPipelineStages : TeaModel {
            /// <summary>
            /// <para>The stage description, localized based on the language specified in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The teacher model generates reasoning-augmented responses for each question</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The stage identifier, which corresponds to the pipeline[].stage value in the algorithm configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cot_distill</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The stage display name, localized based on the language specified in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Generate Chain-of-Thought</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

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
        /// <para>The template display name, localized based on the language specified in the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Chain-of-Thought Reasoning Distillation</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The capability declaration for the second stage, in which the distilled data is used to train the student model. An empty value indicates that the template supports only the distillation stage.</para>
        /// </summary>
        [NameInMap("TrainingOptions")]
        [Validation(Required=false)]
        public List<DistillationTemplateSummaryTrainingOptions> TrainingOptions { get; set; }
        public class DistillationTemplateSummaryTrainingOptions : TeaModel {
            /// <summary>
            /// <para>The available Model Gallery Task values for the student model.</para>
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
