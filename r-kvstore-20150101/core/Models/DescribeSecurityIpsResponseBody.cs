// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeSecurityIpsResponseBody : TeaModel {
        /// <summary>
        /// The name of the whitelist.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("SecurityIpGroups")]
        [Validation(Required=false)]
        public DescribeSecurityIpsResponseBodySecurityIpGroups SecurityIpGroups { get; set; }
        public class DescribeSecurityIpsResponseBodySecurityIpGroups : TeaModel {
            [NameInMap("SecurityIpGroup")]
            [Validation(Required=false)]
            public List<DescribeSecurityIpsResponseBodySecurityIpGroupsSecurityIpGroup> SecurityIpGroup { get; set; }
            public class DescribeSecurityIpsResponseBodySecurityIpGroupsSecurityIpGroup : TeaModel {
                /// <summary>
                /// The operation that you want to perform. Set the value to **DescribeSecurityIps**.
                /// </summary>
                [NameInMap("SecurityIpGroupAttribute")]
                [Validation(Required=false)]
                public string SecurityIpGroupAttribute { get; set; }

                [NameInMap("SecurityIpGroupName")]
                [Validation(Required=false)]
                public string SecurityIpGroupName { get; set; }

                [NameInMap("SecurityIpList")]
                [Validation(Required=false)]
                public string SecurityIpList { get; set; }

            }

        }

    }

}
