// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeVulOverviewResponseBody : TeaModel {
        /// <summary>
        /// The number of high-risk vulnerabilities.
        /// </summary>
        [NameInMap("AsapCount")]
        [Validation(Required=false)]
        public int? AsapCount { get; set; }

        /// <summary>
        /// The number of medium-risk vulnerabilities.
        /// </summary>
        [NameInMap("LaterCount")]
        [Validation(Required=false)]
        public int? LaterCount { get; set; }

        /// <summary>
        /// The number of low-risk vulnerabilities.
        /// </summary>
        [NameInMap("NntfCount")]
        [Validation(Required=false)]
        public int? NntfCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
