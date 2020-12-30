// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ledgerdb20191122.Models
{
    public class GetMemberResponseBody : TeaModel {
        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        [NameInMap("KeyType")]
        [Validation(Required=false)]
        public string KeyType { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PublicKey")]
        [Validation(Required=false)]
        public string PublicKey { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("LedgerId")]
        [Validation(Required=false)]
        public string LedgerId { get; set; }

        [NameInMap("KeySource")]
        [Validation(Required=false)]
        public string KeySource { get; set; }

        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("MemberId")]
        [Validation(Required=false)]
        public string MemberId { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

        [NameInMap("KMSKeyVersion")]
        [Validation(Required=false)]
        public string KMSKeyVersion { get; set; }

        [NameInMap("KeyMeta")]
        [Validation(Required=false)]
        public string KeyMeta { get; set; }

        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public string AliUid { get; set; }

    }

}
