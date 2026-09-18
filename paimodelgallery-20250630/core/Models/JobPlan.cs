// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIModelGallery20250630.Models
{
    public class JobPlan : TeaModel {
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("JobPlanCurrentStep")]
        [Validation(Required=false)]
        public string JobPlanCurrentStep { get; set; }

        [NameInMap("JobPlanId")]
        [Validation(Required=false)]
        public string JobPlanId { get; set; }

        [NameInMap("JobPlanName")]
        [Validation(Required=false)]
        public string JobPlanName { get; set; }

        [NameInMap("JobPlanSteps")]
        [Validation(Required=false)]
        public List<JobPlanJobPlanSteps> JobPlanSteps { get; set; }
        public class JobPlanJobPlanSteps : TeaModel {
            [NameInMap("JobPlanStepId")]
            [Validation(Required=false)]
            public string JobPlanStepId { get; set; }

            [NameInMap("JobPlanStepName")]
            [Validation(Required=false)]
            public string JobPlanStepName { get; set; }

            [NameInMap("JobPlanStepSpec")]
            [Validation(Required=false)]
            public Dictionary<string, object> JobPlanStepSpec { get; set; }

            [NameInMap("JobPlanStepType")]
            [Validation(Required=false)]
            public string JobPlanStepType { get; set; }

        }

        [NameInMap("JobPlanType")]
        [Validation(Required=false)]
        public string JobPlanType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<JobPlanTags> Tags { get; set; }
        public class JobPlanTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The distillation template ID used when creating the task plan. An empty value indicates that this is not a scenario-specific distillation task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>advanced_cot_distill</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The display name of the distillation template used, localized based on the language specified in the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Chain-of-Thought Reasoning Distillation</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
