// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnReportListRequest : TeaModel {
        /// <summary>
        /// The ID of the operations report that you want to query. If you do not specify an ID, all operations reports are queried.
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public long? ReportId { get; set; }

    }

}
