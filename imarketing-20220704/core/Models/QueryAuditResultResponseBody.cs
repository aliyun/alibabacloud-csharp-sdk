// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class QueryAuditResultResponseBody : TeaModel {
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<QueryAuditResultResponseBodyRecords> Records { get; set; }
        public class QueryAuditResultResponseBodyRecords : TeaModel {
            [NameInMap("Crid")]
            [Validation(Required=false)]
            public string Crid { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public int? State { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
