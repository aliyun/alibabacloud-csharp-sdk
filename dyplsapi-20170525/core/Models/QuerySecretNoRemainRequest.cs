// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QuerySecretNoRemainRequest : TeaModel {
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecretNo")]
        [Validation(Required=false)]
        public string SecretNo { get; set; }

        [NameInMap("SpecId")]
        [Validation(Required=false)]
        public long? SpecId { get; set; }

    }

}
