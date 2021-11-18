// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class CreatePredictiveJobGroupRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IsDraft")]
        [Validation(Required=false)]
        public bool? IsDraft { get; set; }

        [NameInMap("JobFilePath")]
        [Validation(Required=false)]
        public string JobFilePath { get; set; }

        [NameInMap("JobsJson")]
        [Validation(Required=false)]
        public List<string> JobsJson { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Ratio")]
        [Validation(Required=false)]
        public int? Ratio { get; set; }

        [NameInMap("SkillGroupId")]
        [Validation(Required=false)]
        public string SkillGroupId { get; set; }

        [NameInMap("StrategyJson")]
        [Validation(Required=false)]
        public string StrategyJson { get; set; }

        [NameInMap("TimingSchedule")]
        [Validation(Required=false)]
        public bool? TimingSchedule { get; set; }

    }

}
