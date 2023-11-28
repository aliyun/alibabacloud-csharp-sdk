// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateKibanaWhiteIpsResponseBody : TeaModel {
        /// <summary>
        /// The details of the Elasticsearch cluster.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The private IP address whitelists for access to the Kibana console of the cluster.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateKibanaWhiteIpsResponseBodyResult Result { get; set; }
        public class UpdateKibanaWhiteIpsResponseBodyResult : TeaModel {
            /// <summary>
            /// The public IP address whitelists for access to the Kibana console of the cluster.
            /// </summary>
            [NameInMap("kibanaIPWhitelist")]
            [Validation(Required=false)]
            public List<string> KibanaIPWhitelist { get; set; }

            /// <summary>
            /// The private IP address whitelists for access to the Kibana console of the cluster.
            /// </summary>
            [NameInMap("kibanaPrivateIPWhitelist")]
            [Validation(Required=false)]
            public List<string> KibanaPrivateIPWhitelist { get; set; }

            /// <summary>
            /// The ID of the virtual private cloud (VPC).
            /// </summary>
            [NameInMap("networkConfig")]
            [Validation(Required=false)]
            public UpdateKibanaWhiteIpsResponseBodyResultNetworkConfig NetworkConfig { get; set; }
            public class UpdateKibanaWhiteIpsResponseBodyResultNetworkConfig : TeaModel {
                /// <summary>
                /// The IP address whitelists.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The ID of the vSwitch.
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The network type.
                /// </summary>
                [NameInMap("vsArea")]
                [Validation(Required=false)]
                public string VsArea { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

                /// <summary>
                /// The IP address whitelists.
                /// </summary>
                [NameInMap("whiteIpGroupList")]
                [Validation(Required=false)]
                public List<UpdateKibanaWhiteIpsResponseBodyResultNetworkConfigWhiteIpGroupList> WhiteIpGroupList { get; set; }
                public class UpdateKibanaWhiteIpsResponseBodyResultNetworkConfigWhiteIpGroupList : TeaModel {
                    /// <summary>
                    /// The IP addresses in the whitelist.
                    /// </summary>
                    [NameInMap("groupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    /// <summary>
                    /// The IP addresses in the whitelist.
                    /// </summary>
                    [NameInMap("ips")]
                    [Validation(Required=false)]
                    public List<string> Ips { get; set; }

                    [NameInMap("whiteIpType")]
                    [Validation(Required=false)]
                    public string WhiteIpType { get; set; }

                }

            }

        }

    }

}
