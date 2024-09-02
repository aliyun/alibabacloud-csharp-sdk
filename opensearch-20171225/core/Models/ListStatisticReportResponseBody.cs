// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListStatisticReportResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The queried reports. Valid values:
        /// 
        /// For more information about the metrics in data quality reports, see the Upload behavioral data section of [Data collection 2.0](https://help.aliyun.com/document_detail/131547.html).
        /// 
        /// For more information about the metrics in application and A/B test reports, see the Core metrics section of [Metrics of statistical reports](https://help.aliyun.com/document_detail/187654.html).
        /// 
        /// For more information about the metrics in query analysis reports, see the Query analysis metrics section of [Metrics of statistical reports](https://help.aliyun.com/document_detail/187654.html).
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Result { get; set; }

        /// <summary>
        /// The total number of the queried reports.
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
