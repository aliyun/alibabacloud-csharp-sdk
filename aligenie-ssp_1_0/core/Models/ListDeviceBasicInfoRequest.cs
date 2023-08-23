// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListDeviceBasicInfoRequest : TeaModel {
        [NameInMap("DeviceInfos")]
        [Validation(Required=false)]
        public ListDeviceBasicInfoRequestDeviceInfos DeviceInfos { get; set; }
        public class ListDeviceBasicInfoRequestDeviceInfos : TeaModel {
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            [NameInMap("Ids")]
            [Validation(Required=false)]
            public List<string> Ids { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

    }

}
