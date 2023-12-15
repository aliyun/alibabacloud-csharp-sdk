// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class ListVehicleTopResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListVehicleTopResponseBodyData> Data { get; set; }
        public class ListVehicleTopResponseBodyData : TeaModel {
            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("Frequency")]
            [Validation(Required=false)]
            public string Frequency { get; set; }

            [NameInMap("PassHour")]
            [Validation(Required=false)]
            public string PassHour { get; set; }

            [NameInMap("PoiId")]
            [Validation(Required=false)]
            public string PoiId { get; set; }

            [NameInMap("PoiName")]
            [Validation(Required=false)]
            public string PoiName { get; set; }

            [NameInMap("VehicleId")]
            [Validation(Required=false)]
            public string VehicleId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
