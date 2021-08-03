// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RecreateDesktopGroupRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        [NameInMap("OwnBundleId")]
        [Validation(Required=false)]
        public string OwnBundleId { get; set; }

    }

}
