// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20230630.Models
{
    public class QueryBatchStatusResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryBatchStatusResponseBodyData Data { get; set; }
        public class QueryBatchStatusResponseBodyData : TeaModel {
            [NameInMap("InvalidDetailList")]
            [Validation(Required=false)]
            public List<QueryBatchStatusResponseBodyDataInvalidDetailList> InvalidDetailList { get; set; }
            public class QueryBatchStatusResponseBodyDataInvalidDetailList : TeaModel {
                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

            }

            [NameInMap("InvalidList")]
            [Validation(Required=false)]
            public List<string> InvalidList { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("ValidList")]
            [Validation(Required=false)]
            public List<string> ValidList { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
