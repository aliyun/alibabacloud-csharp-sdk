// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class ModifySyncJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Warehouse Edition cluster.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the IDs of all AnalyticDB for MySQL Data Warehouse Edition clusters within a region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp12bh6z59nh8497f</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The source instances or clusters.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("SourceDBCluster")]
        [Validation(Required=false)]
        public List<ModifySyncJobRequestSourceDBCluster> SourceDBCluster { get; set; }
        public class ModifySyncJobRequestSourceDBCluster : TeaModel {
            /// <summary>
            /// <para>The ID of the source instance or cluster. Separate multiple IDs with commas (,).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-2zepqn129i9s3l2z3,rm-2zea4dj583129ksp6</para>
            /// </summary>
            [NameInMap("ClusterIds")]
            [Validation(Required=false)]
            public string ClusterIds { get; set; }

            /// <summary>
            /// <para>The ID of the synchronization job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dts-xxxxxx</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The operation type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Create</description></item>
            /// <item><description>Modify</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Create</para>
            /// </summary>
            [NameInMap("OperateType")]
            [Validation(Required=false)]
            public string OperateType { get; set; }

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
            /// <para>The source database type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>rds: ApsaraDB RDS.</description></item>
            /// <item><description>sls: Simple Log Service.</description></item>
            /// <item><description>polardb: PolarDB.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sls</para>
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
