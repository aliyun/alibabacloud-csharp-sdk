// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20190430.Models
{
    public class ImportDevicesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImportDevicesResponseBodyData Data { get; set; }
        public class ImportDevicesResponseBodyData : TeaModel {
            [NameInMap("Failure")]
            [Validation(Required=false)]
            public List<ImportDevicesResponseBodyDataFailure> Failure { get; set; }
            public class ImportDevicesResponseBodyDataFailure : TeaModel {
                public string DeviceCode { get; set; }
                public string DeviceId { get; set; }
            }
            [NameInMap("Success")]
            [Validation(Required=false)]
            public List<ImportDevicesResponseBodyDataSuccess> Success { get; set; }
            public class ImportDevicesResponseBodyDataSuccess : TeaModel {
                public string DeviceCode { get; set; }
                public string DeviceId { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
