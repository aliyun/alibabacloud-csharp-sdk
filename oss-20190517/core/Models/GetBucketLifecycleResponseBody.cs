// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class GetBucketLifecycleResponseBody : TeaModel {
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public List<LifecycleRule> Rules { get; set; }

    }

}
