// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateStorageGatewayRequest : TeaModel {
        /// <summary>
        /// The array of orders.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrderDetails")]
        [Validation(Required=false)]
        public List<CreateStorageGatewayRequestOrderDetails> OrderDetails { get; set; }
        public class CreateStorageGatewayRequestOrderDetails : TeaModel {
            /// <summary>
            /// The description of the gateway. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the node.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// The name of the gateway. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with `http://` or `https://`. The name can contain letters, digits, colons (.), underscores (_), and hyphens (-).
            /// </summary>
            [NameInMap("GatewayName")]
            [Validation(Required=false)]
            public string GatewayName { get; set; }

            /// <summary>
            /// The type of the gateway. Set this parameter to **1**. **1** indicates iSCSI.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("GatewayType")]
            [Validation(Required=false)]
            public string GatewayType { get; set; }

            /// <summary>
            /// The ID of the VPC.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
