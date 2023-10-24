// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddImageEventOperationRequest : TeaModel {
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public string Conditions { get; set; }

        [NameInMap("EventKey")]
        [Validation(Required=false)]
        public string EventKey { get; set; }

        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        [NameInMap("OperationCode")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

        [NameInMap("Scenarios")]
        [Validation(Required=false)]
        public string Scenarios { get; set; }

    }

}
