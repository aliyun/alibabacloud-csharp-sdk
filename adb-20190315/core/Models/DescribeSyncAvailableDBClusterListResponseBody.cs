// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSyncAvailableDBClusterListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FBD1DD96-AD1D-516C-9D9A-60BA081F66EE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queried instances or clusters.</para>
        /// </summary>
        [NameInMap("SyncAvailableDBClusters")]
        [Validation(Required=false)]
        public List<DescribeSyncAvailableDBClusterListResponseBodySyncAvailableDBClusters> SyncAvailableDBClusters { get; set; }
        public class DescribeSyncAvailableDBClusterListResponseBodySyncAvailableDBClusters : TeaModel {
            /// <summary>
            /// <para>The description of the instance or cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DB1</para>
            /// </summary>
            [NameInMap("DBClusterDescription")]
            [Validation(Required=false)]
            public string DBClusterDescription { get; set; }

            /// <summary>
            /// <para>The instance or cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp1l3yh04y7us147n</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The database type of the instance or cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds</para>
            /// </summary>
            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }

            /// <summary>
            /// <para>The storage size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("StorageSize")]
            [Validation(Required=false)]
            public float? StorageSize { get; set; }

            /// <summary>
            /// <para>The number of tables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TableNumber")]
            [Validation(Required=false)]
            public int? TableNumber { get; set; }

        }

    }

}
