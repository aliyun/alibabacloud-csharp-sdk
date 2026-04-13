// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstancesResponseBody : TeaModel {
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public DescribeDBInstancesResponseBodyDBInstances DBInstances { get; set; }
        public class DescribeDBInstancesResponseBodyDBInstances : TeaModel {
            [NameInMap("DBInstance")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesResponseBodyDBInstancesDBInstance> DBInstance { get; set; }
            public class DescribeDBInstancesResponseBodyDBInstancesDBInstance : TeaModel {
                [NameInMap("BackupRetentionPolicy")]
                [Validation(Required=false)]
                public int? BackupRetentionPolicy { get; set; }

                [NameInMap("CapacityUnit")]
                [Validation(Required=false)]
                public string CapacityUnit { get; set; }

                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("DBInstanceClass")]
                [Validation(Required=false)]
                public string DBInstanceClass { get; set; }

                [NameInMap("DBInstanceDescription")]
                [Validation(Required=false)]
                public string DBInstanceDescription { get; set; }

                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                [NameInMap("DBInstanceStatus")]
                [Validation(Required=false)]
                public string DBInstanceStatus { get; set; }

                [NameInMap("DBInstanceStorage")]
                [Validation(Required=false)]
                public int? DBInstanceStorage { get; set; }

                [NameInMap("DBInstanceType")]
                [Validation(Required=false)]
                public string DBInstanceType { get; set; }

                [NameInMap("DestroyTime")]
                [Validation(Required=false)]
                public string DestroyTime { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("HiddenZoneId")]
                [Validation(Required=false)]
                public string HiddenZoneId { get; set; }

                [NameInMap("KindCode")]
                [Validation(Required=false)]
                public string KindCode { get; set; }

                [NameInMap("LastDowngradeTime")]
                [Validation(Required=false)]
                public string LastDowngradeTime { get; set; }

                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                [NameInMap("MongosList")]
                [Validation(Required=false)]
                public DescribeDBInstancesResponseBodyDBInstancesDBInstanceMongosList MongosList { get; set; }
                public class DescribeDBInstancesResponseBodyDBInstancesDBInstanceMongosList : TeaModel {
                    [NameInMap("MongosAttribute")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstancesResponseBodyDBInstancesDBInstanceMongosListMongosAttribute> MongosAttribute { get; set; }
                    public class DescribeDBInstancesResponseBodyDBInstancesDBInstanceMongosListMongosAttribute : TeaModel {
                        [NameInMap("NodeClass")]
                        [Validation(Required=false)]
                        public string NodeClass { get; set; }

                        [NameInMap("NodeDescription")]
                        [Validation(Required=false)]
                        public string NodeDescription { get; set; }

                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public string NodeId { get; set; }

                    }

                }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ReleaseTime")]
                [Validation(Required=false)]
                public string ReleaseTime { get; set; }

                [NameInMap("ReplicationFactor")]
                [Validation(Required=false)]
                public string ReplicationFactor { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SecondaryZoneId")]
                [Validation(Required=false)]
                public string SecondaryZoneId { get; set; }

                [NameInMap("ShardList")]
                [Validation(Required=false)]
                public DescribeDBInstancesResponseBodyDBInstancesDBInstanceShardList ShardList { get; set; }
                public class DescribeDBInstancesResponseBodyDBInstancesDBInstanceShardList : TeaModel {
                    [NameInMap("ShardAttribute")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstancesResponseBodyDBInstancesDBInstanceShardListShardAttribute> ShardAttribute { get; set; }
                    public class DescribeDBInstancesResponseBodyDBInstancesDBInstanceShardListShardAttribute : TeaModel {
                        [NameInMap("NodeClass")]
                        [Validation(Required=false)]
                        public string NodeClass { get; set; }

                        [NameInMap("NodeDescription")]
                        [Validation(Required=false)]
                        public string NodeDescription { get; set; }

                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public string NodeId { get; set; }

                        [NameInMap("NodeStorage")]
                        [Validation(Required=false)]
                        public int? NodeStorage { get; set; }

                        [NameInMap("ReadonlyReplicas")]
                        [Validation(Required=false)]
                        public int? ReadonlyReplicas { get; set; }

                    }

                }

                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDBInstancesResponseBodyDBInstancesDBInstanceTags Tags { get; set; }
                public class DescribeDBInstancesResponseBodyDBInstancesDBInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstancesResponseBodyDBInstancesDBInstanceTagsTag> Tag { get; set; }
                    public class DescribeDBInstancesResponseBodyDBInstancesDBInstanceTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("VpcAuthMode")]
                [Validation(Required=false)]
                public string VpcAuthMode { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0E4FE33F-5510-5758-8FA7-A6672CDE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of instances in the query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
