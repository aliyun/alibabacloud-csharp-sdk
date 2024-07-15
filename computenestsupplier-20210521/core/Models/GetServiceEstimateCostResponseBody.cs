// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetServiceEstimateCostResponseBody : TeaModel {
        /// <summary>
        /// The subscription duration information about the purchase order of Alibaba Cloud Marketplace.
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public Dictionary<string, object> Commodity { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of resources.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public Dictionary<string, object> Resources { get; set; }

    }

}
