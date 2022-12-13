/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ProblemLevelGroupValue : TeaModel {
        [NameInMap("childRuleRelation")]
        [Validation(Required=false)]
        public int? ChildRuleRelation { get; set; }

        [NameInMap("matchCount")]
        [Validation(Required=false)]
        public long? MatchCount { get; set; }

        [NameInMap("timeWindow")]
        [Validation(Required=false)]
        public long? TimeWindow { get; set; }

        [NameInMap("timeWindowUnit")]
        [Validation(Required=false)]
        public string TimeWindowUnit { get; set; }

        [NameInMap("enableUpgrade")]
        [Validation(Required=false)]
        public bool? EnableUpgrade { get; set; }

        [NameInMap("upgradeTimeWindow")]
        [Validation(Required=false)]
        public long? UpgradeTimeWindow { get; set; }

        [NameInMap("upgradeTimeWindowUnit")]
        [Validation(Required=false)]
        public string UpgradeTimeWindowUnit { get; set; }

    }

}
