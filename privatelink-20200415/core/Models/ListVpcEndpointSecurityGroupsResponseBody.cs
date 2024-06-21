// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointSecurityGroupsResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If no value is returned for **NextToken**, no next requests are performed.
        /// *   If a value is returned for **NextToken**, the value can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the security groups.
        /// </summary>
        [NameInMap("SecurityGroups")]
        [Validation(Required=false)]
        public List<ListVpcEndpointSecurityGroupsResponseBodySecurityGroups> SecurityGroups { get; set; }
        public class ListVpcEndpointSecurityGroupsResponseBodySecurityGroups : TeaModel {
            /// <summary>
            /// The ID of the security group that is associated with the endpoint.
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// The associate status of the security group, valid values:
            /// - Attaching: The security group is being attached.
            /// - Attached: The security group is attached.
            /// - Detaching: The security group is being detached.
            /// </summary>
            [NameInMap("SecurityGroupStatus")]
            [Validation(Required=false)]
            public string SecurityGroupStatus { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
