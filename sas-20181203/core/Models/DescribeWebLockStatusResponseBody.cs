// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWebLockStatusResponseBody : TeaModel {
        [NameInMap("AuthCount")]
        [Validation(Required=false)]
        public int? AuthCount { get; set; }

        [NameInMap("BindCount")]
        [Validation(Required=false)]
        public int? BindCount { get; set; }

        [NameInMap("BlockCount")]
        [Validation(Required=false)]
        public int? BlockCount { get; set; }

        [NameInMap("DirCount")]
        [Validation(Required=false)]
        public int? DirCount { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WhiteCount")]
        [Validation(Required=false)]
        public int? WhiteCount { get; set; }

    }

}
