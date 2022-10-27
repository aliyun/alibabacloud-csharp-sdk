// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeAvailableMemResourceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAvailableMemResourceResponseBodyData Data { get; set; }
        public class DescribeAvailableMemResourceResponseBodyData : TeaModel {
            [NameInMap("MaxMem")]
            [Validation(Required=false)]
            public long? MaxMem { get; set; }

            [NameInMap("MinMem")]
            [Validation(Required=false)]
            public long? MinMem { get; set; }

            [NameInMap("UsedMem")]
            [Validation(Required=false)]
            public long? UsedMem { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
