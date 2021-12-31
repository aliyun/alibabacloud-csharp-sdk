// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListStatisticReportRequest : TeaModel {
        [NameInMap("columns")]
        [Validation(Required=false)]
        public string Columns { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

    }

}
