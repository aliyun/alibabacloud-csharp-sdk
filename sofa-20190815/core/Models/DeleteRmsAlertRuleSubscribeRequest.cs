// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DeleteRmsAlertRuleSubscribeRequest : TeaModel {
        [NameInMap("EnvJsonStr")]
        [Validation(Required=false)]
        public string EnvJsonStr { get; set; }

        [NameInMap("MonitorTargetType")]
        [Validation(Required=false)]
        public string MonitorTargetType { get; set; }

        [NameInMap("SubscriptionTargetId")]
        [Validation(Required=false)]
        public string SubscriptionTargetId { get; set; }

        [NameInMap("SubscriptionTargetType")]
        [Validation(Required=false)]
        public string SubscriptionTargetType { get; set; }

    }

}
