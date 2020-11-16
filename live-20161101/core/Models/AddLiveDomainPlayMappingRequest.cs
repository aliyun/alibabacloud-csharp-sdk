// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveDomainPlayMappingRequest : TeaModel {
        [NameInMap("PlayDomain")]
        [Validation(Required=true)]
        public string PlayDomain { get; set; }

        [NameInMap("PullDomain")]
        [Validation(Required=true)]
        public string PullDomain { get; set; }

    }

}
