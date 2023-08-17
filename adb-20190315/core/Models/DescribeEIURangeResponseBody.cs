// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeEIURangeResponseBody : TeaModel {
        [NameInMap("EIUInfo")]
        [Validation(Required=false)]
        public DescribeEIURangeResponseBodyEIUInfo EIUInfo { get; set; }
        public class DescribeEIURangeResponseBodyEIUInfo : TeaModel {
            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            [NameInMap("EIURange")]
            [Validation(Required=false)]
            public List<long?> EIURange { get; set; }

            [NameInMap("StorageResourceRange")]
            [Validation(Required=false)]
            public List<string> StorageResourceRange { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
