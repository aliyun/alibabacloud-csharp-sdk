// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateBatchJobsRequest : TeaModel {
        [NameInMap("BatchJobDescription")]
        [Validation(Required=false)]
        public string BatchJobDescription { get; set; }

        [NameInMap("BatchJobName")]
        [Validation(Required=false)]
        public string BatchJobName { get; set; }

        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public List<string> CallingNumber { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("JobFilePath")]
        [Validation(Required=false)]
        public string JobFilePath { get; set; }

        [NameInMap("ScenarioId")]
        [Validation(Required=false)]
        public string ScenarioId { get; set; }

        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        [NameInMap("StrategyJson")]
        [Validation(Required=false)]
        public string StrategyJson { get; set; }

        [NameInMap("Submitted")]
        [Validation(Required=false)]
        public bool? Submitted { get; set; }

    }

}
