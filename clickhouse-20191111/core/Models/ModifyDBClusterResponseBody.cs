// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class ModifyDBClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the cluster.</para>
        /// </summary>
        [NameInMap("DBCluster")]
        [Validation(Required=false)]
        public ModifyDBClusterResponseBodyDBCluster DBCluster { get; set; }
        public class ModifyDBClusterResponseBodyDBCluster : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc-bp19lo45sy98x****</para>
            /// </summary>
            [NameInMap("dbClusterId")]
            [Validation(Required=false)]
            public string DbClusterId { get; set; }

            /// <summary>
            /// <para>The order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21417210003****</para>
            /// </summary>
            [NameInMap("orderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BA30A000-3A4D-5B97-9420-E5D0D49F7016</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
