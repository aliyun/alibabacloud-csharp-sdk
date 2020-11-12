// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListHandshakesForResourceDirectoryResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("Handshakes")]
        [Validation(Required=true)]
        public ListHandshakesForResourceDirectoryResponseHandshakes Handshakes { get; set; }
        public class ListHandshakesForResourceDirectoryResponseHandshakes : TeaModel {
            [NameInMap("Handshake")]
            [Validation(Required=true)]
            public List<ListHandshakesForResourceDirectoryResponseHandshakesHandshake> Handshake { get; set; }
            public class ListHandshakesForResourceDirectoryResponseHandshakesHandshake : TeaModel {
                public string HandshakeId { get; set; }
                public string ResourceDirectoryId { get; set; }
                public string MasterAccountId { get; set; }
                public string MasterAccountName { get; set; }
                public string TargetEntity { get; set; }
                public string TargetType { get; set; }
                public string Note { get; set; }
                public string Status { get; set; }
                public string CreateTime { get; set; }
                public string ModifyTime { get; set; }
                public string ExpireTime { get; set; }
            }
        };

    }

}
