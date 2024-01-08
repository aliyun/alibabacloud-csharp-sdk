// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class BatchQueryVisionDeviceInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchQueryVisionDeviceInfoResponseBodyData Data { get; set; }
        public class BatchQueryVisionDeviceInfoResponseBodyData : TeaModel {
            [NameInMap("DeviceInfoList")]
            [Validation(Required=false)]
            public List<BatchQueryVisionDeviceInfoResponseBodyDataDeviceInfoList> DeviceInfoList { get; set; }
            public class BatchQueryVisionDeviceInfoResponseBodyDataDeviceInfoList : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DeviceType")]
                [Validation(Required=false)]
                public int? DeviceType { get; set; }

                [NameInMap("GbDeviceInfo")]
                [Validation(Required=false)]
                public BatchQueryVisionDeviceInfoResponseBodyDataDeviceInfoListGbDeviceInfo GbDeviceInfo { get; set; }
                public class BatchQueryVisionDeviceInfoResponseBodyDataDeviceInfoListGbDeviceInfo : TeaModel {
                    [NameInMap("DeviceProtocol")]
                    [Validation(Required=false)]
                    public int? DeviceProtocol { get; set; }

                    [NameInMap("GbId")]
                    [Validation(Required=false)]
                    public string GbId { get; set; }

                    [NameInMap("NetProtocol")]
                    [Validation(Required=false)]
                    public int? NetProtocol { get; set; }

                    [NameInMap("NickName")]
                    [Validation(Required=false)]
                    public string NickName { get; set; }

                    [NameInMap("Password")]
                    [Validation(Required=false)]
                    public string Password { get; set; }

                    [NameInMap("SubProductKey")]
                    [Validation(Required=false)]
                    public string SubProductKey { get; set; }

                }

                [NameInMap("IotId")]
                [Validation(Required=false)]
                public string IotId { get; set; }

                [NameInMap("RtmpDeviceInfo")]
                [Validation(Required=false)]
                public BatchQueryVisionDeviceInfoResponseBodyDataDeviceInfoListRtmpDeviceInfo RtmpDeviceInfo { get; set; }
                public class BatchQueryVisionDeviceInfoResponseBodyDataDeviceInfoListRtmpDeviceInfo : TeaModel {
                    [NameInMap("PullAuthKey")]
                    [Validation(Required=false)]
                    public string PullAuthKey { get; set; }

                    [NameInMap("PullKeyExpireTime")]
                    [Validation(Required=false)]
                    public int? PullKeyExpireTime { get; set; }

                    [NameInMap("PushAuthKey")]
                    [Validation(Required=false)]
                    public string PushAuthKey { get; set; }

                    [NameInMap("PushKeyExpireTime")]
                    [Validation(Required=false)]
                    public int? PushKeyExpireTime { get; set; }

                    [NameInMap("PushUrlSample")]
                    [Validation(Required=false)]
                    public string PushUrlSample { get; set; }

                    [NameInMap("StreamName")]
                    [Validation(Required=false)]
                    public string StreamName { get; set; }

                    [NameInMap("StreamStatus")]
                    [Validation(Required=false)]
                    public int? StreamStatus { get; set; }

                }

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
