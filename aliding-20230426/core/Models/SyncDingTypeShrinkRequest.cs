// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class SyncDingTypeShrinkRequest : TeaModel {
        [NameInMap("DingType")]
        [Validation(Required=false)]
        public string DingType { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

        [NameInMap("WorkNo")]
        [Validation(Required=false)]
        public string WorkNo { get; set; }

    }

}
