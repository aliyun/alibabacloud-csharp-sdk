// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cassandra20190101.Models
{
    public class DescribeContactPointsResponseBody : TeaModel {
        [NameInMap("ContactPoints")]
        [Validation(Required=false)]
        public DescribeContactPointsResponseBodyContactPoints ContactPoints { get; set; }
        public class DescribeContactPointsResponseBodyContactPoints : TeaModel {
            [NameInMap("ContactPoint")]
            [Validation(Required=false)]
            public List<DescribeContactPointsResponseBodyContactPointsContactPoint> ContactPoint { get; set; }
            public class DescribeContactPointsResponseBodyContactPointsContactPoint : TeaModel {
                [NameInMap("DataCenterId")]
                [Validation(Required=false)]
                public string DataCenterId { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("PrivateAddresses")]
                [Validation(Required=false)]
                public DescribeContactPointsResponseBodyContactPointsContactPointPrivateAddresses PrivateAddresses { get; set; }
                public class DescribeContactPointsResponseBodyContactPointsContactPointPrivateAddresses : TeaModel {
                    [NameInMap("PrivateAddress")]
                    [Validation(Required=false)]
                    public List<string> PrivateAddress { get; set; }

                }

                [NameInMap("PublicAddresses")]
                [Validation(Required=false)]
                public DescribeContactPointsResponseBodyContactPointsContactPointPublicAddresses PublicAddresses { get; set; }
                public class DescribeContactPointsResponseBodyContactPointsContactPointPublicAddresses : TeaModel {
                    [NameInMap("PublicAddress")]
                    [Validation(Required=false)]
                    public List<string> PublicAddress { get; set; }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
