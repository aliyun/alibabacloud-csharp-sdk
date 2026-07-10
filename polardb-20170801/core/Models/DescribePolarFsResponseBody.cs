// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarFsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribePolarFsResponseBodyItems Items { get; set; }
        public class DescribePolarFsResponseBodyItems : TeaModel {
            [NameInMap("PolarFsPaths")]
            [Validation(Required=false)]
            public List<DescribePolarFsResponseBodyItemsPolarFsPaths> PolarFsPaths { get; set; }
            public class DescribePolarFsResponseBodyItemsPolarFsPaths : TeaModel {
                [NameInMap("AccelerateType")]
                [Validation(Required=false)]
                public string AccelerateType { get; set; }

                [NameInMap("AcceleratedStorageSpace")]
                [Validation(Required=false)]
                public string AcceleratedStorageSpace { get; set; }

                [NameInMap("AcceleratingEnable")]
                [Validation(Required=false)]
                public string AcceleratingEnable { get; set; }

                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("Expired")]
                [Validation(Required=false)]
                public string Expired { get; set; }

                [NameInMap("MountInfo")]
                [Validation(Required=false)]
                public DescribePolarFsResponseBodyItemsPolarFsPathsMountInfo MountInfo { get; set; }
                public class DescribePolarFsResponseBodyItemsPolarFsPathsMountInfo : TeaModel {
                    [NameInMap("PolarDbProxy")]
                    [Validation(Required=false)]
                    public string PolarDbProxy { get; set; }

                    [NameInMap("PolarFsCluster")]
                    [Validation(Required=false)]
                    public string PolarFsCluster { get; set; }

                    [NameInMap("Token")]
                    [Validation(Required=false)]
                    public string Token { get; set; }

                }

                [NameInMap("MountedAIDBClusters")]
                [Validation(Required=false)]
                public DescribePolarFsResponseBodyItemsPolarFsPathsMountedAIDBClusters MountedAIDBClusters { get; set; }
                public class DescribePolarFsResponseBodyItemsPolarFsPathsMountedAIDBClusters : TeaModel {
                    [NameInMap("MountedAIDBClusters")]
                    [Validation(Required=false)]
                    public List<DescribePolarFsResponseBodyItemsPolarFsPathsMountedAIDBClustersMountedAIDBClusters> MountedAIDBClusters { get; set; }
                    public class DescribePolarFsResponseBodyItemsPolarFsPathsMountedAIDBClustersMountedAIDBClusters : TeaModel {
                        [NameInMap("DBClusterId")]
                        [Validation(Required=false)]
                        public string DBClusterId { get; set; }

                        [NameInMap("MountDir")]
                        [Validation(Required=false)]
                        public string MountDir { get; set; }

                        [NameInMap("MountStatus")]
                        [Validation(Required=false)]
                        public string MountStatus { get; set; }

                        [NameInMap("MountedTime")]
                        [Validation(Required=false)]
                        public string MountedTime { get; set; }

                    }

                }

                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                [NameInMap("PolarFsInstanceDescription")]
                [Validation(Required=false)]
                public string PolarFsInstanceDescription { get; set; }

                [NameInMap("PolarFsInstanceId")]
                [Validation(Required=false)]
                public string PolarFsInstanceId { get; set; }

                [NameInMap("PolarFsPath")]
                [Validation(Required=false)]
                public string PolarFsPath { get; set; }

                [NameInMap("PolarFsStatus")]
                [Validation(Required=false)]
                public string PolarFsStatus { get; set; }

                [NameInMap("PolarFsType")]
                [Validation(Required=false)]
                public string PolarFsType { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("RelativeDbClusterId")]
                [Validation(Required=false)]
                public string RelativeDbClusterId { get; set; }

                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                [NameInMap("StorageSpace")]
                [Validation(Required=false)]
                public long? StorageSpace { get; set; }

                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribePolarFsResponseBodyItemsPolarFsPathsTags Tags { get; set; }
                public class DescribePolarFsResponseBodyItemsPolarFsPathsTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribePolarFsResponseBodyItemsPolarFsPathsTagsTag> Tag { get; set; }
                    public class DescribePolarFsResponseBodyItemsPolarFsPathsTagsTag : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>testKey</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>testValue</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>8CD1852F-8176-55E4-891C-4478DC00CC7A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
