// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeExcpetionCountResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ExceptionIpCount")]
        [Validation(Required=false)]
        public int? ExceptionIpCount { get; set; }

        [NameInMap("ExpireTimeCount")]
        [Validation(Required=false)]
        public int? ExpireTimeCount { get; set; }

    }

}
