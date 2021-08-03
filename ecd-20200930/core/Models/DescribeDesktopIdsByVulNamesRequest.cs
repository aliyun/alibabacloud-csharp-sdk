// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopIdsByVulNamesRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        [NameInMap("Necessity")]
        [Validation(Required=false)]
        public string Necessity { get; set; }

        [NameInMap("VulName")]
        [Validation(Required=false)]
        public List<string> VulName { get; set; }

    }

}
