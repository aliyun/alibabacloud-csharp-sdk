// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryShareListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryShareListResponseBodyResult> Result { get; set; }
        public class QueryShareListResponseBodyResult : TeaModel {
            [NameInMap("AuthPoint")]
            [Validation(Required=false)]
            public int? AuthPoint { get; set; }

            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public long? ExpireDate { get; set; }

            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            [NameInMap("ShareId")]
            [Validation(Required=false)]
            public string ShareId { get; set; }

            [NameInMap("ShareToId")]
            [Validation(Required=false)]
            public string ShareToId { get; set; }

            [NameInMap("ShareToName")]
            [Validation(Required=false)]
            public string ShareToName { get; set; }

            [NameInMap("ShareToType")]
            [Validation(Required=false)]
            public int? ShareToType { get; set; }

            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
