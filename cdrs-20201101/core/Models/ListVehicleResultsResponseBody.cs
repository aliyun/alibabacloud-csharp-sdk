// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class ListVehicleResultsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListVehicleResultsResponseBodyData> Data { get; set; }
        public class ListVehicleResultsResponseBodyData : TeaModel {
            [NameInMap("VehicleApplication")]
            [Validation(Required=false)]
            public string VehicleApplication { get; set; }

            [NameInMap("Profession")]
            [Validation(Required=false)]
            public string Profession { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("Gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }

            [NameInMap("PlateId")]
            [Validation(Required=false)]
            public string PlateId { get; set; }

            [NameInMap("VehicleClass")]
            [Validation(Required=false)]
            public string VehicleClass { get; set; }

            [NameInMap("LiveAddress")]
            [Validation(Required=false)]
            public string LiveAddress { get; set; }

            [NameInMap("VehicleId")]
            [Validation(Required=false)]
            public string VehicleId { get; set; }

            [NameInMap("PersonId")]
            [Validation(Required=false)]
            public string PersonId { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
