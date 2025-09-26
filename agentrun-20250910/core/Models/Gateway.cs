// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class Gateway : TeaModel {
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        [NameInMap("internetUrl")]
        [Validation(Required=false)]
        public string InternetUrl { get; set; }

        [NameInMap("intranetUrl")]
        [Validation(Required=false)]
        public string IntranetUrl { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
