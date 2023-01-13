// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterCidrAllocationRequest : TeaModel {
        /// <summary>
        /// The ID of the network instance connection.
        /// </summary>
        [NameInMap("AttachmentId")]
        [Validation(Required=false)]
        public string AttachmentId { get; set; }

        /// <summary>
        /// The name of the network instance connection.
        /// </summary>
        [NameInMap("AttachmentName")]
        [Validation(Required=false)]
        public string AttachmentName { get; set; }

        /// <summary>
        /// The CIDR block of the transit router.
        /// </summary>
        [NameInMap("Cidr")]
        [Validation(Required=false)]
        public string Cidr { get; set; }

        /// <summary>
        /// The CIDR block that has been allocated to network instances.
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. ClientToken can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, ClientToken is set to the value of RequestId. The value of RequestId for each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The CIDR block that is for exclusive use.
        /// 
        /// Set the value to **VPN**, which specifies the CIDR block that is reserved for VPN connections.
        /// </summary>
        [NameInMap("DedicatedOwnerId")]
        [Validation(Required=false)]
        public string DedicatedOwnerId { get; set; }

        /// <summary>
        /// Specifies whether only to precheck the request. Valid values:
        /// 
        /// *   **true**: prechecks the request but does not query how IP addresses within the CIDR block of a transit router are allocated. The system checks the required parameters, the request format, and the service limits. If the request fails to pass the precheck, an error message is returned. If the request passes the precheck, the `DryRunOperation` error code is returned.
        /// *   **false** (default): sends the request. After the request passes the precheck, allocated IP addresses are queried.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
        /// 
        /// *   If you do not set **MaxResults**, it indicates that you do not need to query results in batches. The value of **MaxResults** indicates the total number of entries.
        /// 
        /// *   If a value is specified for **MaxResults**, it indicates that you need to query results in batches. Valid values: **1** to **100**. We recommend that you set **MaxResults** to **20**.
        /// 
        ///     The value of **MaxResults** in the response indicates the number of entries in the current batch.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the query. Valid values:
        /// 
        /// *   If this is your first query or no subsequent query is to be sent, ignore this parameter.
        /// *   If a subsequent query is to be sent, set the value to the value of **NextToken** that was returned from the last call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the transit router is deployed.
        /// 
        /// You can call the [DescribeChildInstanceRegions](~~132080~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the CIDR block.
        /// 
        /// You can call [ListTransitRouterCidr](~~462772~~) to query the ID of a CIDR block.
        /// </summary>
        [NameInMap("TransitRouterCidrId")]
        [Validation(Required=false)]
        public string TransitRouterCidrId { get; set; }

        /// <summary>
        /// The ID of the transit router.
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

    }

}
