// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ReplicationProgressRule : TeaModel {
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("Destination")]
        [Validation(Required=false)]
        public ReplicationDestination Destination { get; set; }

        [NameInMap("HistoricalObjectReplication")]
        [Validation(Required=false)]
        public string HistoricalObjectReplication { get; set; }

        [NameInMap("ID")]
        [Validation(Required=false)]
        public string ID { get; set; }

        [NameInMap("PrefixSet")]
        [Validation(Required=false)]
        public ReplicationPrefixSet PrefixSet { get; set; }

        [NameInMap("Progress")]
        [Validation(Required=false)]
        public ReplicationProgressRuleProgress Progress { get; set; }
        public class ReplicationProgressRuleProgress : TeaModel {
            [NameInMap("HistoricalObject")]
            [Validation(Required=false)]
            public string HistoricalObject { get; set; }

            [NameInMap("NewObject")]
            [Validation(Required=false)]
            public string NewObject { get; set; }

        }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
