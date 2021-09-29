// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class GetCommercialVehicleTrackResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Points")]
        [Validation(Required=false)]
        public List<GetCommercialVehicleTrackResponseBodyPoints> Points { get; set; }
        public class GetCommercialVehicleTrackResponseBodyPoints : TeaModel {
            [NameInMap("Longitude")]
            [Validation(Required=false)]
            public string Longitude { get; set; }

            [NameInMap("Latitude")]
            [Validation(Required=false)]
            public string Latitude { get; set; }

            [NameInMap("Altitude")]
            [Validation(Required=false)]
            public string Altitude { get; set; }

            [NameInMap("Speed")]
            [Validation(Required=false)]
            public long? Speed { get; set; }

            [NameInMap("Direction")]
            [Validation(Required=false)]
            public long? Direction { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

        }

    }

}
