// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetAccountingReportResponseBody : TeaModel {
        [NameInMap("TotalCoreTime")]
        [Validation(Required=false)]
        public int? TotalCoreTime { get; set; }

        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public string Metrics { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAccountingReportResponseBodyData Data { get; set; }
        public class GetAccountingReportResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<string> Data { get; set; }
        };

    }

}
