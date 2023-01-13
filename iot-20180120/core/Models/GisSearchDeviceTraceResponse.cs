// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GisSearchDeviceTraceResponse : TeaModel {
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
        public GisSearchDeviceTraceResponseData Data { get; set; }
        public class GisSearchDeviceTraceResponseData : TeaModel {
            [NameInMap("DeviceName")]
            [Validation(Required=true)]
            public string DeviceName { get; set; }

            [NameInMap("ProductKey")]
            [Validation(Required=true)]
            public string ProductKey { get; set; }

            [NameInMap("Points")]
            [Validation(Required=true)]
            public List<GisSearchDeviceTraceResponseDataPoints> Points { get; set; }
            public class GisSearchDeviceTraceResponseDataPoints : TeaModel {
                [NameInMap("LocateTime")]
                [Validation(Required=true)]
                public long? LocateTime { get; set; }

                [NameInMap("Location")]
                [Validation(Required=true)]
                public string Location { get; set; }

            }

        }

    }

}
