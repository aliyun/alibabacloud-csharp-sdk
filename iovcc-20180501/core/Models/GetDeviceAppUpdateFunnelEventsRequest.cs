// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class GetDeviceAppUpdateFunnelEventsRequest : TeaModel {
        [NameInMap("PackageName")]
        [Validation(Required=false)]
        public string PackageName { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("TargetVersionCode")]
        [Validation(Required=false)]
        public string TargetVersionCode { get; set; }

        [NameInMap("IdType")]
        [Validation(Required=false)]
        public string IdType { get; set; }

        [NameInMap("OriginalId")]
        [Validation(Required=false)]
        public string OriginalId { get; set; }

    }

}
