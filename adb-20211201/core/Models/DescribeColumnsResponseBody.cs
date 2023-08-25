// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
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
                [NameInMap("AutoIncrementColumn")]
                [Validation(Required=false)]
                public bool? AutoIncrementColumn { get; set; }

                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                [NameInMap("PrimaryKey")]
                [Validation(Required=false)]
                public bool? PrimaryKey { get; set; }

                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
