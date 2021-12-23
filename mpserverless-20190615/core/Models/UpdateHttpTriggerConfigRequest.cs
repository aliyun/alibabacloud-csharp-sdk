// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class UpdateHttpTriggerConfigRequest : TeaModel {
        [NameInMap("CustomDomain")]
        [Validation(Required=false)]
        public string CustomDomain { get; set; }

        [NameInMap("CustomDomainCertificate")]
        [Validation(Required=false)]
        public string CustomDomainCertificate { get; set; }

        [NameInMap("CustomDomainPrivateKey")]
        [Validation(Required=false)]
        public string CustomDomainPrivateKey { get; set; }

        [NameInMap("EnableService")]
        [Validation(Required=false)]
        public bool? EnableService { get; set; }

        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

    }

}
