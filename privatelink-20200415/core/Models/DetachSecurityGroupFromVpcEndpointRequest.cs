// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class DetachSecurityGroupFromVpcEndpointRequest : TeaModel {
        /// <summary>
        /// Specifies whether to check the request without performing the operation. Valid values:
        /// 
        /// *   **true**: sends a request for check purpose only. If you select this option, the endpoint is still associated with the security group after the request passes the check. The system checks whether your AccessKey pair is valid, whether RAM users are granted required permissions, and whether the required parameters are set. If the request fails to pass the check, the corresponding error message is returned. If the request passes the check, the `DryRunOperation` error code is returned.
        /// *   **false** (default): sends a common request. If the request passes the check, the 2xx HTTP status code is returned, and the operation is performed.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the endpoint that you want to disassociate from the security group.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The ID of the security group from which you want to disassociate the endpoint.
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// *   **DetachSecurityGroupFromVpcEndpoint** is an asynchronous operation. After you send a request, the system returns a request ID. However, the operation is still being performed in the system background. You can call the [ListVpcEndpoints](~~183558#doc-api-Privatelink-ListVpcEndpoints~~) operation to query whether the endpoint is disassociated from the security group.
        /// 
        ///     *   If the endpoint is in the **Pending** state, it indicates that the endpoint is being disassociated from the security group.
        ///     *   If the endpoint is in the **Active** state, it indicates that the endpoint is disassociated from the security group.
        /// 
        /// *   You cannot use the **DetachSecurityGroupFromVpcEndpoint** operation to disassociate an endpoint from multiple security groups at the same time.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the region to which the endpoint belongs. You can call the [DescribeRegions](~~120468#doc-api-Privatelink-DescribeRegions~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

    }

}
