// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class CountYunIdInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("YunIdInfo")]
        [Validation(Required=false)]
        public List<CountYunIdInfoResponseBodyYunIdInfo> YunIdInfo { get; set; }
        public class CountYunIdInfoResponseBodyYunIdInfo : TeaModel {
            [NameInMap("TotalBrandCount")]
            [Validation(Required=false)]
            public long? TotalBrandCount { get; set; }

            [NameInMap("TotalDeviceModelCount")]
            [Validation(Required=false)]
            public long? TotalDeviceModelCount { get; set; }

            [NameInMap("TotalDeviceCount")]
            [Validation(Required=false)]
            public long? TotalDeviceCount { get; set; }

        }

    }

}
