// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20190430.Models
{
    public class DescribeDevicesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeDevicesResponseBodyData> Data { get; set; }
        public class DescribeDevicesResponseBodyData : TeaModel {
            [NameInMap("DeviceCode")]
            [Validation(Required=false)]
            public string DeviceCode { get; set; }

            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            [NameInMap("FrameRate")]
            [Validation(Required=false)]
            public string FrameRate { get; set; }

            [NameInMap("ImageSize")]
            [Validation(Required=false)]
            public float? ImageSize { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("PullStreamStatus")]
            [Validation(Required=false)]
            public string PullStreamStatus { get; set; }

            [NameInMap("RealTimeDataRate")]
            [Validation(Required=false)]
            public string RealTimeDataRate { get; set; }

            [NameInMap("StructuredSize")]
            [Validation(Required=false)]
            public float? StructuredSize { get; set; }

            [NameInMap("VectorSize")]
            [Validation(Required=false)]
            public float? VectorSize { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
