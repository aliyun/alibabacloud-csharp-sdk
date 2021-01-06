// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class InviteAccountToResourceDirectoryResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Handshake")]
        [Validation(Required=true)]
        public InviteAccountToResourceDirectoryResponseHandshake Handshake { get; set; }
        public class InviteAccountToResourceDirectoryResponseHandshake : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }
            [NameInMap("ModifyTime")]
            [Validation(Required=true)]
            public string ModifyTime { get; set; }
            [NameInMap("ResourceDirectoryId")]
            [Validation(Required=true)]
            public string ResourceDirectoryId { get; set; }
            [NameInMap("HandshakeId")]
            [Validation(Required=true)]
            public string HandshakeId { get; set; }
            [NameInMap("MasterAccountName")]
            [Validation(Required=true)]
            public string MasterAccountName { get; set; }
            [NameInMap("Note")]
            [Validation(Required=true)]
            public string Note { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public string CreateTime { get; set; }
            [NameInMap("TargetType")]
            [Validation(Required=true)]
            public string TargetType { get; set; }
            [NameInMap("MasterAccountId")]
            [Validation(Required=true)]
            public string MasterAccountId { get; set; }
            [NameInMap("ExpireTime")]
            [Validation(Required=true)]
            public string ExpireTime { get; set; }
            [NameInMap("TargetEntity")]
            [Validation(Required=true)]
            public string TargetEntity { get; set; }
        };

    }

}
