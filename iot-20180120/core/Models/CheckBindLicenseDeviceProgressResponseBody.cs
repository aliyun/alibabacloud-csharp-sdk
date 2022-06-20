// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CheckBindLicenseDeviceProgressResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CheckBindLicenseDeviceProgressResponseBodyData Data { get; set; }
        public class CheckBindLicenseDeviceProgressResponseBodyData : TeaModel {
            [NameInMap("FailSum")]
            [Validation(Required=false)]
            public long? FailSum { get; set; }
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }
            [NameInMap("ResultCsvFile")]
            [Validation(Required=false)]
            public string ResultCsvFile { get; set; }
            [NameInMap("SuccessSum")]
            [Validation(Required=false)]
            public long? SuccessSum { get; set; }
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
