// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class EventBridgeTriggerConfig : TeaModel {
        /// <summary>
        /// asyncInvocationType
        /// </summary>
        [NameInMap("asyncInvocationType")]
        [Validation(Required=false)]
        public bool? AsyncInvocationType { get; set; }

        /// <summary>
        /// eventRuleFilterPattern
        /// </summary>
        [NameInMap("eventRuleFilterPattern")]
        [Validation(Required=false)]
        public string EventRuleFilterPattern { get; set; }

        [NameInMap("eventSourceConfig")]
        [Validation(Required=false)]
        public EventSourceConfig EventSourceConfig { get; set; }

        /// <summary>
        /// triggerEnable
        /// </summary>
        [NameInMap("triggerEnable")]
        [Validation(Required=false)]
        public bool? TriggerEnable { get; set; }

    }

}
