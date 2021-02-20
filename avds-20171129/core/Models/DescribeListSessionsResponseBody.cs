// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avds20171129.Models
{
    public class DescribeListSessionsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Sessions")]
        [Validation(Required=false)]
        public List<DescribeListSessionsResponseBodySessions> Sessions { get; set; }
        public class DescribeListSessionsResponseBodySessions : TeaModel {
            [NameInMap("TTL")]
            [Validation(Required=false)]
            public int? TTL { get; set; }

            [NameInMap("Expired")]
            [Validation(Required=false)]
            public int? Expired { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public int? AliUid { get; set; }

            [NameInMap("ModifiedAt")]
            [Validation(Required=false)]
            public long? ModifiedAt { get; set; }

            [NameInMap("LoginSession")]
            [Validation(Required=false)]
            public string LoginSession { get; set; }

            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public int? SessionId { get; set; }

            [NameInMap("Asset")]
            [Validation(Required=false)]
            public string Asset { get; set; }

        }

    }

}
