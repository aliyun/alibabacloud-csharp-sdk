// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifyUsageResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VerifyUsageList")]
        [Validation(Required=false)]
        public List<DescribeVerifyUsageResponseBodyVerifyUsageList> VerifyUsageList { get; set; }
        public class DescribeVerifyUsageResponseBodyVerifyUsageList : TeaModel {
            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            [NameInMap("PassCount")]
            [Validation(Required=false)]
            public long? PassCount { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public long? FailCount { get; set; }

            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

        }

    }

}
