// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIModelGallery20250630.Models
{
    public class GetJobPlanResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-09-18 10:00:00</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-09-18 10:30:00</para>
        /// </summary>
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
        public List<GetJobPlanResponseBodyJobPlanSteps> JobPlanSteps { get; set; }
        public class GetJobPlanResponseBodyJobPlanSteps : TeaModel {
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234567890123456</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetJobPlanResponseBodyTags> Tags { get; set; }
        public class GetJobPlanResponseBodyTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

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
        /// <para>思维链推理蒸馏</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234567890123456</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
