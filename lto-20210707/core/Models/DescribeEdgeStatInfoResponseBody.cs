// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Lto20210707.Models
{
    public class DescribeEdgeStatInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEdgeStatInfoResponseBodyData Data { get; set; }
        public class DescribeEdgeStatInfoResponseBodyData : TeaModel {
            [NameInMap("TotalDeviceLicenseCount")]
            [Validation(Required=false)]
            public long? TotalDeviceLicenseCount { get; set; }

            [NameInMap("UsedDeviceLicenseCount")]
            [Validation(Required=false)]
            public long? UsedDeviceLicenseCount { get; set; }

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
