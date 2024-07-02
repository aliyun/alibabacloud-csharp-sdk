// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulMetaCountStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The number of application vulnerabilities.
        /// </summary>
        [NameInMap("AppCount")]
        [Validation(Required=false)]
        public int? AppCount { get; set; }

        /// <summary>
        /// The number of Linux software vulnerabilities.
        /// </summary>
        [NameInMap("CveCount")]
        [Validation(Required=false)]
        public int? CveCount { get; set; }

        /// <summary>
        /// The number of vulnerabilities that can be defended by the application protection feature.
        /// </summary>
        [NameInMap("RaspDefendCount")]
        [Validation(Required=false)]
        public int? RaspDefendCount { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of Windows system vulnerabilities.
        /// </summary>
        [NameInMap("SysCount")]
        [Validation(Required=false)]
        public int? SysCount { get; set; }

    }

}
