// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ReportDeviceCapacityRequest : TeaModel {
        [NameInMap("Longitude")]
        [Validation(Required=false)]
        public string Longitude { get; set; }

        [NameInMap("Latitude")]
        [Validation(Required=false)]
        public string Latitude { get; set; }

        [NameInMap("AudioFormat")]
        [Validation(Required=false)]
        public string AudioFormat { get; set; }

        [NameInMap("PresetNum")]
        [Validation(Required=false)]
        public string PresetNum { get; set; }

        [NameInMap("PTZCapacity")]
        [Validation(Required=false)]
        public string PTZCapacity { get; set; }

        [NameInMap("DeviceSn")]
        [Validation(Required=true)]
        public string DeviceSn { get; set; }

        [NameInMap("StreamCapacities")]
        [Validation(Required=true)]
        public List<ReportDeviceCapacityRequestStreamCapacities> StreamCapacities { get; set; }
        public class ReportDeviceCapacityRequestStreamCapacities : TeaModel {
            [NameInMap("EncodeFormat")]
            [Validation(Required=true)]
            public string EncodeFormat { get; set; }

            [NameInMap("Resolution")]
            [Validation(Required=true)]
            public string Resolution { get; set; }

            [NameInMap("MaxFrameRate")]
            [Validation(Required=true)]
            public string MaxFrameRate { get; set; }

            [NameInMap("MaxStream")]
            [Validation(Required=true)]
            public string MaxStream { get; set; }

            [NameInMap("BitrateRange")]
            [Validation(Required=true)]
            public string BitrateRange { get; set; }

            [NameInMap("GovLengthRange")]
            [Validation(Required=true)]
            public string GovLengthRange { get; set; }

        }

        [NameInMap("DeviceTimeStamp")]
        [Validation(Required=true)]
        public string DeviceTimeStamp { get; set; }

    }

}
