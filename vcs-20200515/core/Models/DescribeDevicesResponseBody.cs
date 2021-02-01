// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class DescribeDevicesResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDevicesResponseBodyData Data { get; set; }
        public class DescribeDevicesResponseBodyData : TeaModel {
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<DescribeDevicesResponseBodyDataRecords> Records { get; set; }
            public class DescribeDevicesResponseBodyDataRecords : TeaModel {
                public string Status { get; set; }
                public string DeviceName { get; set; }
                public string DeviceType { get; set; }
                public string DeviceId { get; set; }
                public string DeviceAddress { get; set; }
                public string CreateTime { get; set; }
                public string CorpId { get; set; }
                public string Longitude { get; set; }
                public string InProtocol { get; set; }
                public string Latitude { get; set; }
                public string Vendor { get; set; }
                public string CapturedPictureId { get; set; }
            }
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
