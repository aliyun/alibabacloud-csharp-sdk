// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GetServiceEstimateCostResponseBody : TeaModel {
        /// <summary>
        /// Estimated commodity cost.
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public Dictionary<string, CommodityValue> Commodity { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Estimated resource cost.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public Dictionary<string, object> Resources { get; set; }

    }

}
