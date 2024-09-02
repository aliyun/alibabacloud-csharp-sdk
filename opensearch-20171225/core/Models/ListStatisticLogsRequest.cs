// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListStatisticLogsRequest : TeaModel {
        /// <summary>
        /// The fields to query. Format: columns=wordsTopPv.
        /// 
        /// For more information, see [Metrics in statistical reports](https://help.aliyun.com/document_detail/187665.html).
        /// </summary>
        [NameInMap("columns")]
        [Validation(Required=false)]
        public string Columns { get; set; }

        /// <summary>
        /// Specifies whether to use the distinct clause.
        /// </summary>
        [NameInMap("distinct")]
        [Validation(Required=false)]
        public bool? Distinct { get; set; }

        /// <summary>
        /// The page number. Default value: 1.
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10.
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The content of the query clause.
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// The content of the sort clause.
        /// </summary>
        [NameInMap("sortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The default value is the timestamp of 00:00:00 on the current day.
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

        /// <summary>
        /// The end of the time range to query. The default value is the timestamp of 24:00:00 on the current day.
        /// </summary>
        [NameInMap("stopTime")]
        [Validation(Required=false)]
        public int? StopTime { get; set; }

    }

}
