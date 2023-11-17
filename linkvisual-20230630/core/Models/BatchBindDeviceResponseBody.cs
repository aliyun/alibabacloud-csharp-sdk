// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20230630.Models
{
    public class BatchBindDeviceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchBindDeviceResponseBodyData Data { get; set; }
        public class BatchBindDeviceResponseBodyData : TeaModel {
            [NameInMap("BindDeviceList")]
            [Validation(Required=false)]
            public List<BatchBindDeviceResponseBodyDataBindDeviceList> BindDeviceList { get; set; }
            public class BatchBindDeviceResponseBodyDataBindDeviceList : TeaModel {
                [NameInMap("BindResultCode")]
                [Validation(Required=false)]
                public int? BindResultCode { get; set; }

                [NameInMap("BindResultMessage")]
                [Validation(Required=false)]
                public string BindResultMessage { get; set; }

                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("IotId")]
                [Validation(Required=false)]
                public string IotId { get; set; }

                [NameInMap("ProductKey")]
                [Validation(Required=false)]
                public string ProductKey { get; set; }

            }

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
