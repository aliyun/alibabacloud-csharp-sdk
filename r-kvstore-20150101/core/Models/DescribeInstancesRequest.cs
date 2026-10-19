// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The architecture type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cluster</b>: cluster edition</description></item>
        /// <item><description><b>standard</b>: standard edition</description></item>
        /// <item><description><b>rwsplit</b>: read/write splitting edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("ArchitectureType")]
        [Validation(Required=false)]
        public string ArchitectureType { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
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
        /// <para>The edition type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Community</b>: open-source Redis</description></item>
        /// <item><description><b>Enterprise</b>: Tair Enterprise Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enterprise</para>
        /// </summary>
        [NameInMap("EditionType")]
        [Validation(Required=false)]
        public string EditionType { get; set; }

        /// <summary>
        /// <para>The Redis-compatible engine version of the instance. Valid values: <b>2.8</b>, <b>4.0</b>, <b>5.0</b>, <b>6.0</b>, and <b>7.0</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The expiration status of the instance. Valid values:</para>
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
        /// <para>Specifies whether to filter child instances of distributed instances in the returned instance list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Only child instance information is returned.</description></item>
        /// <item><description><b>false</b>: Child instance information is not returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("GlobalInstance")]
        [Validation(Required=false)]
        public bool? GlobalInstance { get; set; }

        /// <summary>
        /// <para>The instance specifications. For more information, see <a href="https://help.aliyun.com/document_detail/107984.html">Instance specifications</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>redis.master.small.default</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The IDs of the instances to be queried.</para>
        /// <remarks>
        /// <para>To specify multiple instance IDs, separate the IDs with commas (,). You can specify up to 30 instance IDs in a single request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The status of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: normal</description></item>
        /// <item><description><b>Creating</b>: creating</description></item>
        /// <item><description><b>Changing</b>: changing</description></item>
        /// <item><description><b>Inactive</b>: disabled</description></item>
        /// <item><description><b>Flushing</b>: purge in progress</description></item>
        /// <item><description><b>Released</b>: released</description></item>
        /// <item><description><b>Transforming</b>: transforming</description></item>
        /// <item><description><b>Migrating</b>: migrating</description></item>
        /// <item><description><b>BackupRecovering</b>: recovering from backup</description></item>
        /// <item><description><b>MinorVersionUpgrading</b>: minor version upgrade in progress</description></item>
        /// <item><description><b>NetworkModifying</b>: changing the network type</description></item>
        /// <item><description><b>SSLModifying</b>: changing SSL configurations</description></item>
        /// <item><description><b>MajorVersionUpgrading</b>: major engine version upgrade in progress, during which the instance remains accessible</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about instance statuses, see <a href="https://help.aliyun.com/document_detail/200740.html">Instance statuses and impacts</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <para>The instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Tair</b>: Tair (Enterprise Edition)</description></item>
        /// <item><description><b>Redis</b>: open-source Redis</description></item>
        /// <item><description><b>Memcache</b>: Memcache</description></item>
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
        /// <item><description><b>CLASSIC</b>: classic network</description></item>
        /// <item><description><b>VPC</b>: VPC</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CLASSIC</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The node type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MASTER_SLAVE</b>: high-availability (dual-replica)</description></item>
        /// <item><description><b>STAND_ALONE</b>: single-replica</description></item>
        /// <item><description><b>double</b>: dual-replica</description></item>
        /// <item><description><b>single</b>: single-replica<remarks>
        /// <para>For cloud-native instances, select <b>MASTER_SLAVE</b> or <b>STAND_ALONE</b>. For classic instances, select <b>double</b> or <b>single</b>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MASTER_SLAVE</para>
        /// </summary>
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
        /// <para>The page number of the instance list. Pages start from <b>1</b>. Default value: <b>1</b>.</para>
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
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The private IP address in the VPC.</para>
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
        /// <para>When you call this operation, if the <b>Tag</b> parameter is specified, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation or use the console to obtain the list of resource group IDs. For related operations, see <a href="https://help.aliyun.com/document_detail/151181.html">View the basic information of a resource group</a>.</para>
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
        /// <para>The search keyword. Fuzzy match is supported for instance names and instance IDs.</para>
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
        /// <para>The tag information of the instance.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInstancesRequestTag> Tag { get; set; }
        public class DescribeInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. It forms a key-value pair with the tag value.</para>
            /// <remarks>
            /// <para>You can specify up to 5 tag key-value pairs in a single request.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Storage type</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. It forms a key-value pair with the tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Development</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1e7clcw529l773d****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1nme44gek34slfc****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hongkong-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
