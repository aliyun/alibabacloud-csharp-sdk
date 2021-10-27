// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListHandshakesForAccountResponseBody : TeaModel {
        [NameInMap("Handshakes")]
        [Validation(Required=false)]
        public ListHandshakesForAccountResponseBodyHandshakes Handshakes { get; set; }
        public class ListHandshakesForAccountResponseBodyHandshakes : TeaModel {
            [NameInMap("Handshake")]
            [Validation(Required=false)]
            public List<ListHandshakesForAccountResponseBodyHandshakesHandshake> Handshake { get; set; }
            public class ListHandshakesForAccountResponseBodyHandshakesHandshake : TeaModel {
                public string CreateTime { get; set; }
                public string ExpireTime { get; set; }
                public string HandshakeId { get; set; }
                public string MasterAccountId { get; set; }
                public string MasterAccountName { get; set; }
                public string ModifyTime { get; set; }
                public string Note { get; set; }
                public string ResourceDirectoryId { get; set; }
                public string Status { get; set; }
                public string TargetEntity { get; set; }
                public string TargetType { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
