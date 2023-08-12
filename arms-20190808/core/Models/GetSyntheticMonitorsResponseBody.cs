// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetSyntheticMonitorsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetSyntheticMonitorsResponseBodyData> Data { get; set; }
        public class GetSyntheticMonitorsResponseBodyData : TeaModel {
            [NameInMap("Available")]
            [Validation(Required=false)]
            public string Available { get; set; }

            [NameInMap("CanBeSelected")]
            [Validation(Required=false)]
            public bool? CanBeSelected { get; set; }

            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public int? ClientType { get; set; }

            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            [NameInMap("Ipv6")]
            [Validation(Required=false)]
            public int? Ipv6 { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("OperatorCode")]
            [Validation(Required=false)]
            public string OperatorCode { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
