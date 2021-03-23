// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class DescribeVersionDeviceGroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DeviceGroup")]
        [Validation(Required=false)]
        public DescribeVersionDeviceGroupResponseBodyDeviceGroup DeviceGroup { get; set; }
        public class DescribeVersionDeviceGroupResponseBodyDeviceGroup : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("GmtModify")]
            [Validation(Required=false)]
            public string GmtModify { get; set; }
            [NameInMap("MaxCount")]
            [Validation(Required=false)]
            public string MaxCount { get; set; }
        };

    }

}
