// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CollectorDeployMachine : TeaModel {
        [NameInMap("configType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("machines")]
        [Validation(Required=false)]
        public List<CollectorDeployMachineMachines> Machines { get; set; }
        public class CollectorDeployMachineMachines : TeaModel {
            [NameInMap("agentStatus")]
            [Validation(Required=false)]
            public string AgentStatus { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        [NameInMap("successPodsCount")]
        [Validation(Required=false)]
        public string SuccessPodsCount { get; set; }

        [NameInMap("totalPodsCount")]
        [Validation(Required=false)]
        public string TotalPodsCount { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
