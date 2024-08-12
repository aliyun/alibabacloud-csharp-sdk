// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class DescribeDeviceSeatsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeDeviceSeatsResponseBodyData> Data { get; set; }
        public class DescribeDeviceSeatsResponseBodyData : TeaModel {
            [NameInMap("SeatCol")]
            [Validation(Required=false)]
            public int? SeatCol { get; set; }

            [NameInMap("SeatName")]
            [Validation(Required=false)]
            public string SeatName { get; set; }

            [NameInMap("SeatNo")]
            [Validation(Required=false)]
            public string SeatNo { get; set; }

            [NameInMap("SeatRow")]
            [Validation(Required=false)]
            public int? SeatRow { get; set; }

            [NameInMap("SerialNo")]
            [Validation(Required=false)]
            public string SerialNo { get; set; }

            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public string SiteId { get; set; }

            [NameInMap("SiteName")]
            [Validation(Required=false)]
            public string SiteName { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
