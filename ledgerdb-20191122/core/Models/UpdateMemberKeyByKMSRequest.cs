// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ledgerdb20191122.Models
{
    public class UpdateMemberKeyByKMSRequest : TeaModel {
        [NameInMap("LedgerId")]
        [Validation(Required=false)]
        public string LedgerId { get; set; }

        [NameInMap("MemberId")]
        [Validation(Required=false)]
        public string MemberId { get; set; }

        [NameInMap("KeyType")]
        [Validation(Required=false)]
        public string KeyType { get; set; }

        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        [NameInMap("KMSKeyVersion")]
        [Validation(Required=false)]
        public string KMSKeyVersion { get; set; }

    }

}
