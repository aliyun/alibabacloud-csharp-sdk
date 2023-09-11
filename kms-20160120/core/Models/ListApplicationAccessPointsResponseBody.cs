// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListApplicationAccessPointsResponseBody : TeaModel {
        [NameInMap("ApplicationAccessPoints")]
        [Validation(Required=false)]
        public ListApplicationAccessPointsResponseBodyApplicationAccessPoints ApplicationAccessPoints { get; set; }
        public class ListApplicationAccessPointsResponseBodyApplicationAccessPoints : TeaModel {
            [NameInMap("ApplicationAccessPoint")]
            [Validation(Required=false)]
            public List<ListApplicationAccessPointsResponseBodyApplicationAccessPointsApplicationAccessPoint> ApplicationAccessPoint { get; set; }
            public class ListApplicationAccessPointsResponseBodyApplicationAccessPointsApplicationAccessPoint : TeaModel {
                [NameInMap("AuthenticationMethod")]
                [Validation(Required=false)]
                public string AuthenticationMethod { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
