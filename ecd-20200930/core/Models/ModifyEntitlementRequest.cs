// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyEntitlementRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("DesktopId")]
        [Validation(Required=true)]
        public string DesktopId { get; set; }

        [NameInMap("EndUserId")]
        [Validation(Required=true)]
        public List<string> EndUserId { get; set; }

    }

}
