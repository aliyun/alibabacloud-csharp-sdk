// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ContinuousStrategy : TeaModel {
        [NameInMap("dataDelayMinutes")]
        [Validation(Required=false)]
        public int? DataDelayMinutes { get; set; }

        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        [NameInMap("intervalUnit")]
        [Validation(Required=false)]
        public string IntervalUnit { get; set; }

        [NameInMap("intervalValue")]
        [Validation(Required=false)]
        public int? IntervalValue { get; set; }

    }

}
