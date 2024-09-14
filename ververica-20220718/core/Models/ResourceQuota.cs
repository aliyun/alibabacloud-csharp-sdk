// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ResourceQuota : TeaModel {
        [NameInMap("limit")]
        [Validation(Required=false)]
        public ResourceSpec Limit { get; set; }

        [NameInMap("used")]
        [Validation(Required=false)]
        public ResourceSpec Used { get; set; }

    }

}
