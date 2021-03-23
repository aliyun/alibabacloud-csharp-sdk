// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class DescribeDeviceBrandResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DeviceBrand")]
        [Validation(Required=false)]
        public DescribeDeviceBrandResponseBodyDeviceBrand DeviceBrand { get; set; }
        public class DescribeDeviceBrandResponseBodyDeviceBrand : TeaModel {
            [NameInMap("DeviceBrandId")]
            [Validation(Required=false)]
            public long? DeviceBrandId { get; set; }
            [NameInMap("DeviceBrand")]
            [Validation(Required=false)]
            public string DeviceBrand { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }
            [NameInMap("Manufacture")]
            [Validation(Required=false)]
            public string Manufacture { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
        };

    }

}
