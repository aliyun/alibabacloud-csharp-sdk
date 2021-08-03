// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class StartVirusScanTaskRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public List<string> OfficeSiteId { get; set; }

        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

    }

}
