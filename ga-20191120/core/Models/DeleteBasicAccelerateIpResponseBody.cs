// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DeleteBasicAccelerateIpResponseBody : TeaModel {
        /// <summary>
        /// The ID of the accelerated IP address that is deleted.
        /// </summary>
        [NameInMap("AccelerateIpId")]
        [Validation(Required=false)]
        public string AccelerateIpId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
