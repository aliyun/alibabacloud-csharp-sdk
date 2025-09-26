// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class Model : TeaModel {
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        [NameInMap("models")]
        [Validation(Required=false)]
        public string Models { get; set; }

        [NameInMap("modelsWeight")]
        [Validation(Required=false)]
        public string ModelsWeight { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        [NameInMap("targetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
