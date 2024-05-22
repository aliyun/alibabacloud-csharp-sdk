// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteNatGatewayRequest : TeaModel {
        /// <summary>
        /// The ID of the NAT gateway that you want to delete.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

    }

}
