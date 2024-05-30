// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeFixUsedCountResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of vulnerabilities that are fixed by the vulnerability fixing feature.
        /// </summary>
        [NameInMap("UsedCount")]
        [Validation(Required=false)]
        public int? UsedCount { get; set; }

        /// <summary>
        /// The number of vulnerabilities that are fixed by the vulnerability fixing feature in China.
        /// </summary>
        [NameInMap("UsedCountCn")]
        [Validation(Required=false)]
        public int? UsedCountCn { get; set; }

        /// <summary>
        /// The number of vulnerabilities that are fixed by the vulnerability fixing feature outside China.
        /// </summary>
        [NameInMap("UsedCountSg")]
        [Validation(Required=false)]
        public int? UsedCountSg { get; set; }

    }

}
