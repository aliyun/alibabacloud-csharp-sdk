// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeSlsLogstoreInfoResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Quota")]
        [Validation(Required=true)]
        public long? Quota { get; set; }

        [NameInMap("LogStore")]
        [Validation(Required=true)]
        public string LogStore { get; set; }

        [NameInMap("Used")]
        [Validation(Required=true)]
        public long? Used { get; set; }

        [NameInMap("Project")]
        [Validation(Required=true)]
        public string Project { get; set; }

        [NameInMap("Ttl")]
        [Validation(Required=true)]
        public int? Ttl { get; set; }

    }

}
