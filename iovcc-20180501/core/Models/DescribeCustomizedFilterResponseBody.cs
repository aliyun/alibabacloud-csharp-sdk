// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class DescribeCustomizedFilterResponseBody : TeaModel {
        [NameInMap("CustomizedFilter")]
        [Validation(Required=false)]
        public DescribeCustomizedFilterResponseBodyCustomizedFilter CustomizedFilter { get; set; }
        public class DescribeCustomizedFilterResponseBodyCustomizedFilter : TeaModel {
            [NameInMap("GmtCreateTimestamp")]
            [Validation(Required=false)]
            public long? GmtCreateTimestamp { get; set; }
            [NameInMap("GmtModify")]
            [Validation(Required=false)]
            public string GmtModify { get; set; }
            [NameInMap("ValueCompareType")]
            [Validation(Required=false)]
            public string ValueCompareType { get; set; }
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public long? VersionId { get; set; }
            [NameInMap("GmtModifyTimestamp")]
            [Validation(Required=false)]
            public long? GmtModifyTimestamp { get; set; }
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }
            [NameInMap("ValueType")]
            [Validation(Required=false)]
            public string ValueType { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("BlackWhiteType")]
            [Validation(Required=false)]
            public string BlackWhiteType { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("VersionType")]
            [Validation(Required=false)]
            public string VersionType { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
