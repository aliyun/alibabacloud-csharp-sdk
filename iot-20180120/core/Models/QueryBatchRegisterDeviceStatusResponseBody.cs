// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryBatchRegisterDeviceStatusResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryBatchRegisterDeviceStatusResponseBodyData Data { get; set; }
        public class QueryBatchRegisterDeviceStatusResponseBodyData : TeaModel {
            [NameInMap("InvalidList")]
            [Validation(Required=false)]
            public QueryBatchRegisterDeviceStatusResponseBodyDataInvalidList InvalidList { get; set; }
            public class QueryBatchRegisterDeviceStatusResponseBodyDataInvalidList : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public List<string> Name { get; set; }

            }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("ValidList")]
            [Validation(Required=false)]
            public QueryBatchRegisterDeviceStatusResponseBodyDataValidList ValidList { get; set; }
            public class QueryBatchRegisterDeviceStatusResponseBodyDataValidList : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public List<string> Name { get; set; }

            }
        };

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
