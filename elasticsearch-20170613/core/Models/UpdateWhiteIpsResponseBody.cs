// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateWhiteIpsResponseBody : TeaModel {
        /// <summary>
        /// The updated whitelist.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The network configurations.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateWhiteIpsResponseBodyResult Result { get; set; }
        public class UpdateWhiteIpsResponseBodyResult : TeaModel {
            /// <summary>
            /// The list of whitelists.
            /// </summary>
            [NameInMap("esIPWhitelist")]
            [Validation(Required=false)]
            public List<string> EsIPWhitelist { get; set; }

            /// <summary>
            /// The name of the whitelist. By default, the default whitelist is included.
            /// </summary>
            [NameInMap("networkConfig")]
            [Validation(Required=false)]
            public UpdateWhiteIpsResponseBodyResultNetworkConfig NetworkConfig { get; set; }
            public class UpdateWhiteIpsResponseBodyResultNetworkConfig : TeaModel {
                /// <summary>
                /// The IP addresses in the whitelist.
                /// </summary>
                [NameInMap("whiteIpGroupList")]
                [Validation(Required=false)]
                public List<UpdateWhiteIpsResponseBodyResultNetworkConfigWhiteIpGroupList> WhiteIpGroupList { get; set; }
                public class UpdateWhiteIpsResponseBodyResultNetworkConfigWhiteIpGroupList : TeaModel {
                    /// <summary>
                    /// The type of the whitelist. The value of this parameter is fixed as PRIVATE_ES, which indicates a private IP address whitelist.
                    /// </summary>
                    [NameInMap("groupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

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
