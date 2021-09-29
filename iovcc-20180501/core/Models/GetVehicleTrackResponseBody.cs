// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class GetVehicleTrackResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Points")]
        [Validation(Required=false)]
        public List<GetVehicleTrackResponseBodyPoints> Points { get; set; }
        public class GetVehicleTrackResponseBodyPoints : TeaModel {
            [NameInMap("Longitude")]
            [Validation(Required=false)]
            public float? Longitude { get; set; }

            [NameInMap("Latitude")]
            [Validation(Required=false)]
            public float? Latitude { get; set; }

            [NameInMap("Altitude")]
            [Validation(Required=false)]
            public float? Altitude { get; set; }

            [NameInMap("Speed")]
            [Validation(Required=false)]
            public int? Speed { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

    }

}
