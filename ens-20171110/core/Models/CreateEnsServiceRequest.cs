// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateEnsServiceRequest : TeaModel {
        /// <summary>
        /// The ID of the resource that you want to obtain. You can specify only one ID in a request.
        /// </summary>
        [NameInMap("EnsServiceId")]
        [Validation(Required=false)]
        public string EnsServiceId { get; set; }

        /// <summary>
        /// The operation to perform after you preview the created edge service. Valid values:
        /// 
        /// *   **Buy**: create
        /// *   **Upgrade**: change
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

    }

}
