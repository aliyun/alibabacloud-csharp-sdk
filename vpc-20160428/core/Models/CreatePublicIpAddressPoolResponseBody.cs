// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreatePublicIpAddressPoolResponseBody : TeaModel {
        /// <summary>
        /// The ID of the IP address pool.
        /// </summary>
        [NameInMap("PulbicIpAddressPoolId")]
        [Validation(Required=false)]
        public string PulbicIpAddressPoolId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the IP address pool belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
