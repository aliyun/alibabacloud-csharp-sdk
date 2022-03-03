// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetSpeechDeviceDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSpeechDeviceDetailResponseBodyData Data { get; set; }
        public class GetSpeechDeviceDetailResponseBodyData : TeaModel {
            [NameInMap("AvailableSpace")]
            [Validation(Required=false)]
            public float? AvailableSpace { get; set; }
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }
            [NameInMap("IotId")]
            [Validation(Required=false)]
            public string IotId { get; set; }
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }
            [NameInMap("SpeechListUpdateTime")]
            [Validation(Required=false)]
            public long? SpeechListUpdateTime { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("TotalSpace")]
            [Validation(Required=false)]
            public float? TotalSpace { get; set; }
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
