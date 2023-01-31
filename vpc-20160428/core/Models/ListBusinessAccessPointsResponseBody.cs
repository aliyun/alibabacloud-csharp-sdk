// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListBusinessAccessPointsResponseBody : TeaModel {
        [NameInMap("BusinessAccessPoints")]
        [Validation(Required=false)]
        public List<ListBusinessAccessPointsResponseBodyBusinessAccessPoints> BusinessAccessPoints { get; set; }
        public class ListBusinessAccessPointsResponseBodyBusinessAccessPoints : TeaModel {
            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

            [NameInMap("AccessPointName")]
            [Validation(Required=false)]
            public string AccessPointName { get; set; }

            [NameInMap("CloudBoxInstanceIds")]
            [Validation(Required=false)]
            public string CloudBoxInstanceIds { get; set; }

            [NameInMap("Latitude")]
            [Validation(Required=false)]
            public double? Latitude { get; set; }

            [NameInMap("Longitude")]
            [Validation(Required=false)]
            public double? Longitude { get; set; }

            [NameInMap("SupportLineOperator")]
            [Validation(Required=false)]
            public string SupportLineOperator { get; set; }

            [NameInMap("SupportPortTypes")]
            [Validation(Required=false)]
            public string SupportPortTypes { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
