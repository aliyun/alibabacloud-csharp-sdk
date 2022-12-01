// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetHandshakeResponseBody : TeaModel {
        [NameInMap("Handshake")]
        [Validation(Required=false)]
        public GetHandshakeResponseBodyHandshake Handshake { get; set; }
        public class GetHandshakeResponseBodyHandshake : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("HandshakeId")]
            [Validation(Required=false)]
            public string HandshakeId { get; set; }

            [NameInMap("InvitedAccountRealName")]
            [Validation(Required=false)]
            public string InvitedAccountRealName { get; set; }

            [NameInMap("MasterAccountId")]
            [Validation(Required=false)]
            public string MasterAccountId { get; set; }

            [NameInMap("MasterAccountName")]
            [Validation(Required=false)]
            public string MasterAccountName { get; set; }

            [NameInMap("MasterAccountRealName")]
            [Validation(Required=false)]
            public string MasterAccountRealName { get; set; }

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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
