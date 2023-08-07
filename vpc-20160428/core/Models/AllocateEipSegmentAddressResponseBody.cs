// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AllocateEipSegmentAddressResponseBody : TeaModel {
        /// <summary>
        /// The ID of the contiguous EIP group.
        /// </summary>
        [NameInMap("EipSegmentInstanceId")]
        [Validation(Required=false)]
        public string EipSegmentInstanceId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
