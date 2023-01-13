// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryBatchRegisterDeviceStatusResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryBatchRegisterDeviceStatusResponseData Data { get; set; }
        public class QueryBatchRegisterDeviceStatusResponseData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }

            [NameInMap("InvalidList")]
            [Validation(Required=true)]
            public QueryBatchRegisterDeviceStatusResponseDataInvalidList InvalidList { get; set; }
            public class QueryBatchRegisterDeviceStatusResponseDataInvalidList : TeaModel {
                /// <summary>
                /// Name
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=true)]
                public List<string> Name { get; set; }

            }

            [NameInMap("ValidList")]
            [Validation(Required=true)]
            public QueryBatchRegisterDeviceStatusResponseDataValidList ValidList { get; set; }
            public class QueryBatchRegisterDeviceStatusResponseDataValidList : TeaModel {
                /// <summary>
                /// Name
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=true)]
                public List<string> Name { get; set; }

            }

        }

    }

}
