// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrePaid</b>: subscription</description></item>
        /// <item><description><b>PostPaid</b>: pay-as-you-go</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The endpoint of the node. You can call the <a href="https://help.aliyun.com/document_detail/62010.html">DescribeDBInstanceAttribute</a> operation to query the endpoint of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp1ea17b41abecf43****.mongodb.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionDomain")]
        [Validation(Required=false)]
        public string ConnectionDomain { get; set; }

        /// <summary>
        /// <para>The instance type. For more information about valid values, see <a href="https://help.aliyun.com/document_detail/57141.html">Instance types</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds.mongo.mid</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The name of the instance. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must start with a letter.</description></item>
        /// <item><description>It can contain digits, letters, underscores (_), and hyphens (-).</description></item>
        /// <item><description>It must be 2 to 256 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Test database</para>
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp199659b178****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The state of the instance. For more information about valid values, see <a href="https://help.aliyun.com/document_detail/63870.html">Instance states</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("DBInstanceStatus")]
        [Validation(Required=false)]
        public string DBInstanceStatus { get; set; }

        /// <summary>
        /// <para>The architecture of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sharding</b>: sharded cluster instance</description></item>
        /// <item><description><b>replicate</b>: replica set or standalone instance</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sharding</para>
        /// </summary>
        [NameInMap("DBInstanceType")]
        [Validation(Required=false)]
        public string DBInstanceType { get; set; }

        /// <summary>
        /// <para>The type of the node in the instance. This parameter is used to filter standard or test instance.</para>
        /// <ol>
        /// <item><description>Valid value for a standalone or DBFS instance.</description></item>
        /// <item><description>Valid value for a standard instance that comes in the replica set or sharded cluster architecture: standard</description></item>
        /// <item><description>Valid value when all instances are displayed: default</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("DBNodeType")]
        [Validation(Required=false)]
        public string DBNodeType { get; set; }

        /// <summary>
        /// <para>The database engine of the instance. Set the value to <b>MongoDB</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MongoDB</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The database engine version of the instance.</para>
        /// <list type="bullet">
        /// <item><description><b>6.0</b></description></item>
        /// <item><description><b>5.0</b></description></item>
        /// <item><description><b>4.4</b></description></item>
        /// <item><description><b>4.2</b></description></item>
        /// <item><description><b>4.0</b></description></item>
        /// <item><description><b>3.4</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The time when the instance expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-12-26T16:00Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance has expired. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public string Expired { get; set; }

        /// <summary>
        /// <para>The network type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Classic</b></description></item>
        /// <item><description><b>VPC</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of the page to return. The value of this parameter must be an integer that is greater than 0. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>30</b> (default)</description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of nodes in the replica set instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>3</b></description></item>
        /// <item><description><b>5</b></description></item>
        /// <item><description><b>7</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ReplicationFactor")]
        [Validation(Required=false)]
        public string ReplicationFactor { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmyiu4ekp****</para>
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
        /// <para>The tags of the instance.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDBInstancesRequestTag> Tag { get; set; }
        public class DescribeDBInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the instance. Valid values of N: <b>1</b> to <b>20</b>.</para>
            /// <list type="bullet">
            /// <item><description>The key cannot start with <c>aliyun</c>, <c>acs:</c>, <c>http://</c>, or <c>https://</c>.</description></item>
            /// <item><description>It can be up to 64 characters in length.</description></item>
            /// <item><description>It cannot be an empty string.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>testdatabase</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the instance. Valid values of N: <b>1</b> to <b>20</b>.</para>
            /// <list type="bullet">
            /// <item><description>The value cannot start with <c>aliyun</c>, <c>acs:</c>, <c>http://</c>, or <c>https://</c>.</description></item>
            /// <item><description>The value can be up to 128 characters in length.</description></item>
            /// <item><description>It can be an empty string.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>apitest</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The vSwitch ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1vj604nj5a9zz74****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The VPC ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1n3i15v90el48nx****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the most recent zone list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
