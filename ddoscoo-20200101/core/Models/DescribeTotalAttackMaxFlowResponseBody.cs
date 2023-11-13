// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeTotalAttackMaxFlowResponseBody : TeaModel {
        /// <summary>
        /// The peak bandwidth of attack traffic. Unit: bit/s.
        /// </summary>
        [NameInMap("Bps")]
        [Validation(Required=false)]
        public long? Bps { get; set; }

        /// <summary>
        /// The peak packet rate of attack traffic . Unit: packets per second (pps).
        /// </summary>
        [NameInMap("Pps")]
        [Validation(Required=false)]
        public long? Pps { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
