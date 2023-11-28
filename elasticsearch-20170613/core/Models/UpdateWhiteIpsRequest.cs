// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateWhiteIpsRequest : TeaModel {
        /// <summary>
        /// The name of the whitelist. This parameter is required if you configure the whiteIpGroup parameter.
        /// </summary>
        [NameInMap("esIPWhitelist")]
        [Validation(Required=false)]
        public List<string> EsIPWhitelist { get; set; }

        /// <summary>
        /// The IP addresses in the whitelist. This parameter is required if you configure the whiteIpGroup parameter.
        /// </summary>
        [NameInMap("whiteIpGroup")]
        [Validation(Required=false)]
        public UpdateWhiteIpsRequestWhiteIpGroup WhiteIpGroup { get; set; }
        public class UpdateWhiteIpsRequestWhiteIpGroup : TeaModel {
            /// <summary>
            /// The type of the whitelist. Set the value to **PRIVATE_ES**. This value indicates a private IP address whitelist.
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
            /// The returned result.
            /// </summary>
            [NameInMap("whiteIpType")]
            [Validation(Required=false)]
            public string WhiteIpType { get; set; }

        }

        /// <summary>
        /// The IP addresses in the whitelist.
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The IP addresses in the whitelist. This parameter is available if the whiteIpGroup parameter is left empty. The default IP address whitelist is updated based on the value of this parameter.
        /// 
        /// >  You cannot configure both the esIPWhitelist and whiteIpGroup parameters.
        /// </summary>
        [NameInMap("modifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

    }

}
