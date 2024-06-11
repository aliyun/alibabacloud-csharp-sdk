// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulListPageRequest : TeaModel {
        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The Common Vulnerabilities and Exposures (CVE) ID of the vulnerability.
        /// </summary>
        [NameInMap("CveId")]
        [Validation(Required=false)]
        public string CveId { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RaspDefend")]
        [Validation(Required=false)]
        public int? RaspDefend { get; set; }

        /// <summary>
        /// The name of the vulnerability.
        /// </summary>
        [NameInMap("VulNameLike")]
        [Validation(Required=false)]
        public string VulNameLike { get; set; }

        [NameInMap("VulType")]
        [Validation(Required=false)]
        public string VulType { get; set; }

    }

}
