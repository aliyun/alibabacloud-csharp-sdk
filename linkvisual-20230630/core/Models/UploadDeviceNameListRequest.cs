// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20230630.Models
{
    public class UploadDeviceNameListRequest : TeaModel {
        [NameInMap("DeviceNames")]
        [Validation(Required=false)]
        public List<string> DeviceNames { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

    }

}
