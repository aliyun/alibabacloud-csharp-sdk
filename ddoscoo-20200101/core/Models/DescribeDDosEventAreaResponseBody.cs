// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosEventAreaResponseBody : TeaModel {
        /// <summary>
        /// The information about the source region from which the volumetric attack was initiated.
        /// </summary>
        [NameInMap("Areas")]
        [Validation(Required=false)]
        public List<DescribeDDosEventAreaResponseBodyAreas> Areas { get; set; }
        public class DescribeDDosEventAreaResponseBodyAreas : TeaModel {
            /// <summary>
            /// The code or ID of the source region. For more information, see [Codes of administrative regions in China and codes of countries and areas](~~167926~~). For example, **110000** indicates Beijing, China, and **us** indicates the United States.
            /// </summary>
            [NameInMap("Area")]
            [Validation(Required=false)]
            public string Area { get; set; }

            /// <summary>
            /// The number of request packets that were sent from the source region.
            /// </summary>
            [NameInMap("InPkts")]
            [Validation(Required=false)]
            public long? InPkts { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
