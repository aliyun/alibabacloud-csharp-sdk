// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class LLMDeployConfig : TeaModel {
        [NameInMap("autoDeploy")]
        [Validation(Required=false)]
        public bool? AutoDeploy { get; set; }

        [NameInMap("backendScene")]
        [Validation(Required=false)]
        public string BackendScene { get; set; }

        [NameInMap("customDomainIds")]
        [Validation(Required=false)]
        public List<string> CustomDomainIds { get; set; }

        [NameInMap("gatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        [NameInMap("policyConfigs")]
        [Validation(Required=false)]
        public List<PolicyConfig> PolicyConfigs { get; set; }

        [NameInMap("serviceConfigs")]
        [Validation(Required=false)]
        public List<TargetServiceConfig> ServiceConfigs { get; set; }

    }

}
