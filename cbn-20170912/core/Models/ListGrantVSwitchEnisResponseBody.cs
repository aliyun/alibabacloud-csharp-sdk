// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListGrantVSwitchEnisResponseBody : TeaModel {
        /// <summary>
        /// The information about the ENI.
        /// </summary>
        [NameInMap("GrantVSwitchEnis")]
        [Validation(Required=false)]
        public List<ListGrantVSwitchEnisResponseBodyGrantVSwitchEnis> GrantVSwitchEnis { get; set; }
        public class ListGrantVSwitchEnisResponseBodyGrantVSwitchEnis : TeaModel {
            /// <summary>
            /// The ENI description.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ENI ID.
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// The ENI name.
            /// </summary>
            [NameInMap("NetworkInterfaceName")]
            [Validation(Required=false)]
            public string NetworkInterfaceName { get; set; }

            /// <summary>
            /// The primary private IPv4 address of the ENI.
            /// </summary>
            [NameInMap("PrimaryIpAddress")]
            [Validation(Required=false)]
            public string PrimaryIpAddress { get; set; }

            /// <summary>
            /// Indicates whether the ENI is created by a transit router. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// 
            /// ENIs that are created by transit routers cannot be used as multicast sources or members.
            /// </summary>
            [NameInMap("TransitRouterFlag")]
            [Validation(Required=false)]
            public bool? TransitRouterFlag { get; set; }

            /// <summary>
            /// The vSwitch ID.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The VPC ID.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// 
        /// > If MaxResults and NextToken are sued to query results by page, ignore this parameter.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
