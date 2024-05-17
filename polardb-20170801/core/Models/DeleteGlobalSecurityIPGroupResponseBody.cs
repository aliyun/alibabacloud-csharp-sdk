// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DeleteGlobalSecurityIPGroupResponseBody : TeaModel {
        /// <summary>
        /// The details of the global IP whitelist template.
        /// </summary>
        [NameInMap("GlobalSecurityIPGroup")]
        [Validation(Required=false)]
        public List<DeleteGlobalSecurityIPGroupResponseBodyGlobalSecurityIPGroup> GlobalSecurityIPGroup { get; set; }
        public class DeleteGlobalSecurityIPGroupResponseBodyGlobalSecurityIPGroup : TeaModel {
            /// <summary>
            /// The clusters that are associated with the IP address whitelist template.
            /// </summary>
            [NameInMap("DBInstances")]
            [Validation(Required=false)]
            public List<string> DBInstances { get; set; }

            /// <summary>
            /// The IP address in the whitelist template.
            /// 
            /// >  Multiple IP addresses are separated by commas (,). You can create up to 1,000 IP addresses or CIDR blocks for all IP whitelists.
            /// </summary>
            [NameInMap("GIpList")]
            [Validation(Required=false)]
            public string GIpList { get; set; }

            /// <summary>
            /// The name of the global IP whitelist template. The name must meet the following requirements:
            /// 
            /// *   The name can contain lowercase letters, digits, and underscores (_).
            /// *   The name must start with a letter and end with a letter or a digit.
            /// *   The name must be 2 to 120 characters in length.
            /// </summary>
            [NameInMap("GlobalIgName")]
            [Validation(Required=false)]
            public string GlobalIgName { get; set; }

            /// <summary>
            /// The ID of the global IP whitelist template.
            /// </summary>
            [NameInMap("GlobalSecurityGroupId")]
            [Validation(Required=false)]
            public string GlobalSecurityGroupId { get; set; }

            /// <summary>
            /// The ID of the region.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
