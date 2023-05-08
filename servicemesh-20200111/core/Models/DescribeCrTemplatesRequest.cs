// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeCrTemplatesRequest : TeaModel {
        /// <summary>
        /// The Istio version used in ASM.
        /// </summary>
        [NameInMap("IstioVersion")]
        [Validation(Required=false)]
        public string IstioVersion { get; set; }

        /// <summary>
        /// The type of Istio resource whose common YAML templates you want to query. Valid values:
        /// 
        /// *   AuthorizationPolicy
        /// *   RequestAuthentication
        /// *   PeerAuthentication
        /// *   WorkloadGroup
        /// *   WorkloadEntry
        /// *   Sidecar
        /// *   EnvoyFilter
        /// *   ServiceEntry
        /// *   Gateway
        /// *   DestinationRule
        /// *   VirtualService
        /// </summary>
        [NameInMap("Kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

    }

}
