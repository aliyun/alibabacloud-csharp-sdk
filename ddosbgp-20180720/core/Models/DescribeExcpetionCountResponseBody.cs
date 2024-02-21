// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeExcpetionCountResponseBody : TeaModel {
        /// <summary>
        /// The number of assets that are in an abnormal state.
        /// </summary>
        [NameInMap("ExceptionIpCount")]
        [Validation(Required=false)]
        public int? ExceptionIpCount { get; set; }

        /// <summary>
        /// The number of Anti-DDoS Origin instances that are about to expire.
        /// </summary>
        [NameInMap("ExpireTimeCount")]
        [Validation(Required=false)]
        public int? ExpireTimeCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
