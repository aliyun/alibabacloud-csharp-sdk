// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeVulListRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        [NameInMap("Necessity")]
        [Validation(Required=false)]
        public string Necessity { get; set; }

        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
