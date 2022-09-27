// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDiagnoseReportIdsResponseBody : TeaModel {
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListDiagnoseReportIdsResponseBodyHeaders Headers { get; set; }
        public class ListDiagnoseReportIdsResponseBodyHeaders : TeaModel {
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<string> Result { get; set; }

    }

}
