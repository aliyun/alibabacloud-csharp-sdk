// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetVulStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of vulnerabilities that have the high priority.
        /// </summary>
        [NameInMap("VulAsapSum")]
        [Validation(Required=false)]
        public int? VulAsapSum { get; set; }

        /// <summary>
        /// The number of vulnerabilities that have the medium priority.
        /// </summary>
        [NameInMap("VulLaterSum")]
        [Validation(Required=false)]
        public int? VulLaterSum { get; set; }

        /// <summary>
        /// The number of vulnerabilities that have the low priority.
        /// </summary>
        [NameInMap("VulNntfSum")]
        [Validation(Required=false)]
        public int? VulNntfSum { get; set; }

    }

}
