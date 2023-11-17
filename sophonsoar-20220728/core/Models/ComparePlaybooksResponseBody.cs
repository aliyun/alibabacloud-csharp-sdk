// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class ComparePlaybooksResponseBody : TeaModel {
        [NameInMap("CompareResult")]
        [Validation(Required=false)]
        public ComparePlaybooksResponseBodyCompareResult CompareResult { get; set; }
        public class ComparePlaybooksResponseBodyCompareResult : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("New")]
            [Validation(Required=false)]
            public bool? New { get; set; }

            [NameInMap("Same")]
            [Validation(Required=false)]
            public bool? Same { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
