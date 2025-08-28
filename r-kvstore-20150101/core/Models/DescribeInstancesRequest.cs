// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The architecture of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cluster</b>: cluster architecture</description></item>
        /// <item><description><b>standard</b>: standard architecture</description></item>
        /// <item><description><b>rwsplit</b>: read/write splitting architecture</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("ArchitectureType")]
        [Validation(Required=false)]
        public string ArchitectureType { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrePaid</b>: subscription</description></item>
        /// <item><description><b>PostPaid</b>: pay-as-you-go</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The edition of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Community</b>: Redis Open-Source Edition</description></item>
        /// <item><description><b>Enterprise</b>: Tair (Enterprise Edition)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enterprise</para>
        /// </summary>
        [NameInMap("EditionType")]
        [Validation(Required=false)]
        public string EditionType { get; set; }

        /// <summary>
        /// <para>The database engine version of the instance. Valid values: <b>2.8</b>, <b>4.0</b>, <b>5.0</b>, <b>6.0</b>, and <b>7.0</b>.</para>
        /// <para>Enumerated values:</para>
        /// <list type="bullet">
        /// <item><description>1.0</description></item>
        /// <item><description>2.8</description></item>
        /// <item><description>4.0</description></item>
        /// <item><description>5.0</description></item>
        /// <item><description>6.0</description></item>
        /// <item><description>7.0</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance has expired. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The instance has expired.</description></item>
        /// <item><description><b>false</b>: The instance has not expired.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public string Expired { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the child instances of distributed instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Only child instances are returned.</description></item>
        /// <item><description><b>false</b>: Child instances are not returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("GlobalInstance")]
        [Validation(Required=false)]
        public bool? GlobalInstance { get; set; }

        /// <summary>
        /// <para>The instance type of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/107984.html">Instance types</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>redis.master.small.default</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The IDs of the instances that you want to query.</para>
        /// <remarks>
        /// <para> If you want to specify multiple instance IDs, separate the instance IDs with commas (,). You can specify a maximum of 30 instance IDs in a single request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The state of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: The instance is normal.</description></item>
        /// <item><description><b>Creating</b>: The instance is being created.</description></item>
        /// <item><description><b>Changing</b>: The configurations of the instance are being changed.</description></item>
        /// <item><description><b>Inactive</b>: The instance is disabled.</description></item>
        /// <item><description><b>Flushing</b>: The instance is being released.</description></item>
        /// <item><description><b>Released</b>: The instance is released.</description></item>
        /// <item><description><b>Transforming</b>: The billing method of the instance is being changed.</description></item>
        /// <item><description><b>Unavailable</b>: The instance is suspended.</description></item>
        /// <item><description><b>Error</b>: The instance failed to be created.</description></item>
        /// <item><description><b>Migrating</b>: The instance is being migrated.</description></item>
        /// <item><description><b>BackupRecovering</b>: The instance is being restored from a backup.</description></item>
        /// <item><description><b>MinorVersionUpgrading</b>: The minor version of the instance is being updated.</description></item>
        /// <item><description><b>NetworkModifying</b>: The network type of the instance is being changed.</description></item>
        /// <item><description><b>SSLModifying</b>: The SSL certificate of the instance is being changed.</description></item>
        /// <item><description><b>MajorVersionUpgrading</b>: The major version of the instance is being upgraded. The instance remains accessible during the upgrade.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about instance states, see <a href="https://help.aliyun.com/document_detail/200740.html">Instance states and impacts</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <para>The database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Tair</b>: Tair (Enterprise Edition)</description></item>
        /// <item><description><b>Redis</b>: Redis Open-Source Edition</description></item>
        /// <item><description><b>Memcache</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Redis</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The network type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CLASSIC</b></description></item>
        /// <item><description><b>VPC</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CLASSIC</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page <b>1</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: <b>50</b>. Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The private IP address of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.49.***</para>
        /// </summary>
        [NameInMap("PrivateIp")]
        [Validation(Required=false)]
        public string PrivateIp { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <remarks>
        /// <para>When you call this operation and specify the <b>Tag</b> parameter, you must also specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// <remarks>
        /// <para>You can query resource group IDs by using the Tair (Redis OSS-compatible) console or by calling the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation. For more information, see <a href="https://help.aliyun.com/document_detail/151181.html">View basic information of a resource group</a>.</para>
        /// </remarks>
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
        /// <para>The keyword used for fuzzy search. The keyword can be based on an instance name or an instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apitest</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The tags of the instance.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInstancesRequestTag> Tag { get; set; }
        public class DescribeInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. A tag is a key-value pair.</para>
            /// <remarks>
            /// <para> A maximum of five key-value pairs can be specified at a time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Storage type</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Local disk</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1e7clcw529l773d****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1nme44gek34slfc****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hongkong-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
