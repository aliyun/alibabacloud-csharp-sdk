// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveDomainPlayMappingRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PlayDomain")]
        [Validation(Required=false)]
        public string PlayDomain { get; set; }

        [NameInMap("PullDomain")]
        [Validation(Required=false)]
        public string PullDomain { get; set; }

    }

}
