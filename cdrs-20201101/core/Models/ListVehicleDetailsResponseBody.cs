// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class ListVehicleDetailsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListVehicleDetailsResponseBodyData> Data { get; set; }
        public class ListVehicleDetailsResponseBodyData : TeaModel {
            [NameInMap("Gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }

            [NameInMap("PersonId")]
            [Validation(Required=false)]
            public string PersonId { get; set; }

            [NameInMap("PersonType")]
            [Validation(Required=false)]
            public string PersonType { get; set; }

            [NameInMap("PlateId")]
            [Validation(Required=false)]
            public string PlateId { get; set; }

            [NameInMap("PopularAddress")]
            [Validation(Required=false)]
            public string PopularAddress { get; set; }

            [NameInMap("PopularPoi")]
            [Validation(Required=false)]
            public string PopularPoi { get; set; }

            [NameInMap("PrefOutTime")]
            [Validation(Required=false)]
            public string PrefOutTime { get; set; }

            [NameInMap("SourceImageStoragePath")]
            [Validation(Required=false)]
            public string SourceImageStoragePath { get; set; }

            [NameInMap("SourceUrl")]
            [Validation(Required=false)]
            public string SourceUrl { get; set; }

            [NameInMap("TargetImageStoragePath")]
            [Validation(Required=false)]
            public string TargetImageStoragePath { get; set; }

            [NameInMap("TargetUrl")]
            [Validation(Required=false)]
            public string TargetUrl { get; set; }

            [NameInMap("VehicleApplication")]
            [Validation(Required=false)]
            public string VehicleApplication { get; set; }

            [NameInMap("VehicleClass")]
            [Validation(Required=false)]
            public string VehicleClass { get; set; }

            [NameInMap("VehicleColor")]
            [Validation(Required=false)]
            public string VehicleColor { get; set; }

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
