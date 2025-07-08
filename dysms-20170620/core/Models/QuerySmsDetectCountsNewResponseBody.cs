// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QuerySmsDetectCountsNewResponseBody : TeaModel {
        [NameInMap("DetectedTimes")]
        [Validation(Required=false)]
        public int? DetectedTimes { get; set; }

        [NameInMap("LeftTimes")]
        [Validation(Required=false)]
        public int? LeftTimes { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
