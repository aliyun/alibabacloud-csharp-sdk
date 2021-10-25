// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeTableAccessCountResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeTableAccessCountResponseBodyItems> Items { get; set; }
        public class DescribeTableAccessCountResponseBodyItems : TeaModel {
            [NameInMap("ReportDate")]
            [Validation(Required=false)]
            public string ReportDate { get; set; }

            [NameInMap("TableSchema")]
            [Validation(Required=false)]
            public string TableSchema { get; set; }

            [NameInMap("AccessCount")]
            [Validation(Required=false)]
            public string AccessCount { get; set; }

            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

        }

    }

}
