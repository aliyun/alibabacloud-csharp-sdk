// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeGlobalSecurityIPGroupRelationResponseBody : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The global IP whitelist templates associated with the instance.
        /// </summary>
        [NameInMap("GlobalSecurityIPGroupRel")]
        [Validation(Required=false)]
        public List<DescribeGlobalSecurityIPGroupRelationResponseBodyGlobalSecurityIPGroupRel> GlobalSecurityIPGroupRel { get; set; }
        public class DescribeGlobalSecurityIPGroupRelationResponseBodyGlobalSecurityIPGroupRel : TeaModel {
            /// <summary>
            /// The IP addresses in the whitelist template.
            /// 
            /// >  Separate multiple IP addresses with commas (,). You can create up to 1,000 IP addresses or CIDR blocks for all IP whitelists.
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
            /// The region ID of the instance.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// The unique ID of the request. If the request fails, provide this ID for technical support to troubleshoot the failure.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
