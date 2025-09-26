// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class LLMAPIConfiguration : TeaModel {
        [NameInMap("aiProtocols")]
        [Validation(Required=false)]
        public List<string> AiProtocols { get; set; }

        [NameInMap("attachPolicyConfigs")]
        [Validation(Required=false)]
        public List<AttachPolicyConfig> AttachPolicyConfigs { get; set; }

        [NameInMap("basePath")]
        [Validation(Required=false)]
        public string BasePath { get; set; }

        [NameInMap("deployConfigs")]
        [Validation(Required=false)]
        public List<LLMDeployConfig> DeployConfigs { get; set; }

        [NameInMap("modelCategory")]
        [Validation(Required=false)]
        public string ModelCategory { get; set; }

        [NameInMap("removeBasePathOnForward")]
        [Validation(Required=false)]
        public bool? RemoveBasePathOnForward { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
