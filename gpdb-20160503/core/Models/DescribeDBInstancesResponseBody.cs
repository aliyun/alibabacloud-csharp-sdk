// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried instances.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstancesResponseBodyItems Items { get; set; }
        public class DescribeDBInstancesResponseBodyItems : TeaModel {
            [NameInMap("DBInstance")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesResponseBodyItemsDBInstance> DBInstance { get; set; }
            public class DescribeDBInstancesResponseBodyItemsDBInstance : TeaModel {
                /// <summary>
                /// <para>An invalid parameter. It is no longer returned when you call this operation.</para>
                /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86910.html">DescribeDBInstanceAttribute</a> operation to query the access mode of an instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("ConnectionMode")]
                [Validation(Required=false)]
                public string ConnectionMode { get; set; }

                /// <summary>
                /// <para>The time when the instance was created. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-10-09T04:54:08Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The edition of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Basic</b>: Basic Edition.</description></item>
                /// <item><description><b>HighAvailability</b>: High-availability Edition.</description></item>
                /// <item><description><b>Finance</b>: Enterprise Edition.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HighAvailability</para>
                /// </summary>
                [NameInMap("DBInstanceCategory")]
                [Validation(Required=false)]
                public string DBInstanceCategory { get; set; }

                /// <summary>
                /// <para>The description of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gp-bp12ga6v69h86****</para>
                /// </summary>
                [NameInMap("DBInstanceDescription")]
                [Validation(Required=false)]
                public string DBInstanceDescription { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gp-bp12ga6v69h86****</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>The resource type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Serverless</b>: Serverless mode.</description></item>
                /// <item><description><b>StorageElastic</b>: elastic storage mode.</description></item>
                /// <item><description><b>Classic</b>: reserved storage mode.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>StorageElastic</para>
                /// </summary>
                [NameInMap("DBInstanceMode")]
                [Validation(Required=false)]
                public string DBInstanceMode { get; set; }

                /// <summary>
                /// <para>The type of the network interface card (NIC) that is used by the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Internet.</description></item>
                /// <item><description><b>1</b>: internal network.</description></item>
                /// <item><description><b>2</b>: VPC.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("DBInstanceNetType")]
                [Validation(Required=false)]
                public string DBInstanceNetType { get; set; }

                /// <summary>
                /// <para>The status of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/86944.html">Instance statuses</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("DBInstanceStatus")]
                [Validation(Required=false)]
                public string DBInstanceStatus { get; set; }

                /// <summary>
                /// <para>The database engine of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gpdb</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The database engine version of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6.0</para>
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// <para>The expiration time of the instance. The time is displayed in UTC.</para>
                /// <remarks>
                /// <para> The expiration time of a pay-as-you-go instance is <c>2999-09-08T16:00:00Z</c>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2999-09-08T16:00:00Z</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>The resource type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>cluster</b>: Serverless mode or elastic storage mode.</description></item>
                /// <item><description><b>replicaSet</b>: reserved storage mode.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cluster</para>
                /// </summary>
                [NameInMap("InstanceDeployType")]
                [Validation(Required=false)]
                public string InstanceDeployType { get; set; }

                /// <summary>
                /// <para>The network type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Classic</b>: classic network.</description></item>
                /// <item><description><b>VPC</b>: VPC.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("InstanceNetworkType")]
                [Validation(Required=false)]
                public string InstanceNetworkType { get; set; }

                /// <summary>
                /// <para>The lock mode of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Unlock</b>: The instance is not locked.</description></item>
                /// <item><description><b>ManualLock</b>: The instance is manually locked.</description></item>
                /// <item><description><b>LockByExpiration</b>: The instance is automatically locked due to instance expiration.</description></item>
                /// <item><description><b>LockByRestoration</b>: The instance is automatically locked due to instance restoration.</description></item>
                /// <item><description><b>LockByDiskQuota</b>: The instance is automatically locked due to exhausted storage.</description></item>
                /// <item><description><b>LockReadInstanceByDiskQuota</b>: The instance is a read-only instance and is automatically locked when the disk space is full.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Unlock</para>
                /// </summary>
                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                /// <summary>
                /// <para>The reason why the instance is locked. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The instance is not locked.</description></item>
                /// <item><description><b>1</b>: The instance is manually locked.</description></item>
                /// <item><description><b>2</b>: The instance is automatically locked due to instance expiration.</description></item>
                /// <item><description><b>3</b>: The instance is automatically locked due to instance restoration.</description></item>
                /// <item><description><b>4</b>: The instance is automatically locked due to exhausted storage.</description></item>
                /// </list>
                /// <remarks>
                /// <para> If the instance is in reserved storage mode and is not locked, null is returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// <para>The number of coordinator nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MasterNodeNum")]
                [Validation(Required=false)]
                public int? MasterNodeNum { get; set; }

                /// <summary>
                /// <para>The billing method of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
                /// <item><description><b>Prepaid</b>: subscription.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Postpaid</para>
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// <para>product type</para>
                /// 
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("ProdType")]
                [Validation(Required=false)]
                public string ProdType { get; set; }

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
                /// <para>The ID of the resource group to which the instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The number of compute nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("SegNodeNum")]
                [Validation(Required=false)]
                public string SegNodeNum { get; set; }

                /// <summary>
                /// <para>The type of the Serverless mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Manual</b>: manual scheduling.</description></item>
                /// <item><description><b>Auto</b>: automatic scheduling.</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is returned only for instances in Serverless mode.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Manual</para>
                /// </summary>
                [NameInMap("ServerlessMode")]
                [Validation(Required=false)]
                public string ServerlessMode { get; set; }

                /// <summary>
                /// <para>The storage capacity of the instance. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("StorageSize")]
                [Validation(Required=false)]
                public string StorageSize { get; set; }

                /// <summary>
                /// <para>The storage type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>cloud_essd</b>: enhanced SSD (ESSD).</description></item>
                /// <item><description><b>cloud_efficiency</b>: ultra disk.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_essd</para>
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// <para>The tags that are added to the instance.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDBInstancesResponseBodyItemsDBInstanceTags Tags { get; set; }
                public class DescribeDBInstancesResponseBodyItemsDBInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstancesResponseBodyItemsDBInstanceTagsTag> Tag { get; set; }
                    public class DescribeDBInstancesResponseBodyItemsDBInstanceTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The key of tag N.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test-key</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of tag N.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test-value</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1cpq8mr64paltkb****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The VPC ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp19ame5m1r3oejns****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h</para>
                /// </summary>
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
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53EA07B7-FC2A-521B-AB7C-27**********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
