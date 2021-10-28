// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class RemoveSharesFromExpressSyncRequest : TeaModel {
        [NameInMap("ExpressSyncId")]
        [Validation(Required=false)]
        public string ExpressSyncId { get; set; }

        [NameInMap("GatewayShares")]
        [Validation(Required=false)]
        public string GatewayShares { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
