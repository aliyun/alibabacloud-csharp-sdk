// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateCenInterRegionTrafficQosPolicyResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the QoS policy.
        /// </summary>
        [NameInMap("TrafficQosPolicyId")]
        [Validation(Required=false)]
        public string TrafficQosPolicyId { get; set; }

    }

}
