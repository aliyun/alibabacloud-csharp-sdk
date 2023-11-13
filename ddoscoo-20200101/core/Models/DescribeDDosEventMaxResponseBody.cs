// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosEventMaxResponseBody : TeaModel {
        /// <summary>
        /// The peak of connection flood attacks. Unit: connections per seconds (CPS).
        /// </summary>
        [NameInMap("Cps")]
        [Validation(Required=false)]
        public long? Cps { get; set; }

        /// <summary>
        /// The peak of volumetric attacks. Unit: Mbit/s.
        /// </summary>
        [NameInMap("Mbps")]
        [Validation(Required=false)]
        public long? Mbps { get; set; }

        /// <summary>
        /// The peak of resource exhaustion attacks. Unit: queries per second (QPS).
        /// </summary>
        [NameInMap("Qps")]
        [Validation(Required=false)]
        public long? Qps { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
