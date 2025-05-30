// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yunjian20211217.Models
{
    public class AcceptFulfillmentDecisionRequest : TeaModel {
        [NameInMap("DecisionConclusion")]
        [Validation(Required=false)]
        public string DecisionConclusion { get; set; }

        [NameInMap("DecisionType")]
        [Validation(Required=false)]
        public string DecisionType { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

    }

}
