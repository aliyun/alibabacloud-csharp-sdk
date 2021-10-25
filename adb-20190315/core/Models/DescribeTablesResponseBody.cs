// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeTablesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeTablesResponseBodyItems Items { get; set; }
        public class DescribeTablesResponseBodyItems : TeaModel {
            [NameInMap("Table")]
            [Validation(Required=false)]
            public List<DescribeTablesResponseBodyItemsTable> Table { get; set; }
            public class DescribeTablesResponseBodyItemsTable : TeaModel {
                public string SchemaName { get; set; }
                public string TableName { get; set; }
                public string DBClusterId { get; set; }
            }
        };

    }

}
