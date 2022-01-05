// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeColumnsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeColumnsResponseBodyItems Items { get; set; }
        public class DescribeColumnsResponseBodyItems : TeaModel {
            [NameInMap("Column")]
            [Validation(Required=false)]
            public List<DescribeColumnsResponseBodyItemsColumn> Column { get; set; }
            public class DescribeColumnsResponseBodyItemsColumn : TeaModel {
                public bool? AutoIncrementColumn { get; set; }
                public string ColumnName { get; set; }
                public string DBClusterId { get; set; }
                public bool? PrimaryKey { get; set; }
                public string SchemaName { get; set; }
                public string TableName { get; set; }
                public string Type { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
