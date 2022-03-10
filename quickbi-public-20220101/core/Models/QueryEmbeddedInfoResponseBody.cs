// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryEmbeddedInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryEmbeddedInfoResponseBodyResult Result { get; set; }
        public class QueryEmbeddedInfoResponseBodyResult : TeaModel {
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public QueryEmbeddedInfoResponseBodyResultDetail Detail { get; set; }
            public class QueryEmbeddedInfoResponseBodyResultDetail : TeaModel {
                [NameInMap("DashboardOfflineQuery")]
                [Validation(Required=false)]
                public int? DashboardOfflineQuery { get; set; }

                [NameInMap("Page")]
                [Validation(Required=false)]
                public int? Page { get; set; }

                [NameInMap("Report")]
                [Validation(Required=false)]
                public int? Report { get; set; }

            }
            [NameInMap("EmbeddedCount")]
            [Validation(Required=false)]
            public int? EmbeddedCount { get; set; }
            [NameInMap("MaxCount")]
            [Validation(Required=false)]
            public int? MaxCount { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
