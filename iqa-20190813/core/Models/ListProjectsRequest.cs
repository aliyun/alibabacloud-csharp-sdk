// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iqa20190813.Models
{
    public class ListProjectsRequest : TeaModel {
        [NameInMap("FilterParam")]
        [Validation(Required=false)]
        public string FilterParam { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProjectType")]
        [Validation(Required=false)]
        public string ProjectType { get; set; }

    }

}
