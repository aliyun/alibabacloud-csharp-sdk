// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateDIAlarmRuleShrinkRequest : TeaModel {
        [NameInMap("DIAlarmRuleId")]
        [Validation(Required=false)]
        public long? DIAlarmRuleId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        [NameInMap("NotificationSettings")]
        [Validation(Required=false)]
        public string NotificationSettingsShrink { get; set; }

        [NameInMap("TriggerConditions")]
        [Validation(Required=false)]
        public string TriggerConditionsShrink { get; set; }

    }

}
