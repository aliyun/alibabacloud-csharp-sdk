// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class DescribeWorkZonesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeWorkZonesResponseBodyData Data { get; set; }
        public class DescribeWorkZonesResponseBodyData : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("WorkZoneDTOList")]
            [Validation(Required=false)]
            public List<DescribeWorkZonesResponseBodyDataWorkZoneDTOList> WorkZoneDTOList { get; set; }
            public class DescribeWorkZonesResponseBodyDataWorkZoneDTOList : TeaModel {
                [NameInMap("SeatCol")]
                [Validation(Required=false)]
                public int? SeatCol { get; set; }

                [NameInMap("SeatRow")]
                [Validation(Required=false)]
                public int? SeatRow { get; set; }

                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                [NameInMap("ZoneName")]
                [Validation(Required=false)]
                public string ZoneName { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
