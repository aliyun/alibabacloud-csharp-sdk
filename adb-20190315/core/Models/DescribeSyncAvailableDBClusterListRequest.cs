// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSyncAvailableDBClusterListRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The query type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Target</description></item>
        /// <item><description>Source</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Source</para>
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-4690g37929****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The source instances or clusters.</para>
        /// </summary>
        [NameInMap("SourceDBCluster")]
        [Validation(Required=false)]
        public List<DescribeSyncAvailableDBClusterListRequestSourceDBCluster> SourceDBCluster { get; set; }
        public class DescribeSyncAvailableDBClusterListRequestSourceDBCluster : TeaModel {
            /// <summary>
            /// <para>The ID of the source instance or cluster. Separate multiple IDs with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp1l3yh04y7us147n</para>
            /// </summary>
            [NameInMap("ClusterIds")]
            [Validation(Required=false)]
            public string ClusterIds { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The database type of the source instance or cluster.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>rds: ApsaraDB RDS.</description></item>
            /// <item><description>sls: Simple Log Service.</description></item>
            /// <item><description>polardb: PolarDB.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>rds</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The synchronization platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADB-CDC</para>
        /// </summary>
        [NameInMap("SyncPlatform")]
        [Validation(Required=false)]
        public string SyncPlatform { get; set; }

    }

}
