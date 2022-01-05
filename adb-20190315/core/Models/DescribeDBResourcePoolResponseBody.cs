// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBResourcePoolResponseBody : TeaModel {
        [NameInMap("PoolsInfo")]
        [Validation(Required=false)]
        public List<DescribeDBResourcePoolResponseBodyPoolsInfo> PoolsInfo { get; set; }
        public class DescribeDBResourcePoolResponseBodyPoolsInfo : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public int? NodeNum { get; set; }

            [NameInMap("PoolName")]
            [Validation(Required=false)]
            public string PoolName { get; set; }

            [NameInMap("PoolUsers")]
            [Validation(Required=false)]
            public string PoolUsers { get; set; }

            [NameInMap("QueryType")]
            [Validation(Required=false)]
            public string QueryType { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
