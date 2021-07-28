// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20210325.Models
{
    public class ListSignaturesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSignaturesResponseBodyData Data { get; set; }
        public class ListSignaturesResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Signatures")]
            [Validation(Required=false)]
            public List<ListSignaturesResponseBodyDataSignatures> Signatures { get; set; }
            public class ListSignaturesResponseBodyDataSignatures : TeaModel {
                public string CreatedTime { get; set; }
                public string ID { get; set; }
                public string Name { get; set; }
                public int? Status { get; set; }
                public string UpdatedTime { get; set; }
            }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

    }

}
