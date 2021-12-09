// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ReplicationProgressRule : TeaModel {
        /// <summary>
        /// A short description of action
        /// </summary>
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("Destination")]
        [Validation(Required=false)]
        public ReplicationDestination Destination { get; set; }

        /// <summary>
        /// A short description of HistoricalObjectReplication
        /// </summary>
        [NameInMap("HistoricalObjectReplication")]
        [Validation(Required=false)]
        public string HistoricalObjectReplication { get; set; }

        /// <summary>
        /// rule id
        /// </summary>
        [NameInMap("ID")]
        [Validation(Required=false)]
        public string ID { get; set; }

        [NameInMap("PrefixSet")]
        [Validation(Required=false)]
        public ReplicationPrefixSet PrefixSet { get; set; }

        /// <summary>
        /// A short description of Progress
        /// </summary>
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
        };

        /// <summary>
        /// A short description of action
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
