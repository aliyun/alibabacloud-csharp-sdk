// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avds20171129.Models
{
    public class DescribeSessionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Session")]
        [Validation(Required=false)]
        public DescribeSessionResponseBodySession Session { get; set; }
        public class DescribeSessionResponseBodySession : TeaModel {
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
        };

    }

}
