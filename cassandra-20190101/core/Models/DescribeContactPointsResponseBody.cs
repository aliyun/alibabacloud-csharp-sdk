// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cassandra20190101.Models
{
    public class DescribeContactPointsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ContactPoints")]
        [Validation(Required=false)]
        public DescribeContactPointsResponseBodyContactPoints ContactPoints { get; set; }
        public class DescribeContactPointsResponseBodyContactPoints : TeaModel {
            [NameInMap("ContactPoint")]
            [Validation(Required=false)]
            public List<DescribeContactPointsResponseBodyContactPointsContactPoint> ContactPoint { get; set; }
            public class DescribeContactPointsResponseBodyContactPointsContactPoint : TeaModel {
                [NameInMap("PublicAddress")]
                [Validation(Required=false)]
                public List<string> PublicAddress { get; set; }

            }
        };

    }

}
