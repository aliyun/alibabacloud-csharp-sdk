// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListDevicesResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDevicesResponseBodyData Data { get; set; }
        public class ListDevicesResponseBodyData : TeaModel {
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<ListDevicesResponseBodyDataRecords> Records { get; set; }
            public class ListDevicesResponseBodyDataRecords : TeaModel {
                public int? Status { get; set; }
                public string SipGBId { get; set; }
                public string DeviceDirection { get; set; }
                public string DeviceName { get; set; }
                public string DeviceAddress { get; set; }
                public string DeviceType { get; set; }
                public string CreateTime { get; set; }
                public string SipPassword { get; set; }
                public string SipServerPort { get; set; }
                public string Vendor { get; set; }
                public string GbId { get; set; }
                public string CoverImageUrl { get; set; }
                public string AccessProtocolType { get; set; }
                public string DeviceSite { get; set; }
                public string Longitude { get; set; }
                public string Latitude { get; set; }
                public string Resolution { get; set; }
                public string SipServerIp { get; set; }
                public string BitRate { get; set; }
            }
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
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
