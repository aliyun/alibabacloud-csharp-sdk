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
            /// The description of the ENI.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the ENI.
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// Indicates whether the ENI is created by a transit router. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// 
            /// ENIs that are created by transit routers cannot be used as multicast sources or members.
            /// </summary>
            [NameInMap("TransitRouterFlag")]
            [Validation(Required=false)]
            public bool? TransitRouterFlag { get; set; }

            /// <summary>
            /// The ID of the vSwitch.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The ID of the VPC.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
