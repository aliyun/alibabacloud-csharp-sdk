// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class ListDashboardUidResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListDashboardUidResponseBodyResult Result { get; set; }
        public class ListDashboardUidResponseBodyResult : TeaModel {
            [NameInMap("Num")]
            [Validation(Required=false)]
            public int? Num { get; set; }
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public List<string> Uid { get; set; }
        };

    }

}
