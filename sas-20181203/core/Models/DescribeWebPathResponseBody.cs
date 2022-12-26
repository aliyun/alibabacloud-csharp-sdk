// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWebPathResponseBody : TeaModel {
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public List<DescribeWebPathResponseBodyConfigList> ConfigList { get; set; }
        public class DescribeWebPathResponseBodyConfigList : TeaModel {
            [NameInMap("TargetList")]
            [Validation(Required=false)]
            public List<DescribeWebPathResponseBodyConfigListTargetList> TargetList { get; set; }
            public class DescribeWebPathResponseBodyConfigListTargetList : TeaModel {
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

            [NameInMap("WebPath")]
            [Validation(Required=false)]
            public string WebPath { get; set; }

            [NameInMap("WebPathType")]
            [Validation(Required=false)]
            public string WebPathType { get; set; }

        }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
