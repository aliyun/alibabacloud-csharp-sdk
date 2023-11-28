// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateKibanaWhiteIpsRequest : TeaModel {
        /// <summary>
        /// The IP address whitelists. This parameter is available if the whiteIpGroup parameter is left empty. The default IP address whitelist is updated based on the value of this parameter.
        /// 
        /// You cannot configure both the kibanaIPWhitelist and whiteIpGroup parameters.
        /// </summary>
        [NameInMap("kibanaIPWhitelist")]
        [Validation(Required=false)]
        public List<string> KibanaIPWhitelist { get; set; }

        /// <summary>
        /// The name of the whitelist. This parameter is required if you configure the whiteIpGroup parameter.
        /// </summary>
        [NameInMap("whiteIpGroup")]
        [Validation(Required=false)]
        public UpdateKibanaWhiteIpsRequestWhiteIpGroup WhiteIpGroup { get; set; }
        public class UpdateKibanaWhiteIpsRequestWhiteIpGroup : TeaModel {
            /// <summary>
            /// The type of the whitelist. Set the value to PUBLIC_KIBANA. This value indicates a public IP address whitelist.
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The IP addresses in the whitelist. This parameter is required if you configure the whiteIpGroup parameter.
            /// </summary>
            [NameInMap("ips")]
            [Validation(Required=false)]
            public List<string> Ips { get; set; }

            /// <summary>
            /// The IP addresses in the whitelist.
            /// </summary>
            [NameInMap("whiteIpType")]
            [Validation(Required=false)]
            public string WhiteIpType { get; set; }

        }

        /// <summary>
        /// The update mode. Valid values:
        /// 
        /// *   Cover: overwrites the IP addresses in the specified IP address whitelist with the IP addresses specified by using the ips parameter. This is the default value.
        /// *   Append: adds the IP addresses specified by using the ips parameter to the specified IP address whitelist.
        /// *   Delete: deletes the IP addresses specified by using the ips parameter from the specified IP address whitelist. At least one IP address must be retained for the whitelist.
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The body of the request.
        /// </summary>
        [NameInMap("modifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

    }

}
