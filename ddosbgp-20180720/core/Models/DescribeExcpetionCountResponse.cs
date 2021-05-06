// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeExcpetionCountResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ExceptionIpCount")]
        [Validation(Required=true)]
        public int? ExceptionIpCount { get; set; }

        [NameInMap("ExpireTimeCount")]
        [Validation(Required=true)]
        public int? ExpireTimeCount { get; set; }

    }

}
