// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class CheckAndDoVoipCallForHotelResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CheckAndDoVoipCallForHotelResponseBodyResult Result { get; set; }
        public class CheckAndDoVoipCallForHotelResponseBodyResult : TeaModel {
            [NameInMap("DeviceTargets")]
            [Validation(Required=false)]
            public CheckAndDoVoipCallForHotelResponseBodyResultDeviceTargets DeviceTargets { get; set; }
            public class CheckAndDoVoipCallForHotelResponseBodyResultDeviceTargets : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<CheckAndDoVoipCallForHotelResponseBodyResultDeviceTargetsData> Data { get; set; }
                public class CheckAndDoVoipCallForHotelResponseBodyResultDeviceTargetsData : TeaModel {
                    [NameInMap("DeviceIcon")]
                    [Validation(Required=false)]
                    public string DeviceIcon { get; set; }

                    [NameInMap("DeviceName")]
                    [Validation(Required=false)]
                    public string DeviceName { get; set; }

                    [NameInMap("DeviceType")]
                    [Validation(Required=false)]
                    public string DeviceType { get; set; }

                    [NameInMap("Online")]
                    [Validation(Required=false)]
                    public bool? Online { get; set; }

                    [NameInMap("Uuid")]
                    [Validation(Required=false)]
                    public string Uuid { get; set; }

                }

                [NameInMap("Msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

            }

            [NameInMap("IsStartCall")]
            [Validation(Required=false)]
            public bool? IsStartCall { get; set; }

            [NameInMap("Passed")]
            [Validation(Required=false)]
            public bool? Passed { get; set; }

            [NameInMap("StartCallResult")]
            [Validation(Required=false)]
            public CheckAndDoVoipCallForHotelResponseBodyResultStartCallResult StartCallResult { get; set; }
            public class CheckAndDoVoipCallForHotelResponseBodyResultStartCallResult : TeaModel {
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("RetCode")]
                [Validation(Required=false)]
                public int? RetCode { get; set; }

                [NameInMap("RetValue")]
                [Validation(Required=false)]
                public string RetValue { get; set; }

                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

                [NameInMap("TraceId")]
                [Validation(Required=false)]
                public string TraceId { get; set; }

            }

        }

    }

}
