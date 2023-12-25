// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class ModifyDBClusterResponseBody : TeaModel {
        /// <summary>
        /// The information about the cluster.
        /// </summary>
        [NameInMap("DBCluster")]
        [Validation(Required=false)]
        public ModifyDBClusterResponseBodyDBCluster DBCluster { get; set; }
        public class ModifyDBClusterResponseBodyDBCluster : TeaModel {
            /// <summary>
            /// The cluster ID.
            /// </summary>
            [NameInMap("dbClusterId")]
            [Validation(Required=false)]
            public string DbClusterId { get; set; }

            /// <summary>
            /// The order ID.
            /// </summary>
            [NameInMap("orderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
