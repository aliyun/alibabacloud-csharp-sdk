// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class CreateIpamResponseBody : TeaModel {
        [NameInMap("DefaultResourceDiscoveryAssociationId")]
        [Validation(Required=false)]
        public string DefaultResourceDiscoveryAssociationId { get; set; }

        [NameInMap("DefaultResourceDiscoveryId")]
        [Validation(Required=false)]
        public string DefaultResourceDiscoveryId { get; set; }

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

        [NameInMap("ResourceDiscoveryAssociationCount")]
        [Validation(Required=false)]
        public int? ResourceDiscoveryAssociationCount { get; set; }

    }

}
