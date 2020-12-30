// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ListSmartAGByAccessPointResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SmartAccessGateways")]
        [Validation(Required=false)]
        public List<ListSmartAGByAccessPointResponseBodySmartAccessGateways> SmartAccessGateways { get; set; }
        public class ListSmartAGByAccessPointResponseBodySmartAccessGateways : TeaModel {
            [NameInMap("RoutingStrategy")]
            [Validation(Required=false)]
            public string RoutingStrategy { get; set; }

            [NameInMap("SmartAGName")]
            [Validation(Required=false)]
            public string SmartAGName { get; set; }

            [NameInMap("SmartAGId")]
            [Validation(Required=false)]
            public string SmartAGId { get; set; }

            [NameInMap("SmartAGStatus")]
            [Validation(Required=false)]
            public string SmartAGStatus { get; set; }

            [NameInMap("SmartAGDescription")]
            [Validation(Required=false)]
            public string SmartAGDescription { get; set; }

            [NameInMap("AssociatedCcnId")]
            [Validation(Required=false)]
            public string AssociatedCcnId { get; set; }

            [NameInMap("HardwareVersion")]
            [Validation(Required=false)]
            public string HardwareVersion { get; set; }

        }

    }

}
