// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeTableResponseBody : TeaModel {
        [NameInMap("ColumnList")]
        [Validation(Required=false)]
        public DescribeTableResponseBodyColumnList ColumnList { get; set; }
        public class DescribeTableResponseBodyColumnList : TeaModel {
            [NameInMap("ColumnList")]
            [Validation(Required=false)]
            public List<ColumnMetadata> ColumnList { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
