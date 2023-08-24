// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateGlobalSecurityIPGroupResponseBody : TeaModel {
        /// <summary>
        /// 1
        /// </summary>
        [NameInMap("GlobalSecurityIPGroup")]
        [Validation(Required=false)]
        public List<CreateGlobalSecurityIPGroupResponseBodyGlobalSecurityIPGroup> GlobalSecurityIPGroup { get; set; }
        public class CreateGlobalSecurityIPGroupResponseBodyGlobalSecurityIPGroup : TeaModel {
            /// <summary>
            /// The IP address in the whitelist template.
            /// 
            /// >  Multiple IP addresses are separated by commas (,). You can create up to 1,000 IP addresses or CIDR blocks for all IP whitelists.
            /// </summary>
            [NameInMap("GIpList")]
            [Validation(Required=false)]
            public string GIpList { get; set; }

            /// <summary>
            /// The name of the IP whitelist template. The name must meet the following requirements:
            /// 
            /// *   The name can contain lowercase letters, digits, and underscores (\_).
            /// *   The name must start with a letter and end with a letter or digit.
            /// *   The name must be 2 to 120 characters in length.
            /// </summary>
            [NameInMap("GlobalIgName")]
            [Validation(Required=false)]
            public string GlobalIgName { get; set; }

            /// <summary>
            /// The ID of the IP whitelist template.
            /// </summary>
            [NameInMap("GlobalSecurityGroupId")]
            [Validation(Required=false)]
            public string GlobalSecurityGroupId { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
