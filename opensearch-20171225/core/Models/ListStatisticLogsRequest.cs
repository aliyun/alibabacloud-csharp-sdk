// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListStatisticLogsRequest : TeaModel {
        [NameInMap("columns")]
        [Validation(Required=false)]
        public string Columns { get; set; }

        [NameInMap("distinct")]
        [Validation(Required=false)]
        public bool? Distinct { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("sortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

        [NameInMap("stopTime")]
        [Validation(Required=false)]
        public int? StopTime { get; set; }

    }

}
