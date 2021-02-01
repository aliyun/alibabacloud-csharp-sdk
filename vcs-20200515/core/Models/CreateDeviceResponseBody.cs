// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class CreateDeviceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<CreateDeviceResponseBodyData> Data { get; set; }
        public class CreateDeviceResponseBodyData : TeaModel {
            [NameInMap("SipIp")]
            [Validation(Required=false)]
            public string SipIp { get; set; }

            [NameInMap("SipReaml")]
            [Validation(Required=false)]
            public string SipReaml { get; set; }

            [NameInMap("SipDeviceGbId")]
            [Validation(Required=false)]
            public string SipDeviceGbId { get; set; }

            [NameInMap("SipPassword")]
            [Validation(Required=false)]
            public string SipPassword { get; set; }

            [NameInMap("SipPort")]
            [Validation(Required=false)]
            public string SipPort { get; set; }

            [NameInMap("SipGbId")]
            [Validation(Required=false)]
            public string SipGbId { get; set; }

            [NameInMap("SubDeviceSipInfo")]
            [Validation(Required=false)]
            public List<CreateDeviceResponseBodyDataSubDeviceSipInfo> SubDeviceSipInfo { get; set; }
            public class CreateDeviceResponseBodyDataSubDeviceSipInfo : TeaModel {
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

            [NameInMap("DeviceCode")]
            [Validation(Required=false)]
            public string DeviceCode { get; set; }

        }

    }

}
