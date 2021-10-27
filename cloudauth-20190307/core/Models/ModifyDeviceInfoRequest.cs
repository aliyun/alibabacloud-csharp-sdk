// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class ModifyDeviceInfoRequest : TeaModel {
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("DeviceId")]
        [Validation(Required=true)]
        public string DeviceId { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        [NameInMap("ExpiredDay")]
        [Validation(Required=false)]
        public string ExpiredDay { get; set; }

        [NameInMap("UserDeviceId")]
        [Validation(Required=false)]
        public string UserDeviceId { get; set; }

    }

}
