// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeGatewaysTagsRequest : TeaModel {
        [NameInMap("GatewayIds")]
        [Validation(Required=false)]
        public string GatewayIds { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("StorageBundleId")]
        [Validation(Required=false)]
        public string StorageBundleId { get; set; }

        [NameInMap("TagCategory")]
        [Validation(Required=false)]
        public string TagCategory { get; set; }

    }

}
