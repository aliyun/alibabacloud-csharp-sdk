// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class CacheCluster : TeaModel {
        /// <summary>
        /// <para>An array of workspace IDs that are bound to the cache cluster.</para>
        /// </summary>
        [NameInMap("bindedWorkspaces")]
        [Validation(Required=false)]
        public List<string> BindedWorkspaces { get; set; }

        [NameInMap("cacheClusterId")]
        [Validation(Required=false)]
        public string CacheClusterId { get; set; }

        [NameInMap("cacheClusterName")]
        [Validation(Required=false)]
        public string CacheClusterName { get; set; }

        [NameInMap("cachesets")]
        [Validation(Required=false)]
        public List<CacheClusterCachesets> Cachesets { get; set; }
        public class CacheClusterCachesets : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the cache cluster.</para>
        /// </summary>
        [NameInMap("clusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The configuration of the cache cluster.</para>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public string Configuration { get; set; }

        /// <summary>
        /// <para>An array of configuration objects.</para>
        /// </summary>
        [NameInMap("configurations")]
        [Validation(Required=false)]
        public List<CacheClusterConfigurations> Configurations { get; set; }
        public class CacheClusterConfigurations : TeaModel {
            /// <summary>
            /// <para>The content of the configuration file.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The name of the configuration file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cacheset.xml</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The user who created the cache cluster.</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The creation time of the cache cluster, provided as a UNIX timestamp.</para>
        /// </summary>
        [NameInMap("gmtCreated")]
        [Validation(Required=false)]
        public long? GmtCreated { get; set; }

        /// <summary>
        /// <para>The last modification time of the cache cluster, provided as a UNIX timestamp.</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        /// <summary>
        /// <para>The user who last modified the cache cluster.</para>
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        /// <summary>
        /// <para>The name of the cache cluster.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The billing method for the cache cluster.</para>
        /// </summary>
        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The ID of the region where the cache cluster is located.</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The resource specifications of the cache cluster.</para>
        /// </summary>
        [NameInMap("resourceSpec")]
        [Validation(Required=false)]
        public CacheClusterResourceSpec ResourceSpec { get; set; }
        public class CacheClusterResourceSpec : TeaModel {
            /// <summary>
            /// <para>The bandwidth of the cache cluster.</para>
            /// </summary>
            [NameInMap("bandWidth")]
            [Validation(Required=false)]
            public long? BandWidth { get; set; }

            [NameInMap("ha")]
            [Validation(Required=false)]
            public bool? Ha { get; set; }

            /// <summary>
            /// <para>The storage capacity of the cache cluster.</para>
            /// </summary>
            [NameInMap("storage")]
            [Validation(Required=false)]
            public long? Storage { get; set; }

        }

        /// <summary>
        /// <para>The current state of the cache cluster.</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("tables")]
        [Validation(Required=false)]
        public List<CacheClusterTables> Tables { get; set; }
        public class CacheClusterTables : TeaModel {
            [NameInMap("catalogId")]
            [Validation(Required=false)]
            public string CatalogId { get; set; }

            [NameInMap("catalogProvider")]
            [Validation(Required=false)]
            public string CatalogProvider { get; set; }

            [NameInMap("database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            [NameInMap("table")]
            [Validation(Required=false)]
            public string Table { get; set; }

            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<CacheClusterTags> Tags { get; set; }
        public class CacheClusterTags : TeaModel {
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The resource specifications currently in use by the cache cluster.</para>
        /// </summary>
        [NameInMap("usedResourceSpec")]
        [Validation(Required=false)]
        public CacheClusterUsedResourceSpec UsedResourceSpec { get; set; }
        public class CacheClusterUsedResourceSpec : TeaModel {
            /// <summary>
            /// <para>The amount of bandwidth consumed by the cache cluster.</para>
            /// </summary>
            [NameInMap("bandWidth")]
            [Validation(Required=false)]
            public long? BandWidth { get; set; }

            /// <summary>
            /// <para>The amount of storage capacity consumed by the cache cluster.</para>
            /// </summary>
            [NameInMap("storage")]
            [Validation(Required=false)]
            public long? Storage { get; set; }

        }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
