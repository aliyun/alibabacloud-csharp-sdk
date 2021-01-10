// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class SkipTSShardingActivityInstancesRequest : TeaModel {
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("CurSharding")]
        [Validation(Required=false)]
        public long? CurSharding { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ParentActivityInstanceId")]
        [Validation(Required=false)]
        public long? ParentActivityInstanceId { get; set; }

        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

    }

}
