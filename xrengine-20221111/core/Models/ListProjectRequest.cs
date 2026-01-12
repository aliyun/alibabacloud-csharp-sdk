// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20221111.Models
{
    public class ListProjectRequest : TeaModel {
        [NameInMap("BizUsage")]
        [Validation(Required=false)]
        public string BizUsage { get; set; }

        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        [NameInMap("ExcludedBizUsage")]
        [Validation(Required=false)]
        public string ExcludedBizUsage { get; set; }

        [NameInMap("JwtToken")]
        [Validation(Required=false)]
        public string JwtToken { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        [NameInMap("SortField")]
        [Validation(Required=false)]
        public string SortField { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("WithSource")]
        [Validation(Required=false)]
        public bool? WithSource { get; set; }

        [NameInMap("WithUser")]
        [Validation(Required=false)]
        public bool? WithUser { get; set; }

    }

}
