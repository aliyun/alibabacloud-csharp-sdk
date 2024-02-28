// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeGlobalSecurityIPGroupRelationResponseBody : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The information about the associated global IP whitelist template.
        /// </summary>
        [NameInMap("GlobalSecurityIPGroupRel")]
        [Validation(Required=false)]
        public List<DescribeGlobalSecurityIPGroupRelationResponseBodyGlobalSecurityIPGroupRel> GlobalSecurityIPGroupRel { get; set; }
        public class DescribeGlobalSecurityIPGroupRelationResponseBodyGlobalSecurityIPGroupRel : TeaModel {
            /// <summary>
            /// The IP address in the IP whitelist template.
            /// 
            /// >  Multiple IP addresses are separated by commas (,).
            /// </summary>
            [NameInMap("GIpList")]
            [Validation(Required=false)]
            public string GIpList { get; set; }

            /// <summary>
            /// The name of the IP whitelist template.
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
