// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class SetTransferCalleePoolConfigRequest : TeaModel {
        [NameInMap("CalledRouteMode")]
        [Validation(Required=false)]
        public string CalledRouteMode { get; set; }

        [NameInMap("Details")]
        [Validation(Required=false)]
        public List<SetTransferCalleePoolConfigRequestDetails> Details { get; set; }
        public class SetTransferCalleePoolConfigRequestDetails : TeaModel {
            [NameInMap("Called")]
            [Validation(Required=false)]
            public string Called { get; set; }

            [NameInMap("Caller")]
            [Validation(Required=false)]
            public string Caller { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        [NameInMap("QualificationId")]
        [Validation(Required=false)]
        public string QualificationId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
