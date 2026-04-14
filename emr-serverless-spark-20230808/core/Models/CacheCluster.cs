// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class CacheCluster : TeaModel {
        [NameInMap("bindedWorkspaces")]
        [Validation(Required=false)]
        public List<string> BindedWorkspaces { get; set; }

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

        [NameInMap("clusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("configuration")]
        [Validation(Required=false)]
        public string Configuration { get; set; }

        [NameInMap("configurations")]
        [Validation(Required=false)]
        public List<CacheClusterConfigurations> Configurations { get; set; }
        public class CacheClusterConfigurations : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cacheset.xml</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("gmtCreated")]
        [Validation(Required=false)]
        public long? GmtCreated { get; set; }

        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        [NameInMap("modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("resourceSpec")]
        [Validation(Required=false)]
        public CacheClusterResourceSpec ResourceSpec { get; set; }
        public class CacheClusterResourceSpec : TeaModel {
            [NameInMap("bandWidth")]
            [Validation(Required=false)]
            public long? BandWidth { get; set; }

            [NameInMap("storage")]
            [Validation(Required=false)]
            public long? Storage { get; set; }

        }

        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("usedResourceSpec")]
        [Validation(Required=false)]
        public CacheClusterUsedResourceSpec UsedResourceSpec { get; set; }
        public class CacheClusterUsedResourceSpec : TeaModel {
            [NameInMap("bandWidth")]
            [Validation(Required=false)]
            public long? BandWidth { get; set; }

            [NameInMap("storage")]
            [Validation(Required=false)]
            public long? Storage { get; set; }

        }

    }

}
