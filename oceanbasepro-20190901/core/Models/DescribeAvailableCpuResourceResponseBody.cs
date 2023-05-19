// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeAvailableCpuResourceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAvailableCpuResourceResponseBodyData> Data { get; set; }
        public class DescribeAvailableCpuResourceResponseBodyData : TeaModel {
            [NameInMap("MaxCpu")]
            [Validation(Required=false)]
            public long? MaxCpu { get; set; }

            [NameInMap("MinCpu")]
            [Validation(Required=false)]
            public long? MinCpu { get; set; }

            [NameInMap("UnitNum")]
            [Validation(Required=false)]
            public long? UnitNum { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
