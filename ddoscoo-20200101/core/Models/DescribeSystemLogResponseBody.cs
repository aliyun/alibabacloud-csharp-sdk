// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeSystemLogResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SystemLog")]
        [Validation(Required=false)]
        public List<DescribeSystemLogResponseBodySystemLog> SystemLog { get; set; }
        public class DescribeSystemLogResponseBodySystemLog : TeaModel {
            [NameInMap("EntityObject")]
            [Validation(Required=false)]
            public string EntityObject { get; set; }

            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public int? EntityType { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("OpAccount")]
            [Validation(Required=false)]
            public string OpAccount { get; set; }

            [NameInMap("OpAction")]
            [Validation(Required=false)]
            public int? OpAction { get; set; }

            [NameInMap("OpDesc")]
            [Validation(Required=false)]
            public string OpDesc { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
