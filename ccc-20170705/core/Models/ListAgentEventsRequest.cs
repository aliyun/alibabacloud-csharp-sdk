// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListAgentEventsRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("StopTime")]
        [Validation(Required=false)]
        public long? StopTime { get; set; }

        [NameInMap("RamId")]
        [Validation(Required=false)]
        public List<string> RamId { get; set; }

        [NameInMap("Event")]
        [Validation(Required=false)]
        public List<string> Event { get; set; }

    }

}
