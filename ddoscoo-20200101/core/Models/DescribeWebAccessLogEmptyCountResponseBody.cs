// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebAccessLogEmptyCountResponseBody : TeaModel {
        /// <summary>
        /// The remaining quota that you can clear the Logstore.
        /// </summary>
        [NameInMap("AvailableCount")]
        [Validation(Required=false)]
        public int? AvailableCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
