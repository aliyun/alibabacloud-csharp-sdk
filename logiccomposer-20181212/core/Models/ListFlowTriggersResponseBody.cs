// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Logiccomposer20181212.Models
{
    public class ListFlowTriggersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Triggers")]
        [Validation(Required=false)]
        public List<ListFlowTriggersResponseBodyTriggers> Triggers { get; set; }
        public class ListFlowTriggersResponseBodyTriggers : TeaModel {
            [NameInMap("TriggerName")]
            [Validation(Required=false)]
            public string TriggerName { get; set; }

            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            [NameInMap("ActionsCount")]
            [Validation(Required=false)]
            public int? ActionsCount { get; set; }

            [NameInMap("TriggerActionName")]
            [Validation(Required=false)]
            public string TriggerActionName { get; set; }

            [NameInMap("TriggerDescription")]
            [Validation(Required=false)]
            public string TriggerDescription { get; set; }

            [NameInMap("TriggerActionDescription")]
            [Validation(Required=false)]
            public string TriggerActionDescription { get; set; }

            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

        }

    }

}
