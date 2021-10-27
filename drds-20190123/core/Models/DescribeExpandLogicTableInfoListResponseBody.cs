// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeExpandLogicTableInfoListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeExpandLogicTableInfoListResponseBodyData Data { get; set; }
        public class DescribeExpandLogicTableInfoListResponseBodyData : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<DescribeExpandLogicTableInfoListResponseBodyDataData> Data { get; set; }
            public class DescribeExpandLogicTableInfoListResponseBodyDataData : TeaModel {
                public string ShardDbKey { get; set; }
                public string ShardTbKey { get; set; }
                public string TableName { get; set; }
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
