// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class ListRuleConditionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListRuleConditionsResponseBodyResult> Result { get; set; }
        public class ListRuleConditionsResponseBodyResult : TeaModel {
            [NameInMap("SelectionOperation")]
            [Validation(Required=false)]
            public string SelectionOperation { get; set; }

            [NameInMap("SelectValue")]
            [Validation(Required=false)]
            public string SelectValue { get; set; }

            [NameInMap("SelectType")]
            [Validation(Required=false)]
            public string SelectType { get; set; }

        }

    }

}
