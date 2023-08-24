// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class TransformInstanceChargeTypeResponseBody : TeaModel {
        /// <summary>
        /// The new billing method. Valid values:
        /// 
        /// *   **PrePaid**: subscription. If you set this parameter to PrePaid, you must also set the **Period** parameter.
        /// *   **PostPaid**: pay-as-you-go.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **TransformInstanceChargeType**.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
