// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDBInstanceTDEResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBInstanceTDEResponseBodyData Data { get; set; }
        public class DescribeDBInstanceTDEResponseBodyData : TeaModel {
            [NameInMap("TDEStatus")]
            [Validation(Required=false)]
            public string TDEStatus { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
