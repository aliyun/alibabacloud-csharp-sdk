// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveDomainMappingRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("PushDomain")]
        [Validation(Required=true)]
        public string PushDomain { get; set; }

        [NameInMap("PullDomain")]
        [Validation(Required=true)]
        public string PullDomain { get; set; }

    }

}
