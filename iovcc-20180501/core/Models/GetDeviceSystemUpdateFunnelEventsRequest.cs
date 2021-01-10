// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class GetDeviceSystemUpdateFunnelEventsRequest : TeaModel {
        [NameInMap("OriginalId")]
        [Validation(Required=false)]
        public string OriginalId { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("TargetVersion")]
        [Validation(Required=false)]
        public string TargetVersion { get; set; }

        [NameInMap("IdType")]
        [Validation(Required=false)]
        public string IdType { get; set; }

    }

}
