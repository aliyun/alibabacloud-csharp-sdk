// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class NotifyContractEventRequest : TeaModel {
        [NameInMap("EventMessage")]
        [Validation(Required=false)]
        public string EventMessage { get; set; }

        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

    }

}
