// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBProxyEndpointResponseBody : TeaModel {
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

        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        [NameInMap("DBProxyFeatures")]
        [Validation(Required=false)]
        public string DBProxyFeatures { get; set; }

        [NameInMap("DbProxyEndpointAliases")]
        [Validation(Required=false)]
        public string DbProxyEndpointAliases { get; set; }

        [NameInMap("DbProxyEndpointReadWriteMode")]
        [Validation(Required=false)]
        public string DbProxyEndpointReadWriteMode { get; set; }

        [NameInMap("EndpointConnectItems")]
        [Validation(Required=false)]
        public DescribeDBProxyEndpointResponseBodyEndpointConnectItems EndpointConnectItems { get; set; }
        public class DescribeDBProxyEndpointResponseBodyEndpointConnectItems : TeaModel {
            [NameInMap("EndpointConnectItems")]
            [Validation(Required=false)]
            public List<DescribeDBProxyEndpointResponseBodyEndpointConnectItemsEndpointConnectItems> EndpointConnectItems { get; set; }
            public class DescribeDBProxyEndpointResponseBodyEndpointConnectItemsEndpointConnectItems : TeaModel {
                public string DbProxyEndpointConnectString { get; set; }
                public string DbProxyEndpointNetType { get; set; }
                public string DbProxyEndpointPort { get; set; }
            }
        };

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
