// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeBackupDbsResponseBody : TeaModel {
        [NameInMap("DbNames")]
        [Validation(Required=false)]
        public DescribeBackupDbsResponseBodyDbNames DbNames { get; set; }
        public class DescribeBackupDbsResponseBodyDbNames : TeaModel {
            [NameInMap("dbName")]
            [Validation(Required=false)]
            public List<string> DbName { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
