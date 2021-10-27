// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeRecycleBinTablesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeRecycleBinTablesResponseBodyData> Data { get; set; }
        public class DescribeRecycleBinTablesResponseBodyData : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("OriginalTableName")]
            [Validation(Required=false)]
            public string OriginalTableName { get; set; }

            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
