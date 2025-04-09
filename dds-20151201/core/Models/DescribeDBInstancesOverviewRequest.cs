// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstancesOverviewRequest : TeaModel {
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
        /// <para>The database engine version of the instance. Valid values: <b>5.0</b>, <b>4.4</b>, <b>4.2</b>, <b>4.0</b>, and <b>3.4</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The instance type. The instance type varies based on the instance architecture. For more information about instance types supported by different instance architectures, see the following references:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/311407.html">Standalone instance types</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/311410.html">Replica set instance types</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dds.mongo.2xlarge</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The ID of the instance for which you want to query the overview information.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify this parameter, the overview information of all instances within this account is queried.</para>
        /// </description></item>
        /// <item><description><para>Separate the instance IDs with commas (,).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp12c5b040dc****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The state of the instance. For more information about valid values, see <a href="https://help.aliyun.com/document_detail/63870.html">Instance states</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <para>The architecture of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sharding</b>: sharded cluster instance</description></item>
        /// <item><description><b>replicate</b>: replica set or standalone instance</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>To query the overview information of a sharded cluster instance, you must set the parameter to <b>sharding</b>.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify this parameter, the overview information of all instances within this account is queried.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>replicate</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The network type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Classic</b>: classic network</description></item>
        /// <item><description><b>VPC</b>: Virtual Private Cloud (VPC)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Classic</para>
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
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs. For more information, see <a href="https://help.aliyun.com/document_detail/151181.html">View the basic information of a resource group</a>.</para>
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
        /// <para>Specifies whether to display instance tags. Default value: False.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ShowTags")]
        [Validation(Required=false)]
        public bool? ShowTags { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which the instance is connected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1e7clcw529l773d****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC in which the instance is deployed.</para>
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
