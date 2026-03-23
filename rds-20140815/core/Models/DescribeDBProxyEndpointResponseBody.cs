// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBProxyEndpointResponseBody : TeaModel {
        [NameInMap("CausalConsistReadTimeout")]
        [Validation(Required=false)]
        public string CausalConsistReadTimeout { get; set; }

        [NameInMap("DBProxyConnectString")]
        [Validation(Required=false)]
        public string DBProxyConnectString { get; set; }

        [NameInMap("DBProxyConnectStringNetType")]
        [Validation(Required=false)]
        public string DBProxyConnectStringNetType { get; set; }

        [NameInMap("DBProxyConnectStringPort")]
        [Validation(Required=false)]
        public string DBProxyConnectStringPort { get; set; }

        [NameInMap("DBProxyEndpointId")]
        [Validation(Required=false)]
        public string DBProxyEndpointId { get; set; }

        [NameInMap("DBProxyEndpointMinSlaveCount")]
        [Validation(Required=false)]
        public string DBProxyEndpointMinSlaveCount { get; set; }

        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        [NameInMap("DBProxyFeatures")]
        [Validation(Required=false)]
        public string DBProxyFeatures { get; set; }

        [NameInMap("DBProxyNodes")]
        [Validation(Required=false)]
        public DescribeDBProxyEndpointResponseBodyDBProxyNodes DBProxyNodes { get; set; }
        public class DescribeDBProxyEndpointResponseBodyDBProxyNodes : TeaModel {
            [NameInMap("DBProxyNodes")]
            [Validation(Required=false)]
            public List<DescribeDBProxyEndpointResponseBodyDBProxyNodesDBProxyNodes> DBProxyNodes { get; set; }
            public class DescribeDBProxyEndpointResponseBodyDBProxyNodesDBProxyNodes : TeaModel {
                [NameInMap("cpuCores")]
                [Validation(Required=false)]
                public string CpuCores { get; set; }

                [NameInMap("nodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("zoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("DbProxyEndpointAliases")]
        [Validation(Required=false)]
        public string DbProxyEndpointAliases { get; set; }

        [NameInMap("DbProxyEndpointReadWriteMode")]
        [Validation(Required=false)]
        public string DbProxyEndpointReadWriteMode { get; set; }

        [NameInMap("DbProxyEndpointVpcId")]
        [Validation(Required=false)]
        public string DbProxyEndpointVpcId { get; set; }

        [NameInMap("DbProxyEndpointVswitchId")]
        [Validation(Required=false)]
        public string DbProxyEndpointVswitchId { get; set; }

        [NameInMap("DbProxyEndpointZoneId")]
        [Validation(Required=false)]
        public string DbProxyEndpointZoneId { get; set; }

        [NameInMap("EndpointConnectItems")]
        [Validation(Required=false)]
        public DescribeDBProxyEndpointResponseBodyEndpointConnectItems EndpointConnectItems { get; set; }
        public class DescribeDBProxyEndpointResponseBodyEndpointConnectItems : TeaModel {
            [NameInMap("EndpointConnectItems")]
            [Validation(Required=false)]
            public List<DescribeDBProxyEndpointResponseBodyEndpointConnectItemsEndpointConnectItems> EndpointConnectItems { get; set; }
            public class DescribeDBProxyEndpointResponseBodyEndpointConnectItemsEndpointConnectItems : TeaModel {
                [NameInMap("DbProxyEndpointConnectString")]
                [Validation(Required=false)]
                public string DbProxyEndpointConnectString { get; set; }

                [NameInMap("DbProxyEndpointNetType")]
                [Validation(Required=false)]
                public string DbProxyEndpointNetType { get; set; }

                [NameInMap("DbProxyEndpointPort")]
                [Validation(Required=false)]
                public string DbProxyEndpointPort { get; set; }

            }

        }

        [NameInMap("ReadOnlyInstanceDistributionType")]
        [Validation(Required=false)]
        public string ReadOnlyInstanceDistributionType { get; set; }

        [NameInMap("ReadOnlyInstanceMaxDelayTime")]
        [Validation(Required=false)]
        public string ReadOnlyInstanceMaxDelayTime { get; set; }

        [NameInMap("ReadOnlyInstanceWeight")]
        [Validation(Required=false)]
        public string ReadOnlyInstanceWeight { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
