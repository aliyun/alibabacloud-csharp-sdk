// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class ModifyDeviceInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserDeviceId")]
        [Validation(Required=false)]
        public string UserDeviceId { get; set; }

        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        [NameInMap("ExpiredDay")]
        [Validation(Required=false)]
        public string ExpiredDay { get; set; }

        [NameInMap("BeginDay")]
        [Validation(Required=false)]
        public string BeginDay { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

    }

}
