// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantSecurityIpGroupsResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of the whitelist groups.
        /// </summary>
        [NameInMap("SecurityIpGroups")]
        [Validation(Required=false)]
        public List<DescribeTenantSecurityIpGroupsResponseBodySecurityIpGroups> SecurityIpGroups { get; set; }
        public class DescribeTenantSecurityIpGroupsResponseBodySecurityIpGroups : TeaModel {
            /// <summary>
            /// The group name.
            /// </summary>
            [NameInMap("SecurityIpGroupName")]
            [Validation(Required=false)]
            public string SecurityIpGroupName { get; set; }

            /// <summary>
            /// The whitelist group type.
            /// - instance: the whitelist group from the cluster.
            /// - tenant: the whitelist group of the current tenant.
            /// </summary>
            [NameInMap("SecurityIpGroupType")]
            [Validation(Required=false)]
            public string SecurityIpGroupType { get; set; }

            /// <summary>
            /// The whitelist of IP addresses. It is a string separated by commas, and each object is an IP string or a CIDR block.
            /// </summary>
            [NameInMap("SecurityIps")]
            [Validation(Required=false)]
            public string SecurityIps { get; set; }

            /// <summary>
            /// The ID of the tenant.
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// The total number of the whitelist groups.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
