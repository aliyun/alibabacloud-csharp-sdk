// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class GetDeviceConfigResponse : TeaModel {
        [NameInMap("AudioEnable")]
        [Validation(Required=true)]
        public bool? AudioEnable { get; set; }

        [NameInMap("AudioFormat")]
        [Validation(Required=true)]
        public string AudioFormat { get; set; }

        [NameInMap("BitRate")]
        [Validation(Required=true)]
        public string BitRate { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("DeviceAddress")]
        [Validation(Required=true)]
        public string DeviceAddress { get; set; }

        [NameInMap("DeviceName")]
        [Validation(Required=true)]
        public string DeviceName { get; set; }

        [NameInMap("EncodeFormat")]
        [Validation(Required=true)]
        public string EncodeFormat { get; set; }

        [NameInMap("FrameRate")]
        [Validation(Required=true)]
        public string FrameRate { get; set; }

        [NameInMap("GovLength")]
        [Validation(Required=true)]
        public int? GovLength { get; set; }

        [NameInMap("Latitude")]
        [Validation(Required=true)]
        public string Latitude { get; set; }

        [NameInMap("Longitude")]
        [Validation(Required=true)]
        public string Longitude { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("OSDTimeEnable")]
        [Validation(Required=true)]
        public string OSDTimeEnable { get; set; }

        [NameInMap("OSDTimeType")]
        [Validation(Required=true)]
        public string OSDTimeType { get; set; }

        [NameInMap("OSDTimeX")]
        [Validation(Required=true)]
        public string OSDTimeX { get; set; }

        [NameInMap("OSDTimeY")]
        [Validation(Required=true)]
        public string OSDTimeY { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Resolution")]
        [Validation(Required=true)]
        public string Resolution { get; set; }

        [NameInMap("RetryInterval")]
        [Validation(Required=true)]
        public string RetryInterval { get; set; }

        [NameInMap("DeviceId")]
        [Validation(Required=true)]
        public string DeviceId { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=true)]
        public string UserName { get; set; }

        [NameInMap("PassWord")]
        [Validation(Required=true)]
        public string PassWord { get; set; }

        [NameInMap("Protocol")]
        [Validation(Required=true)]
        public string Protocol { get; set; }

        [NameInMap("ServerId")]
        [Validation(Required=true)]
        public string ServerId { get; set; }

        [NameInMap("ServerPort")]
        [Validation(Required=true)]
        public string ServerPort { get; set; }

        [NameInMap("ServerIp")]
        [Validation(Required=true)]
        public string ServerIp { get; set; }

        [NameInMap("OSDList")]
        [Validation(Required=true)]
        public List<GetDeviceConfigResponseOSDList> OSDList { get; set; }
        public class GetDeviceConfigResponseOSDList : TeaModel {
            [NameInMap("Text")]
            [Validation(Required=true)]
            public string Text { get; set; }

            [NameInMap("LeftTopX")]
            [Validation(Required=true)]
            public string LeftTopX { get; set; }

            [NameInMap("LeftTopY")]
            [Validation(Required=true)]
            public string LeftTopY { get; set; }

        }

    }

}
