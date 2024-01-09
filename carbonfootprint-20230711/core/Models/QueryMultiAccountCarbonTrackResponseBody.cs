// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CarbonFootprint20230711.Models
{
    public class QueryMultiAccountCarbonTrackResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryMultiAccountCarbonTrackResponseBodyData> Data { get; set; }
        public class QueryMultiAccountCarbonTrackResponseBodyData : TeaModel {
            [NameInMap("CarbonActualEmission")]
            [Validation(Required=false)]
            public string CarbonActualEmission { get; set; }

            [NameInMap("Month")]
            [Validation(Required=false)]
            public string Month { get; set; }

            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
