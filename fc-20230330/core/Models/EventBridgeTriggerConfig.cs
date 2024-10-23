// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class EventBridgeTriggerConfig : TeaModel {
        [NameInMap("asyncInvocationType")]
        [Validation(Required=false)]
        public bool? AsyncInvocationType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("eventRuleFilterPattern")]
        [Validation(Required=false)]
        public string EventRuleFilterPattern { get; set; }

        [NameInMap("eventSinkConfig")]
        [Validation(Required=false)]
        public EventSinkConfig EventSinkConfig { get; set; }

        [NameInMap("eventSourceConfig")]
        [Validation(Required=false)]
        public EventSourceConfig EventSourceConfig { get; set; }

        [NameInMap("runOptions")]
        [Validation(Required=false)]
        public RunOptions RunOptions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("triggerEnable")]
        [Validation(Required=false)]
        public bool? TriggerEnable { get; set; }

    }

}
