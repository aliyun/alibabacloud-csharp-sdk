// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class TuningHistory : TeaModel {
        [NameInMap("actionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        [NameInMap("annotations")]
        [Validation(Required=false)]
        public Dictionary<string, string> Annotations { get; set; }

        [NameInMap("deploymentName")]
        [Validation(Required=false)]
        public string DeploymentName { get; set; }

        [NameInMap("isHotUpdate")]
        [Validation(Required=false)]
        public bool? IsHotUpdate { get; set; }

        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("newResourceSetting")]
        [Validation(Required=false)]
        public TuningHistoryNewResourceSetting NewResourceSetting { get; set; }
        public class TuningHistoryNewResourceSetting : TeaModel {
            [NameInMap("cpu")]
            [Validation(Required=false)]
            public double? Cpu { get; set; }

            [NameInMap("memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            [NameInMap("parallelism")]
            [Validation(Required=false)]
            public int? Parallelism { get; set; }

        }

        [NameInMap("oldResourceSetting")]
        [Validation(Required=false)]
        public TuningHistoryOldResourceSetting OldResourceSetting { get; set; }
        public class TuningHistoryOldResourceSetting : TeaModel {
            [NameInMap("cpu")]
            [Validation(Required=false)]
            public double? Cpu { get; set; }

            [NameInMap("memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            [NameInMap("parallelism")]
            [Validation(Required=false)]
            public int? Parallelism { get; set; }

        }

        [NameInMap("triggerTime")]
        [Validation(Required=false)]
        public long? TriggerTime { get; set; }

        [NameInMap("tuningId")]
        [Validation(Required=false)]
        public string TuningId { get; set; }

        [NameInMap("tuningMessage")]
        [Validation(Required=false)]
        public string TuningMessage { get; set; }

        [NameInMap("tuningState")]
        [Validation(Required=false)]
        public string TuningState { get; set; }

    }

}
