// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class GatewayNetworkConfiguration : TeaModel {
        /// <summary>
        /// <para>Network mode</para>
        /// </summary>
        [NameInMap("networkMode")]
        [Validation(Required=false)]
        public string NetworkMode { get; set; }

        /// <summary>
        /// <para>Virtual private cloud (VPC) ID</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("vswitchIds")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

    }

}
