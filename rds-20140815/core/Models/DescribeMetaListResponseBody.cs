// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeMetaListResponseBody : TeaModel {
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        [NameInMap("TotalPageCount")]
        [Validation(Required=false)]
        public int? TotalPageCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeMetaListResponseBodyItems Items { get; set; }
        public class DescribeMetaListResponseBodyItems : TeaModel {
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public List<DescribeMetaListResponseBodyItemsMeta> Meta { get; set; }
            public class DescribeMetaListResponseBodyItemsMeta : TeaModel {
                public string Tables { get; set; }
                public string Database { get; set; }
                public string Size { get; set; }
            }
        };

    }

}
