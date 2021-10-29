// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20171016.Models
{
    public class DescribeShardDBsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeShardDBsResponseBodyData Data { get; set; }
        public class DescribeShardDBsResponseBodyData : TeaModel {
            [NameInMap("DbIntancePair")]
            [Validation(Required=false)]
            public List<DescribeShardDBsResponseBodyDataDbIntancePair> DbIntancePair { get; set; }
            public class DescribeShardDBsResponseBodyDataDbIntancePair : TeaModel {
                public string GroupName { get; set; }
                public string InstanceName { get; set; }
                public string SubDbName { get; set; }
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
