// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class ListHandshakesForResourceDirectoryResponseBody : TeaModel {
        [NameInMap("Handshakes")]
        [Validation(Required=false)]
        public ListHandshakesForResourceDirectoryResponseBodyHandshakes Handshakes { get; set; }
        public class ListHandshakesForResourceDirectoryResponseBodyHandshakes : TeaModel {
            [NameInMap("Handshake")]
            [Validation(Required=false)]
            public List<ListHandshakesForResourceDirectoryResponseBodyHandshakesHandshake> Handshake { get; set; }
            public class ListHandshakesForResourceDirectoryResponseBodyHandshakesHandshake : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("HandshakeId")]
                [Validation(Required=false)]
                public string HandshakeId { get; set; }

                [NameInMap("MasterAccountId")]
                [Validation(Required=false)]
                public string MasterAccountId { get; set; }

                [NameInMap("MasterAccountName")]
                [Validation(Required=false)]
                public string MasterAccountName { get; set; }

                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                [NameInMap("Note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                [NameInMap("ResourceDirectoryId")]
                [Validation(Required=false)]
                public string ResourceDirectoryId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TargetEntity")]
                [Validation(Required=false)]
                public string TargetEntity { get; set; }

                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

        }

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
