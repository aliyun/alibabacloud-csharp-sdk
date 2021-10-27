// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeTableResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeTableResponseBodyData Data { get; set; }
        public class DescribeTableResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DescribeTableResponseBodyDataList> List { get; set; }
            public class DescribeTableResponseBodyDataList : TeaModel {
                public string ColumnName { get; set; }
                public string ColumnType { get; set; }
                public string Extra { get; set; }
                public string Index { get; set; }
                public string IsAllowNull { get; set; }
                public string IsPk { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
