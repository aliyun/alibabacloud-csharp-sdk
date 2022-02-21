// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UpgradeRenderingDevicesHostOSRequest : TeaModel {
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RomName")]
        [Validation(Required=false)]
        public string RomName { get; set; }

        [NameInMap("RomPath")]
        [Validation(Required=false)]
        public string RomPath { get; set; }

        [NameInMap("RomVersion")]
        [Validation(Required=false)]
        public string RomVersion { get; set; }

    }

}
