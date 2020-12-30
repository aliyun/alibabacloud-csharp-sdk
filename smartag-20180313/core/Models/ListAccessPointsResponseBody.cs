// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ListAccessPointsResponseBody : TeaModel {
        [NameInMap("AccessPoints")]
        [Validation(Required=false)]
        public List<ListAccessPointsResponseBodyAccessPoints> AccessPoints { get; set; }
        public class ListAccessPointsResponseBodyAccessPoints : TeaModel {
            [NameInMap("Longitude")]
            [Validation(Required=false)]
            public string Longitude { get; set; }

            [NameInMap("ActiveSmartAGCount")]
            [Validation(Required=false)]
            public int? ActiveSmartAGCount { get; set; }

            [NameInMap("InactiveSmartAGCount")]
            [Validation(Required=false)]
            public int? InactiveSmartAGCount { get; set; }

            [NameInMap("Latitude")]
            [Validation(Required=false)]
            public string Latitude { get; set; }

            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public int? AccessPointId { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
