// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ModifyWhiteIpsRequest : TeaModel {
        /// <summary>
        /// The information about the IP address whitelist that you want to update. You can specify only one whitelist.
        /// 
        /// > You cannot configure both the whiteIpList and whiteIpGroup parameters.
        /// </summary>
        [NameInMap("modifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

        /// <summary>
        /// The IP addresses in the whitelist. This parameter is available if the whiteIpGroup parameter is left empty. The default IP address whitelist is updated based on the value of this parameter.
        /// 
        /// > You cannot configure both the whiteIpList and whiteIpGroup parameters.
        /// </summary>
        [NameInMap("networkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// The IP addresses in the whitelist. This parameter is available if the whiteIpGroup parameter is left empty. The default IP address whitelist is updated based on the value of this parameter.
        /// </summary>
        [NameInMap("nodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// The IP addresses in the whitelist. This parameter is required if you configure the whiteIpGroup parameter.
        /// </summary>
        [NameInMap("whiteIpGroup")]
        [Validation(Required=false)]
        public ModifyWhiteIpsRequestWhiteIpGroup WhiteIpGroup { get; set; }
        public class ModifyWhiteIpsRequestWhiteIpGroup : TeaModel {
            /// <summary>
            /// The type of the IP address whitelist. Valid values:
            /// 
            /// *   PRIVATE_KIBANA
            /// *   PRIVATE_ES
            /// *   PUBLIC_ES
            /// *   PUBLIC_KIBANA
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The returned result.
            /// </summary>
            [NameInMap("ips")]
            [Validation(Required=false)]
            public List<string> Ips { get; set; }

            /// <summary>
            /// The request ID.
            /// </summary>
            [NameInMap("whiteIpType")]
            [Validation(Required=false)]
            public string WhiteIpType { get; set; }

        }

        /// <summary>
        /// The name of the whitelist. This parameter is required if you configure the whiteIpGroup parameter.
        /// </summary>
        [NameInMap("whiteIpList")]
        [Validation(Required=false)]
        public List<string> WhiteIpList { get; set; }

        /// <summary>
        /// The network type. This parameter is required if you configure the whiteIpList parameter. Valid values:
        /// 
        /// *   PRIVATE
        /// *   PUBLIC
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
