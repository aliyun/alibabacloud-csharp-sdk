// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateJobGroupRequest : TeaModel {
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public List<string> CallingNumber { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("JobGroupDescription")]
        [Validation(Required=false)]
        public string JobGroupDescription { get; set; }

        [NameInMap("JobGroupName")]
        [Validation(Required=false)]
        public string JobGroupName { get; set; }

        [NameInMap("MinConcurrency")]
        [Validation(Required=false)]
        public long? MinConcurrency { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        [NameInMap("RecallStrategyJson")]
        [Validation(Required=false)]
        public string RecallStrategyJson { get; set; }

        [NameInMap("RingingDuration")]
        [Validation(Required=false)]
        public long? RingingDuration { get; set; }

        [NameInMap("ScenarioId")]
        [Validation(Required=false)]
        public string ScenarioId { get; set; }

        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        [NameInMap("StrategyJson")]
        [Validation(Required=false)]
        public string StrategyJson { get; set; }

    }

}
