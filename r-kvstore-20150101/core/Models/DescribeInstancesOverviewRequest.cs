// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInstancesOverviewRequest : TeaModel {
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
        /// <para>The engine version of the instance. Valid values: <b>2.8</b>, <b>4.0</b>, <b>5.0</b>, <b>6.0</b>, and <b>7.0</b>.</para>
        /// <para>Valid values:</para>
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
        /// <para>The instance type of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/107984.html">Instance types</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>redis.master.small.default</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The IDs of instances.</para>
        /// <remarks>
        /// <para>By default, all instances that belong to this account are queried. If you specify multiple instance IDs, separate the instance IDs with commas (,).</para>
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
        /// <item><description><b>Unavailable</b>: The instance is unavailable.</description></item>
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
        /// <para>The category of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Tair</b></description></item>
        /// <item><description><b>Redis</b></description></item>
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
        /// <para>The network type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CLASSIC</b>: classic network</description></item>
        /// <item><description><b>VPC</b>: Virtual Private Cloud (VPC)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CLASSIC</para>
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
        /// <para>The private IP address of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.49.***</para>
        /// </summary>
        [NameInMap("PrivateIp")]
        [Validation(Required=false)]
        public string PrivateIp { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the instances you want to query reside. You can call the <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instances you want to query belong.</para>
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
        /// <para>The keyword used for fuzzy search. The keyword can be based on an instance ID or an instance description.</para>
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
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
