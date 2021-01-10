// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryODPSqlAuditSummaryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryODPSqlAuditSummaryResponseBodyData> Data { get; set; }
        public class QueryODPSqlAuditSummaryResponseBodyData : TeaModel {
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public string Schema { get; set; }

            [NameInMap("MetricsValues")]
            [Validation(Required=false)]
            public List<QueryODPSqlAuditSummaryResponseBodyDataMetricsValues> MetricsValues { get; set; }
            public class QueryODPSqlAuditSummaryResponseBodyDataMetricsValues : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("From")]
                [Validation(Required=false)]
                public long? From { get; set; }

                [NameInMap("To")]
                [Validation(Required=false)]
                public long? To { get; set; }

            }

        }

    }

}
