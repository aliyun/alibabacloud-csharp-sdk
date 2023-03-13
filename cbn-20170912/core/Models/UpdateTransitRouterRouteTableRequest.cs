// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class UpdateTransitRouterRouteTableRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among all requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** for each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run. Default values:
        /// 
        /// *   **false** (default): performs a dry run and sends the request.
        /// *   **true**: performs a dry run. The system checks the required parameters and the request syntax. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RouteTableOptions")]
        [Validation(Required=false)]
        public UpdateTransitRouterRouteTableRequestRouteTableOptions RouteTableOptions { get; set; }
        public class UpdateTransitRouterRouteTableRequestRouteTableOptions : TeaModel {
            [NameInMap("MultiRegionECMP")]
            [Validation(Required=false)]
            public string MultiRegionECMP { get; set; }

        }

        /// <summary>
        /// The description of the route table.
        /// 
        /// The description must be 2 to 256 characters in length, and can contain letters, digits, and the following special characters: , . ; / @ \_ -. You can also leave the description empty.
        /// </summary>
        [NameInMap("TransitRouterRouteTableDescription")]
        [Validation(Required=false)]
        public string TransitRouterRouteTableDescription { get; set; }

        /// <summary>
        /// The ID of the route table of the Enterprise Edition transit router.
        /// </summary>
        [NameInMap("TransitRouterRouteTableId")]
        [Validation(Required=false)]
        public string TransitRouterRouteTableId { get; set; }

        /// <summary>
        /// The name of the route table.
        /// 
        /// The name must be 1 to 128 characters in length, and can contain letters, digits, and the following special characters: , . ; / @ \_ -. You can also leave the name empty.
        /// </summary>
        [NameInMap("TransitRouterRouteTableName")]
        [Validation(Required=false)]
        public string TransitRouterRouteTableName { get; set; }

    }

}
