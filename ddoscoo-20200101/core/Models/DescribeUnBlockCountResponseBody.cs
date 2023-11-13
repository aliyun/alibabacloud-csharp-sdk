// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeUnBlockCountResponseBody : TeaModel {
        /// <summary>
        /// The remaining quota that you can use the Diversion from Origin Server policy.
        /// </summary>
        [NameInMap("RemainCount")]
        [Validation(Required=false)]
        public int? RemainCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total quota that you can use the Diversion from Origin Server policy.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
