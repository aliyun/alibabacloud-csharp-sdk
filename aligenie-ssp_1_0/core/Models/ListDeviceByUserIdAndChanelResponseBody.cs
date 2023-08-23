// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListDeviceByUserIdAndChanelResponseBody : TeaModel {
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
        public List<ListDeviceByUserIdAndChanelResponseBodyResult> Result { get; set; }
        public class ListDeviceByUserIdAndChanelResponseBodyResult : TeaModel {
            [NameInMap("DeviceOpenId")]
            [Validation(Required=false)]
            public string DeviceOpenId { get; set; }

            [NameInMap("DeviceUnionIds")]
            [Validation(Required=false)]
            public List<ListDeviceByUserIdAndChanelResponseBodyResultDeviceUnionIds> DeviceUnionIds { get; set; }
            public class ListDeviceByUserIdAndChanelResponseBodyResultDeviceUnionIds : TeaModel {
                [NameInMap("DeviceUnionId")]
                [Validation(Required=false)]
                public string DeviceUnionId { get; set; }

                [NameInMap("OrganizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

            }

        }

    }

}
