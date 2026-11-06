// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIModelGallery20250630.Models
{
    public class CreateJobPlanRequest : TeaModel {
        [NameInMap("JobPlanName")]
        [Validation(Required=false)]
        public string JobPlanName { get; set; }

        [NameInMap("JobPlanSteps")]
        [Validation(Required=false)]
        public List<CreateJobPlanRequestJobPlanSteps> JobPlanSteps { get; set; }
        public class CreateJobPlanRequestJobPlanSteps : TeaModel {
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

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateJobPlanRequestTag> Tag { get; set; }
        public class CreateJobPlanRequestTag : TeaModel {
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

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
