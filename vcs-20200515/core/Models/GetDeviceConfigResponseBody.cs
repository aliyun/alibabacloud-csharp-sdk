// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class GetDeviceConfigResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RetryInterval")]
        [Validation(Required=false)]
        public string RetryInterval { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("AudioEnable")]
        [Validation(Required=false)]
        public string AudioEnable { get; set; }

        [NameInMap("AudioFormat")]
        [Validation(Required=false)]
        public string AudioFormat { get; set; }

        [NameInMap("BitRate")]
        [Validation(Required=false)]
        public string BitRate { get; set; }

        [NameInMap("DeviceAddress")]
        [Validation(Required=false)]
        public string DeviceAddress { get; set; }

        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("EncodeFormat")]
        [Validation(Required=false)]
        public string EncodeFormat { get; set; }

        [NameInMap("FrameRate")]
        [Validation(Required=false)]
        public string FrameRate { get; set; }

        [NameInMap("GovLength")]
        [Validation(Required=false)]
        public long GovLength { get; set; }

        [NameInMap("Latitude")]
        [Validation(Required=false)]
        public string Latitude { get; set; }

        [NameInMap("Longitude")]
        [Validation(Required=false)]
        public string Longitude { get; set; }

        [NameInMap("OSDList")]
        [Validation(Required=false)]
        public List<GetDeviceConfigResponseBodyOSDList> OSDList { get; set; }
        public class GetDeviceConfigResponseBodyOSDList : TeaModel {
            [NameInMap("LeftTopX")]
            [Validation(Required=false)]
            public string LeftTopX { get; set; }

            [NameInMap("LeftTopY")]
            [Validation(Required=false)]
            public string LeftTopY { get; set; }

            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        [NameInMap("OSDTimeEnable")]
        [Validation(Required=false)]
        public string OSDTimeEnable { get; set; }

        [NameInMap("OSDTimeType")]
        [Validation(Required=false)]
        public string OSDTimeType { get; set; }

        [NameInMap("OSDTimeX")]
        [Validation(Required=false)]
        public string OSDTimeX { get; set; }

        [NameInMap("OSDTimeY")]
        [Validation(Required=false)]
        public string OSDTimeY { get; set; }

        [NameInMap("Resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("PassWord")]
        [Validation(Required=false)]
        public string PassWord { get; set; }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("ServerId")]
        [Validation(Required=false)]
        public string ServerId { get; set; }

        [NameInMap("ServerPort")]
        [Validation(Required=false)]
        public string ServerPort { get; set; }

        [NameInMap("ServerIp")]
        [Validation(Required=false)]
        public string ServerIp { get; set; }

        [NameInMap("ChannelList")]
        [Validation(Required=false)]
        public List<GetDeviceConfigResponseBodyChannelList> ChannelList { get; set; }
        public class GetDeviceConfigResponseBodyChannelList : TeaModel {
            [NameInMap("ChannelGbId")]
            [Validation(Required=false)]
            public string ChannelGbId { get; set; }

            [NameInMap("MondayCaptureStrategy")]
            [Validation(Required=false)]
            public string MondayCaptureStrategy { get; set; }

            [NameInMap("TuesdayCaptureStrategy")]
            [Validation(Required=false)]
            public string TuesdayCaptureStrategy { get; set; }

            [NameInMap("WednesdayCaptureStrategy")]
            [Validation(Required=false)]
            public string WednesdayCaptureStrategy { get; set; }

            [NameInMap("ThursdayCaptureStrategy")]
            [Validation(Required=false)]
            public string ThursdayCaptureStrategy { get; set; }

            [NameInMap("FridayCaptureStrategy")]
            [Validation(Required=false)]
            public string FridayCaptureStrategy { get; set; }

            [NameInMap("SaturdayCaptureStrategy")]
            [Validation(Required=false)]
            public string SaturdayCaptureStrategy { get; set; }

            [NameInMap("SundayCaptureStrategy")]
            [Validation(Required=false)]
            public string SundayCaptureStrategy { get; set; }

        }

    }

}
