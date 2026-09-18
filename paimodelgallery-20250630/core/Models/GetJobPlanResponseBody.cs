// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIModelGallery20250630.Models
{
    public class GetJobPlanResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation time of the job plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-18 10:00:00</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The last modified time of the job plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-18 10:30:00</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The current step.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DatasetSynthesis</para>
        /// </summary>
        [NameInMap("JobPlanCurrentStep")]
        [Validation(Required=false)]
        public string JobPlanCurrentStep { get; set; }

        /// <summary>
        /// <para>The job plan ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jp-xxxxxx</para>
        /// </summary>
        [NameInMap("JobPlanId")]
        [Validation(Required=false)]
        public string JobPlanId { get; set; }

        /// <summary>
        /// <para>The job plan name, which is unique within the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ModelGalleryxxx</para>
        /// </summary>
        [NameInMap("JobPlanName")]
        [Validation(Required=false)]
        public string JobPlanName { get; set; }

        /// <summary>
        /// <para>The job plan steps.</para>
        /// </summary>
        [NameInMap("JobPlanSteps")]
        [Validation(Required=false)]
        public List<GetJobPlanResponseBodyJobPlanSteps> JobPlanSteps { get; set; }
        public class GetJobPlanResponseBodyJobPlanSteps : TeaModel {
            /// <summary>
            /// <para>The generated PAIFlow PipelineRunId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pipeline-xxxxx</para>
            /// </summary>
            [NameInMap("JobPlanStepId")]
            [Validation(Required=false)]
            public string JobPlanStepId { get; set; }

            /// <summary>
            /// <para>The job plan step name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DistillationDatasetSynthesis</para>
            /// </summary>
            [NameInMap("JobPlanStepName")]
            [Validation(Required=false)]
            public string JobPlanStepName { get; set; }

            /// <summary>
            /// <para>The job plan step configuration.</para>
            /// </summary>
            [NameInMap("JobPlanStepSpec")]
            [Validation(Required=false)]
            public Dictionary<string, object> JobPlanStepSpec { get; set; }

            /// <summary>
            /// <para>The job plan step type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PAIFlow</para>
            /// </summary>
            [NameInMap("JobPlanStepType")]
            [Validation(Required=false)]
            public string JobPlanStepType { get; set; }

        }

        /// <summary>
        /// <para>The job plan type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Distillation</para>
        /// </summary>
        [NameInMap("JobPlanType")]
        [Validation(Required=false)]
        public string JobPlanType { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID that owns the job plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123456</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82-9624-EC2B1779848E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetJobPlanResponseBodyTags> Tags { get; set; }
        public class GetJobPlanResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>foo</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bar</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The distillation template ID used to create the job plan. An empty value indicates that this is not a scenario-based distillation task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>advanced_cot_distill</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The display name of the distillation template, localized based on the requested language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>思维链推理蒸馏</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID that created the job plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123456</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

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
