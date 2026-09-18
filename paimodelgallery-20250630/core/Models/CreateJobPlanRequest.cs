// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIModelGallery20250630.Models
{
    public class CreateJobPlanRequest : TeaModel {
        /// <summary>
        /// <para>The name of the job plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ModelGalleryxxx</para>
        /// </summary>
        [NameInMap("JobPlanName")]
        [Validation(Required=false)]
        public string JobPlanName { get; set; }

        /// <summary>
        /// <para>The steps of the job plan.</para>
        /// </summary>
        [NameInMap("JobPlanSteps")]
        [Validation(Required=false)]
        public List<CreateJobPlanRequestJobPlanSteps> JobPlanSteps { get; set; }
        public class CreateJobPlanRequestJobPlanSteps : TeaModel {
            /// <summary>
            /// <para>The name of the job plan step.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DatasetSynthesis</para>
            /// </summary>
            [NameInMap("JobPlanStepName")]
            [Validation(Required=false)]
            public string JobPlanStepName { get; set; }

            /// <summary>
            /// <para>The detailed configuration of the job plan step.</para>
            /// </summary>
            [NameInMap("JobPlanStepSpec")]
            [Validation(Required=false)]
            public Dictionary<string, object> JobPlanStepSpec { get; set; }

            /// <summary>
            /// <para>The type of the job plan step.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PAIFlow</para>
            /// </summary>
            [NameInMap("JobPlanStepType")]
            [Validation(Required=false)]
            public string JobPlanStepType { get; set; }

        }

        /// <summary>
        /// <para>The type of the job plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Distillation</para>
        /// </summary>
        [NameInMap("JobPlanType")]
        [Validation(Required=false)]
        public string JobPlanType { get; set; }

        /// <summary>
        /// <para>Note: According to the Alibaba Cloud tag system specification, this parameter name is in singular form.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateJobPlanRequestTag> Tag { get; set; }
        public class CreateJobPlanRequestTag : TeaModel {
            /// <summary>
            /// <para><b>Key</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>foo</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para><b>Value</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>bar</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the scenario-specific distillation template, obtained from ListDistillationTemplates. If this parameter is not specified, a general-purpose job plan is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>advanced_cot_distill</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>62469</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
