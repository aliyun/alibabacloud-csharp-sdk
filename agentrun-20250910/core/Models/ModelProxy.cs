// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ModelProxy : TeaModel {
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("credentialName")]
        [Validation(Required=false)]
        public string CredentialName { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        [NameInMap("litellmVersion")]
        [Validation(Required=false)]
        public string LitellmVersion { get; set; }

        [NameInMap("logConfiguration")]
        [Validation(Required=false)]
        public LogConfiguration LogConfiguration { get; set; }

        [NameInMap("memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        [NameInMap("modelProxyId")]
        [Validation(Required=false)]
        public string ModelProxyId { get; set; }

        [NameInMap("modelProxyName")]
        [Validation(Required=false)]
        public string ModelProxyName { get; set; }

        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        [NameInMap("networkConfiguration")]
        [Validation(Required=false)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        [NameInMap("proxyConfig")]
        [Validation(Required=false)]
        public ProxyConfig ProxyConfig { get; set; }

        [NameInMap("proxyMode")]
        [Validation(Required=false)]
        public string ProxyMode { get; set; }

        [NameInMap("serviceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("statusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

    }

}
