// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeTableShardingInfoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeTableShardingInfoResponseBodyData Data { get; set; }
        public class DescribeTableShardingInfoResponseBodyData : TeaModel {
            [NameInMap("ColumnList")]
            [Validation(Required=false)]
            public List<DescribeTableShardingInfoResponseBodyDataColumnList> ColumnList { get; set; }
            public class DescribeTableShardingInfoResponseBodyDataColumnList : TeaModel {
                public string Name { get; set; }
                public string Type { get; set; }
            }
            [NameInMap("DbComputeLength")]
            [Validation(Required=false)]
            public int? DbComputeLength { get; set; }
            [NameInMap("DbRightShiftOffset")]
            [Validation(Required=false)]
            public int? DbRightShiftOffset { get; set; }
            [NameInMap("DbShardingColumnList")]
            [Validation(Required=false)]
            public List<string> DbShardingColumnList { get; set; }
            [NameInMap("DbShardingFunction")]
            [Validation(Required=false)]
            public string DbShardingFunction { get; set; }
            [NameInMap("IsShard")]
            [Validation(Required=false)]
            public bool? IsShard { get; set; }
            [NameInMap("TbComputeLength")]
            [Validation(Required=false)]
            public int? TbComputeLength { get; set; }
            [NameInMap("TbPartitions")]
            [Validation(Required=false)]
            public int? TbPartitions { get; set; }
            [NameInMap("TbRightShiftOffset")]
            [Validation(Required=false)]
            public int? TbRightShiftOffset { get; set; }
            [NameInMap("TbShardingColumnList")]
            [Validation(Required=false)]
            public List<string> TbShardingColumnList { get; set; }
            [NameInMap("TbShardingFunction")]
            [Validation(Required=false)]
            public string TbShardingFunction { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
