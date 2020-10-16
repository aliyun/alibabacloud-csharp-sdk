// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class DescribeDevicesResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public DescribeDevicesResponseData Data { get; set; }
        public class DescribeDevicesResponseData : TeaModel {
            [NameInMap("PageNum")]
            [Validation(Required=true)]
            public int? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public int? TotalCount { get; set; }
            [NameInMap("TotalPage")]
            [Validation(Required=true)]
            public int? TotalPage { get; set; }
            [NameInMap("Records")]
            [Validation(Required=true)]
            public List<DescribeDevicesResponseDataRecords> Records { get; set; }
            public class DescribeDevicesResponseDataRecords : TeaModel {
                public string InProtocol { get; set; }
                public string CreateTime { get; set; }
                public string DeviceAddress { get; set; }
                public string DeviceId { get; set; }
                public string DeviceName { get; set; }
                public string DeviceType { get; set; }
                public string Latitude { get; set; }
                public string Longitude { get; set; }
                public string Status { get; set; }
                public string Vendor { get; set; }
                public string CorpId { get; set; }
            }
        };

    }

}
