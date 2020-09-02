// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreatePhysicalConnectionSetupOrderResponse : TeaModel {
        /// <summary>
        /// description: ; 
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        /// <summary>
        /// description: The ID of the order.; 
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=true)]
        public string OrderId { get; set; }

        [NameInMap("PhysicalConnectionId")]
        [Validation(Required=true)]
        public string PhysicalConnectionId { get; set; }

    }

}
