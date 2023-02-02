// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifySecurityIpsResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of the IP address whitelist group.
        /// </summary>
        [NameInMap("SecurityIpGroup")]
        [Validation(Required=false)]
        public ModifySecurityIpsResponseBodySecurityIpGroup SecurityIpGroup { get; set; }
        public class ModifySecurityIpsResponseBodySecurityIpGroup : TeaModel {
            /// <summary>
            /// The ID of the OceanBase cluster.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the security group.
            /// </summary>
            [NameInMap("SecurityIpGroupName")]
            [Validation(Required=false)]
            public string SecurityIpGroupName { get; set; }

            /// <summary>
            /// The list of IP addresses and CIDR blocks in the whitelist.   
            /// The return values of SecurityIps are strings that are separated with commas (,).
            /// </summary>
            [NameInMap("SecurityIps")]
            [Validation(Required=false)]
            public string SecurityIps { get; set; }

        }

    }

}
