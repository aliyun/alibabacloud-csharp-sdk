// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class NetworkConfig : TeaModel {
        [NameInMap("lbReplica")]
        [Validation(Required=false)]
        public int? LbReplica { get; set; }

        [NameInMap("loadBalanceConfig")]
        [Validation(Required=false)]
        public List<NetworkConfigLoadBalanceConfig> LoadBalanceConfig { get; set; }
        public class NetworkConfigLoadBalanceConfig : TeaModel {
            [NameInMap("vsArea")]
            [Validation(Required=false)]
            public string VsArea { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-xxxx</para>
            /// </summary>
            [NameInMap("vswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DEFAULT</para>
        /// </summary>
        [NameInMap("loadBalanceType")]
        [Validation(Required=false)]
        public string LoadBalanceType { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("vsArea")]
        [Validation(Required=false)]
        public string VsArea { get; set; }

        [NameInMap("vswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

        [NameInMap("whiteIpGroupList")]
        [Validation(Required=false)]
        public List<WhiteIpGroup> WhiteIpGroupList { get; set; }

    }

}
