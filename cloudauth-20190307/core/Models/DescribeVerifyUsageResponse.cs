// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifyUsageResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("VerifyUsageList")]
        [Validation(Required=true)]
        public List<DescribeVerifyUsageResponseVerifyUsageList> VerifyUsageList { get; set; }
        public class DescribeVerifyUsageResponseVerifyUsageList : TeaModel {
            [NameInMap("BizType")]
            [Validation(Required=true)]
            public string BizType { get; set; }

            [NameInMap("Date")]
            [Validation(Required=true)]
            public string Date { get; set; }

            [NameInMap("FailCount")]
            [Validation(Required=true)]
            public long? FailCount { get; set; }

            [NameInMap("PassCount")]
            [Validation(Required=true)]
            public long? PassCount { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public long? TotalCount { get; set; }

        }

    }

}
