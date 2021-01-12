// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBProxyEndpointAddressRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("DBProxyEndpointId")]
        [Validation(Required=false)]
        public string DBProxyEndpointId { get; set; }

        [NameInMap("DBProxyNewConnectString")]
        [Validation(Required=false)]
        public string DBProxyNewConnectString { get; set; }

        [NameInMap("DBProxyNewConnectStringPort")]
        [Validation(Required=false)]
        public string DBProxyNewConnectStringPort { get; set; }

        [NameInMap("DBProxyConnectStringNetType")]
        [Validation(Required=false)]
        public string DBProxyConnectStringNetType { get; set; }

    }

}
