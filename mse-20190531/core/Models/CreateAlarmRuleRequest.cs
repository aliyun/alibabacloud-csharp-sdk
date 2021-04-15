// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateAlarmRuleRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("AlarmAliasName")]
        [Validation(Required=false)]
        public string AlarmAliasName { get; set; }

        [NameInMap("AlertWay")]
        [Validation(Required=false)]
        public Dictionary<string, object> AlertWay { get; set; }

        [NameInMap("ContactGroupIds")]
        [Validation(Required=false)]
        public Dictionary<string, object> ContactGroupIds { get; set; }

        [NameInMap("AlarmItem")]
        [Validation(Required=false)]
        public string AlarmItem { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("Aggregates")]
        [Validation(Required=false)]
        public string Aggregates { get; set; }

        [NameInMap("NValue")]
        [Validation(Required=false)]
        public int? NValue { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public float? Value { get; set; }

    }

}
