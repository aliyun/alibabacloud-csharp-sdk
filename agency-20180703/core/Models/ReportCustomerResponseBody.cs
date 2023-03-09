// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class ReportCustomerResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ReportCustomerResponseBodyData Data { get; set; }
        public class ReportCustomerResponseBodyData : TeaModel {
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ReportCustomerResponseBodyDataResult> Result { get; set; }
            public class ReportCustomerResponseBodyDataResult : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Data")]
                [Validation(Required=false)]
                public bool? Data { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
