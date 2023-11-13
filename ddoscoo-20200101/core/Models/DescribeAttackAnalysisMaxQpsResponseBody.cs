// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeAttackAnalysisMaxQpsResponseBody : TeaModel {
        /// <summary>
        /// The peak queries per second (QPS) of DDoS attacks. Units: QPS.
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
