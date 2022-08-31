// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDbProxyInstanceSslRequest : TeaModel {
        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        [NameInMap("DbInstanceId")]
        [Validation(Required=false)]
        public string DbInstanceId { get; set; }

        [NameInMap("DbProxyConnectString")]
        [Validation(Required=false)]
        public string DbProxyConnectString { get; set; }

        [NameInMap("DbProxyEndpointId")]
        [Validation(Required=false)]
        public string DbProxyEndpointId { get; set; }

        [NameInMap("DbProxySslEnabled")]
        [Validation(Required=false)]
        public string DbProxySslEnabled { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
