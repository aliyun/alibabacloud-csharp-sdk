// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageSensitiveFileListRequest : TeaModel {
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        [NameInMap("CriteriaType")]
        [Validation(Required=false)]
        public string CriteriaType { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("ImageUuid")]
        [Validation(Required=false)]
        public string ImageUuid { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public List<string> ScanRange { get; set; }

    }

}
