// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypls20170830.Models
{
    public class CreateRingToneRequest : TeaModel {
        [NameInMap("BillId")]
        [Validation(Required=false)]
        public string BillId { get; set; }

        [NameInMap("FileKey")]
        [Validation(Required=false)]
        public string FileKey { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PlayType")]
        [Validation(Required=false)]
        public string PlayType { get; set; }

        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RingName")]
        [Validation(Required=false)]
        public string RingName { get; set; }

        [NameInMap("Tts")]
        [Validation(Required=false)]
        public string Tts { get; set; }

    }

}
