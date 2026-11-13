// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class CacheCluster : TeaModel {
        /// <summary>
        /// <para>The associated workspaces.</para>
        /// </summary>
        [NameInMap("bindedWorkspaces")]
        [Validation(Required=false)]
        public List<string> BindedWorkspaces { get; set; }

        /// <summary>
        /// <para>The cache cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spc-xxxxxxx</para>
        /// </summary>
        [NameInMap("cacheClusterId")]
        [Validation(Required=false)]
        public string CacheClusterId { get; set; }

        /// <summary>
        /// <para>The cache cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-cache-cluster</para>
        /// </summary>
        [NameInMap("cacheClusterName")]
        [Validation(Required=false)]
        public string CacheClusterName { get; set; }

        /// <summary>
        /// <para>The list of cache sets associated with the cache cluster.</para>
        /// </summary>
        [NameInMap("cachesets")]
        [Validation(Required=false)]
        public List<CacheClusterCachesets> Cachesets { get; set; }
        public class CacheClusterCachesets : TeaModel {
            /// <summary>
            /// <para>The name of the cache set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cache1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The path of the cache set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/path1</para>
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        /// <summary>
        /// <para>The cache cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spc-xxxxxxx</para>
        /// </summary>
        [NameInMap("clusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;cache1&quot;,&quot;path&quot;:&quot;/path1&quot;}]</para>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public string Configuration { get; set; }

        /// <summary>
        /// <para>The list of configuration files for the cache cluster.</para>
        /// </summary>
        [NameInMap("configurations")]
        [Validation(Required=false)]
        public List<CacheClusterConfigurations> Configurations { get; set; }
        public class CacheClusterConfigurations : TeaModel {
            /// <summary>
            /// <para>The content of the configuration file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><cachesets><cacheset><name>cache1</name><path>/path1</path><cacheStrategy>DISTRIBUTED</cacheStrategy><metaPolicy><type>ALWAYS</type></metaPolicy><readPolicy>CACHE_ASIDE</readPolicy><preadPolicy>ALL_DYNAMIC</preadPolicy><writePolicy>WRITE_THROUGH</writePolicy></cacheset></cachesets></para>
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

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Fri May 31 12:18:51 CST 2024</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The creator UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        /// <summary>
        /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1717138731701</para>
        /// </summary>
        [NameInMap("gmtCreated")]
        [Validation(Required=false)]
        public long? GmtCreated { get; set; }

        /// <summary>
        /// <para>The modification time. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1717138731701</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        /// <summary>
        /// <para>The modifier UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        /// <summary>
        /// <para>The cache cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-cache-cluster</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek4f7uj74wdthi</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The cache cluster specifications.</para>
        /// </summary>
        [NameInMap("resourceSpec")]
        [Validation(Required=false)]
        public CacheClusterResourceSpec ResourceSpec { get; set; }
        public class CacheClusterResourceSpec : TeaModel {
            /// <summary>
            /// <para>The bandwidth.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("bandWidth")]
            [Validation(Required=false)]
            public long? BandWidth { get; set; }

            /// <summary>
            /// <para>Specifies whether high availability is enabled.</para>
            /// </summary>
            [NameInMap("ha")]
            [Validation(Required=false)]
            public bool? Ha { get; set; }

            /// <summary>
            /// <para>The physical storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("storage")]
            [Validation(Required=false)]
            public long? Storage { get; set; }

        }

        /// <summary>
        /// <para>The cache cluster status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The list of data tables associated with the cache cluster.</para>
        /// </summary>
        [NameInMap("tables")]
        [Validation(Required=false)]
        public List<CacheClusterTables> Tables { get; set; }
        public class CacheClusterTables : TeaModel {
            /// <summary>
            /// <para>The data catalog ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15097**********</para>
            /// </summary>
            [NameInMap("catalogId")]
            [Validation(Required=false)]
            public string CatalogId { get; set; }

            /// <summary>
            /// <para>The data catalog provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HMS</para>
            /// </summary>
            [NameInMap("catalogProvider")]
            [Validation(Required=false)]
            public string CatalogProvider { get; set; }

            /// <summary>
            /// <para>The database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_db</para>
            /// </summary>
            [NameInMap("database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// <para>The data table name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_table</para>
            /// </summary>
            [NameInMap("table")]
            [Validation(Required=false)]
            public string Table { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>w-d2d82aa09155****</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The list of tags for the cache cluster.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<CacheClusterTags> Tags { get; set; }
        public class CacheClusterTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag_key</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The resource specifications used by the cache cluster.</para>
        /// </summary>
        [NameInMap("usedResourceSpec")]
        [Validation(Required=false)]
        public CacheClusterUsedResourceSpec UsedResourceSpec { get; set; }
        public class CacheClusterUsedResourceSpec : TeaModel {
            /// <summary>
            /// <para>The used bandwidth.</para>
            /// </summary>
            [NameInMap("bandWidth")]
            [Validation(Required=false)]
            public long? BandWidth { get; set; }

            /// <summary>
            /// <para>The used storage capacity.</para>
            /// </summary>
            [NameInMap("storage")]
            [Validation(Required=false)]
            public long? Storage { get; set; }

        }

        /// <summary>
        /// <para>The cache cluster version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2.0</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
