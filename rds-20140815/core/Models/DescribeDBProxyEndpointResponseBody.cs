// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBProxyEndpointResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DBProxyEndpointId")]
        [Validation(Required=false)]
        public string DBProxyEndpointId { get; set; }

        [NameInMap("DBProxyConnectString")]
        [Validation(Required=false)]
        public string DBProxyConnectString { get; set; }

        [NameInMap("DBProxyConnectStringPort")]
        [Validation(Required=false)]
        public string DBProxyConnectStringPort { get; set; }

        [NameInMap("DBProxyConnectStringNetType")]
        [Validation(Required=false)]
        public string DBProxyConnectStringNetType { get; set; }

        [NameInMap("DBProxyFeatures")]
        [Validation(Required=false)]
        public string DBProxyFeatures { get; set; }

        [NameInMap("ReadOnlyInstanceMaxDelayTime")]
        [Validation(Required=false)]
        public string ReadOnlyInstanceMaxDelayTime { get; set; }

        [NameInMap("ReadOnlyInstanceDistributionType")]
        [Validation(Required=false)]
        public string ReadOnlyInstanceDistributionType { get; set; }

        [NameInMap("ReadOnlyInstanceWeight")]
        [Validation(Required=false)]
        public string ReadOnlyInstanceWeight { get; set; }

    }

}
