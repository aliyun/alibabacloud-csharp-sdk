// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class GetPipelineStepLogRequest : TeaModel {
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public long? PipelineId { get; set; }

        [NameInMap("UserPk")]
        [Validation(Required=false)]
        public string UserPk { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        [NameInMap("StepIndex")]
        [Validation(Required=false)]
        public string StepIndex { get; set; }

        [NameInMap("Offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

    }

}
