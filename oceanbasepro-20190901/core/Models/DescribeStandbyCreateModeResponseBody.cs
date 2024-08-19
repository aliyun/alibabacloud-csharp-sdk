// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeStandbyCreateModeResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeStandbyCreateModeResponseBodyData Data { get; set; }
        public class DescribeStandbyCreateModeResponseBodyData : TeaModel {
            [NameInMap("CreateMode")]
            [Validation(Required=false)]
            public string CreateMode { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
