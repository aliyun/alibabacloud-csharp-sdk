// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class ModifyDeviceInfoResponse : TeaModel {
        [NameInMap("BeginDay")]
        [Validation(Required=true)]
        public string BeginDay { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=true)]
        public string BizType { get; set; }

        [NameInMap("DeviceId")]
        [Validation(Required=true)]
        public string DeviceId { get; set; }

        [NameInMap("ExpiredDay")]
        [Validation(Required=true)]
        public string ExpiredDay { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("UserDeviceId")]
        [Validation(Required=true)]
        public string UserDeviceId { get; set; }

    }

}
