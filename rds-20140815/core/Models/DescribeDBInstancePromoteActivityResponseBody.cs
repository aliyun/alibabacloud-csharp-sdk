// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstancePromoteActivityResponseBody : TeaModel {
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public string AliUid { get; set; }

        [NameInMap("Bid")]
        [Validation(Required=false)]
        public string Bid { get; set; }

        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        [NameInMap("IsActivity")]
        [Validation(Required=false)]
        public string IsActivity { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
