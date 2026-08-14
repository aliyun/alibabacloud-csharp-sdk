// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeAutoCcListCountResponseBody : TeaModel {
        [NameInMap("BlackCount")]
        [Validation(Required=false)]
        public int? BlackCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WhiteCount")]
        [Validation(Required=false)]
        public int? WhiteCount { get; set; }

    }

}
