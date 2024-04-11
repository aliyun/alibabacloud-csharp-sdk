// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class DeleteGatewayIsolationRuleRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        [NameInMap("RouteId")]
        [Validation(Required=false)]
        public long? RouteId { get; set; }

        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

    }

}
