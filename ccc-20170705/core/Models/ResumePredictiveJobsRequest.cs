// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ResumePredictiveJobsRequest : TeaModel {
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public List<string> JobId { get; set; }

        [NameInMap("SkillGroupId")]
        [Validation(Required=false)]
        public string SkillGroupId { get; set; }

    }

}
