// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class UpdateAiOutboundTaskRequest : TeaModel {
        [NameInMap("ConcurrentRate")]
        [Validation(Required=false)]
        public int? ConcurrentRate { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ExecutionTime")]
        [Validation(Required=false)]
        public string ExecutionTime { get; set; }

        [NameInMap("ForecastCallRate")]
        [Validation(Required=false)]
        public float? ForecastCallRate { get; set; }

        [NameInMap("HandlerId")]
        [Validation(Required=false)]
        public long? HandlerId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NumRepeated")]
        [Validation(Required=false)]
        public int? NumRepeated { get; set; }

        [NameInMap("OutboundNums")]
        [Validation(Required=false)]
        public List<string> OutboundNums { get; set; }

        [NameInMap("RecallRule")]
        [Validation(Required=false)]
        public UpdateAiOutboundTaskRequestRecallRule RecallRule { get; set; }
        public class UpdateAiOutboundTaskRequestRecallRule : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

        }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
