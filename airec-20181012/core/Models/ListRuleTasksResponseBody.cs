// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class ListRuleTasksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListRuleTasksResponseBodyResult Result { get; set; }
        public class ListRuleTasksResponseBodyResult : TeaModel {
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public int? FinishTime { get; set; }
            [NameInMap("FinishRate")]
            [Validation(Required=false)]
            public int? FinishRate { get; set; }
        };

    }

}
