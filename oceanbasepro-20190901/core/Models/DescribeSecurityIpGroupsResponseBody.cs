// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeSecurityIpGroupsResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of the IP address whitelist group.
        /// </summary>
        [NameInMap("SecurityIpGroups")]
        [Validation(Required=false)]
        public List<DescribeSecurityIpGroupsResponseBodySecurityIpGroups> SecurityIpGroups { get; set; }
        public class DescribeSecurityIpGroupsResponseBodySecurityIpGroups : TeaModel {
            /// <summary>
            /// The name of the security group.
            /// </summary>
            [NameInMap("SecurityIpGroupName")]
            [Validation(Required=false)]
            public string SecurityIpGroupName { get; set; }

            /// <summary>
            /// The list of IP addresses and CIDR blocks in the whitelist.   
            /// It is a JSON array. Each object in the array is an IP address or CIDR block.
            /// </summary>
            [NameInMap("SecurityIps")]
            [Validation(Required=false)]
            public string SecurityIps { get; set; }

        }

        /// <summary>
        /// The number of whitelist groups returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
