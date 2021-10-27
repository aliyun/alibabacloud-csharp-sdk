// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDistributeTableListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDistributeTableListResponseBodyData Data { get; set; }
        public class DescribeDistributeTableListResponseBodyData : TeaModel {
            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<DescribeDistributeTableListResponseBodyDataTables> Tables { get; set; }
            public class DescribeDistributeTableListResponseBodyDataTables : TeaModel {
                public string DbKey { get; set; }
                public string TableName { get; set; }
                public string TableType { get; set; }
                public string TbKey { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
