// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class DeviceControlRequest : TeaModel {
        [NameInMap("ControlRequest")]
        [Validation(Required=false)]
        public DeviceControlRequestControlRequest ControlRequest { get; set; }
        public class DeviceControlRequestControlRequest : TeaModel {
            [NameInMap("Muted")]
            [Validation(Required=false)]
            public bool? Muted { get; set; }

            [NameInMap("Volume")]
            [Validation(Required=false)]
            public int? Volume { get; set; }

        }

        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public DeviceControlRequestDeviceInfo DeviceInfo { get; set; }
        public class DeviceControlRequestDeviceInfo : TeaModel {
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

    }

}
