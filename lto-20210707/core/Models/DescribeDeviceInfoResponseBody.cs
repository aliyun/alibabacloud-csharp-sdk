// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Lto20210707.Models
{
    public class DescribeDeviceInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDeviceInfoResponseBodyData Data { get; set; }
        public class DescribeDeviceInfoResponseBodyData : TeaModel {
            [NameInMap("AuthorizedCount")]
            [Validation(Required=false)]
            public int? AuthorizedCount { get; set; }

            [NameInMap("DeviceCount")]
            [Validation(Required=false)]
            public int? DeviceCount { get; set; }

            [NameInMap("DistributableCount")]
            [Validation(Required=false)]
            public int? DistributableCount { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
