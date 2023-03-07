// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetAccountingReportResponseBody : TeaModel {
        /// <summary>
        /// The list serialized in the JSON format. The list contains multiple records.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAccountingReportResponseBodyData Data { get; set; }
        public class GetAccountingReportResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<string> Data { get; set; }

        }

        /// <summary>
        /// The list serialized in the JSON format. The list contains the column names of each record in the Data.
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public string Metrics { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of CPU cores in the queried cluster.
        /// </summary>
        [NameInMap("TotalCoreTime")]
        [Validation(Required=false)]
        public int? TotalCoreTime { get; set; }

        /// <summary>
        /// The total number of entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
