// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ResultValue : TeaModel {
        [NameInMap("DeviceOpenId")]
        [Validation(Required=false)]
        public string DeviceOpenId { get; set; }

        [NameInMap("DeviceUnionIds")]
        [Validation(Required=false)]
        public List<ResultValueDeviceUnionIds> DeviceUnionIds { get; set; }
        public class ResultValueDeviceUnionIds : TeaModel {
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            [NameInMap("DeviceUnionId")]
            [Validation(Required=false)]
            public string DeviceUnionId { get; set; }

        }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("FirmwareVersion")]
        [Validation(Required=false)]
        public string FirmwareVersion { get; set; }

        [NameInMap("Mac")]
        [Validation(Required=false)]
        public string Mac { get; set; }

        [NameInMap("Sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

    }

}
