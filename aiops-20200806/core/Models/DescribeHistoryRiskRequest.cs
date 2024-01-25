// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class DescribeHistoryRiskRequest : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("LastFindTimeEnd")]
        [Validation(Required=false)]
        public string LastFindTimeEnd { get; set; }

        [NameInMap("LastFindTimeStart")]
        [Validation(Required=false)]
        public string LastFindTimeStart { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("Severity")]
        [Validation(Required=false)]
        public int? Severity { get; set; }

    }

}
