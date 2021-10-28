// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class CreateGatewayRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("GatewayClass")]
        [Validation(Required=false)]
        public string GatewayClass { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PostPaid")]
        [Validation(Required=false)]
        public bool? PostPaid { get; set; }

        [NameInMap("PublicNetworkBandwidth")]
        [Validation(Required=false)]
        public int? PublicNetworkBandwidth { get; set; }

        [NameInMap("ReleaseAfterExpiration")]
        [Validation(Required=false)]
        public bool? ReleaseAfterExpiration { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("StorageBundleId")]
        [Validation(Required=false)]
        public string StorageBundleId { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
