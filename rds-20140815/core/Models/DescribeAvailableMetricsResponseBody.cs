// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAvailableMetricsResponseBody : TeaModel {
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAvailableMetricsResponseBodyItems> Items { get; set; }
        public class DescribeAvailableMetricsResponseBodyItems : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Dimension")]
            [Validation(Required=false)]
            public string Dimension { get; set; }

            [NameInMap("GroupKey")]
            [Validation(Required=false)]
            public string GroupKey { get; set; }

            [NameInMap("GroupKeyType")]
            [Validation(Required=false)]
            public string GroupKeyType { get; set; }

            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            [NameInMap("MetricsKey")]
            [Validation(Required=false)]
            public string MetricsKey { get; set; }

            [NameInMap("MetricsKeyAlias")]
            [Validation(Required=false)]
            public string MetricsKeyAlias { get; set; }

            [NameInMap("SortRule")]
            [Validation(Required=false)]
            public int? SortRule { get; set; }

            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
