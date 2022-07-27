// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeHanaDatabasesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HanaDatabases")]
        [Validation(Required=false)]
        public DescribeHanaDatabasesResponseBodyHanaDatabases HanaDatabases { get; set; }
        public class DescribeHanaDatabasesResponseBodyHanaDatabases : TeaModel {
            [NameInMap("HanaDatabase")]
            [Validation(Required=false)]
            public List<DescribeHanaDatabasesResponseBodyHanaDatabasesHanaDatabase> HanaDatabase { get; set; }
            public class DescribeHanaDatabasesResponseBodyHanaDatabasesHanaDatabase : TeaModel {
                public string ActiveStatus { get; set; }
                public string DatabaseName { get; set; }
                public string Detail { get; set; }
                public string Host { get; set; }
                public string ServiceName { get; set; }
                public int? SqlPort { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
