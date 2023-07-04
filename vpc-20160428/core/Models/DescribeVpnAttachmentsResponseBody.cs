// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnAttachmentsResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        public int? TotalCount { get; set; }

        /// <summary>
        /// The list of IPsec-VPN connections associated with the transit router.
        /// </summary>
        [NameInMap("VpnAttachments")]
        [Validation(Required=false)]
        public List<DescribeVpnAttachmentsResponseBodyVpnAttachments> VpnAttachments { get; set; }
        public class DescribeVpnAttachmentsResponseBodyVpnAttachments : TeaModel {
            /// <summary>
            /// The type of resource that is associated with the IPsec-VPN connection. The value is set to **CEN**, which indicates that the IPsec-VPN connection is associated with a transit router.
            /// </summary>
            [NameInMap("AttachType")]
            [Validation(Required=false)]
            public string AttachType { get; set; }

            /// <summary>
            /// Indicates whether the IPsec-VPN connection is associated with a transit router that belongs to another Alibaba Cloud account. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("CrossAccountAuthorized")]
            [Validation(Required=false)]
            public bool? CrossAccountAuthorized { get; set; }

            /// <summary>
            /// The description of the IPsec-VPN connection.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the IPsec-VPN connection.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the IPsec-VPN connection.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the transit router with which the IPsec-VPN connection is associated.
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            /// <summary>
            /// The name of the transit router.
            /// </summary>
            [NameInMap("TransitRouterName")]
            [Validation(Required=false)]
            public string TransitRouterName { get; set; }

        }

    }

}
