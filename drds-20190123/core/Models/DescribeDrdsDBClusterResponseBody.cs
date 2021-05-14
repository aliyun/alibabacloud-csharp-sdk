// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsDBClusterResponseBody : TeaModel {
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DbInstance")]
        [Validation(Required=false)]
        public DescribeDrdsDBClusterResponseBodyDbInstance DbInstance { get; set; }
        public class DescribeDrdsDBClusterResponseBodyDbInstance : TeaModel {
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }
            [NameInMap("DBInstanceStatus")]
            [Validation(Required=false)]
            public string DBInstanceStatus { get; set; }
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }
            [NameInMap("RdsInstType")]
            [Validation(Required=false)]
            public string RdsInstType { get; set; }
            [NameInMap("RemainDays")]
            [Validation(Required=false)]
            public string RemainDays { get; set; }
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }
            [NameInMap("DbInstType")]
            [Validation(Required=false)]
            public string DbInstType { get; set; }
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }
            [NameInMap("ReadMode")]
            [Validation(Required=false)]
            public string ReadMode { get; set; }
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public DescribeDrdsDBClusterResponseBodyDbInstanceEndpoints Endpoints { get; set; }
            public class DescribeDrdsDBClusterResponseBodyDbInstanceEndpoints : TeaModel {
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public List<DescribeDrdsDBClusterResponseBodyDbInstanceEndpointsEndpoint> Endpoint { get; set; }
                public class DescribeDrdsDBClusterResponseBodyDbInstanceEndpointsEndpoint : TeaModel {
                    [NameInMap("ReadWeight")]
                    [Validation(Required=false)]
                    public int? ReadWeight { get; set; }

                    [NameInMap("EndpointId")]
                    [Validation(Required=false)]
                    public string EndpointId { get; set; }

                    [NameInMap("NodeIds")]
                    [Validation(Required=false)]
                    public string NodeIds { get; set; }

                }

            }
            [NameInMap("DBNodes")]
            [Validation(Required=false)]
            public DescribeDrdsDBClusterResponseBodyDbInstanceDBNodes DBNodes { get; set; }
            public class DescribeDrdsDBClusterResponseBodyDbInstanceDBNodes : TeaModel {
                [NameInMap("DBNode")]
                [Validation(Required=false)]
                public List<DescribeDrdsDBClusterResponseBodyDbInstanceDBNodesDBNode> DBNode { get; set; }
                public class DescribeDrdsDBClusterResponseBodyDbInstanceDBNodesDBNode : TeaModel {
                    [NameInMap("DBNodeRole")]
                    [Validation(Required=false)]
                    public string DBNodeRole { get; set; }

                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                    [NameInMap("DBNodeId")]
                    [Validation(Required=false)]
                    public string DBNodeId { get; set; }

                    [NameInMap("DBNodeStatus")]
                    [Validation(Required=false)]
                    public string DBNodeStatus { get; set; }

                }

            }
        };

    }

}
