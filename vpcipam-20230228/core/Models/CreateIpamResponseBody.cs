// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class CreateIpamResponseBody : TeaModel {
        [NameInMap("IpamId")]
        [Validation(Required=false)]
        public string IpamId { get; set; }

        [NameInMap("PrivateDefaultScopeId")]
        [Validation(Required=false)]
        public string PrivateDefaultScopeId { get; set; }

        [NameInMap("PublicDefaultScopeId")]
        [Validation(Required=false)]
        public string PublicDefaultScopeId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
