// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateCenBandwidthPackageResponseBody : TeaModel {
        /// <summary>
        /// The ID of the bandwidth plan.
        /// </summary>
        [NameInMap("CenBandwidthPackageId")]
        [Validation(Required=false)]
        public string CenBandwidthPackageId { get; set; }

        /// <summary>
        /// The ID of the order for the bandwidth plan.
        /// </summary>
        [NameInMap("CenBandwidthPackageOrderId")]
        [Validation(Required=false)]
        public string CenBandwidthPackageOrderId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
