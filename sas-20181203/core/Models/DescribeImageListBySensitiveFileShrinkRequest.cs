// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageListBySensitiveFileShrinkRequest : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("ImageDigest")]
        [Validation(Required=false)]
        public string ImageDigest { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RepoInstanceId")]
        [Validation(Required=false)]
        public string RepoInstanceId { get; set; }

        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        [NameInMap("RepoNamespace")]
        [Validation(Required=false)]
        public string RepoNamespace { get; set; }

        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public string ScanRangeShrink { get; set; }

        [NameInMap("SensitiveFileKey")]
        [Validation(Required=false)]
        public string SensitiveFileKey { get; set; }

    }

}
