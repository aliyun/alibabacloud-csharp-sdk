// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AgentInfo : TeaModel {
        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("agentAccess")]
        [Validation(Required=false)]
        public AgentInfoAgentAccess AgentAccess { get; set; }
        public class AgentInfoAgentAccess : TeaModel {
            [NameInMap("httpApiId")]
            [Validation(Required=false)]
            public string HttpApiId { get; set; }

        }

        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        [NameInMap("agentType")]
        [Validation(Required=false)]
        public string AgentType { get; set; }

        [NameInMap("allowedCapabilities")]
        [Validation(Required=false)]
        public List<string> AllowedCapabilities { get; set; }

        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("modelAccess")]
        [Validation(Required=false)]
        public AgentInfoModelAccess ModelAccess { get; set; }
        public class AgentInfoModelAccess : TeaModel {
            [NameInMap("consumerIds")]
            [Validation(Required=false)]
            public List<string> ConsumerIds { get; set; }

            [NameInMap("modelApiId")]
            [Validation(Required=false)]
            public string ModelApiId { get; set; }

        }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("updateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
