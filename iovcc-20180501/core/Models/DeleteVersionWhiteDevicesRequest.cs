// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class DeleteVersionWhiteDevicesRequest : TeaModel {
        [NameInMap("DeviceIds")]
        [Validation(Required=false)]
        public string DeviceIds { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("VersionType")]
        [Validation(Required=false)]
        public string VersionType { get; set; }

        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        [NameInMap("DeviceIdType")]
        [Validation(Required=false)]
        public string DeviceIdType { get; set; }

    }

}
