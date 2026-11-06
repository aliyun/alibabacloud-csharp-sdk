// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIModelGallery20250630.Models
{
    public class DistillationTemplateSummary : TeaModel {
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
        /// <para>面向数学、逻辑、代码等需要多步推理的场景，产出 SFT 数据集。</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>advanced_cot_distill</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("OrderNumber")]
        [Validation(Required=false)]
        public int? OrderNumber { get; set; }

        [NameInMap("PipelineStages")]
        [Validation(Required=false)]
        public List<DistillationTemplateSummaryPipelineStages> PipelineStages { get; set; }
        public class DistillationTemplateSummaryPipelineStages : TeaModel {
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
        public List<DistillationTemplateSummaryTrainingOptions> TrainingOptions { get; set; }
        public class DistillationTemplateSummaryTrainingOptions : TeaModel {
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
