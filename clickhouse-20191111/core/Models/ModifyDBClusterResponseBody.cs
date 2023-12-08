// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class ModifyDBClusterResponseBody : TeaModel {
        [NameInMap("DBCluster")]
        [Validation(Required=false)]
        public ModifyDBClusterResponseBodyDBCluster DBCluster { get; set; }
        public class ModifyDBClusterResponseBodyDBCluster : TeaModel {
            [NameInMap("dbClusterId")]
            [Validation(Required=false)]
            public string DbClusterId { get; set; }

            [NameInMap("orderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
