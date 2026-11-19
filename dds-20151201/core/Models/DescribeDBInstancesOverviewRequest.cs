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
        /// <item><description><b>PrePaid</b>: subscription.</description></item>
        /// <item><description><b>PostPaid</b>: pay-as-you-go.</description></item>
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
        /// <para>The instance type. For more information about the instance types of different architectures, see the following topics:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/311407.html">Standalone instance types</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/311410.html">Replica set instance types</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a></description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>You do not need to specify this parameter for serverless instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dds.mongo.2xlarge</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The IDs of the instances whose overview information you want to query.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the overview information of all instances within the current Alibaba Cloud account is queried by default.</description></item>
        /// <item><description>You can specify multiple instance IDs. Separate multiple instance IDs with commas (,).</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp12c5b040dc****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The status of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/63870.html">Instance statuses</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <para>The architecture of the instance. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>sharding</b>: sharded cluster instance.</description></item>
        /// <item><description><b>replicate</b>: replica set or standalone instance.
        /// &lt;props=&quot;china&quot;&gt;</description></item>
        /// <item><description><b>serverless</b>: serverless instance.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Specify this parameter based on your business requirements. For example, if you want to query the overview information of sharded cluster instances, set this parameter to <b>sharding</b>.</description></item>
        /// <item><description>If you do not specify this parameter, the overview information of all instances is queried by default.</description></item>
        /// </list>
        /// </remarks>
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
        /// <item><description><b>Classic</b>: classic network.</description></item>
        /// <item><description><b>VPC</b>: VPC.</description></item>
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
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query available regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. For more information, see <a href="https://help.aliyun.com/document_detail/151181.html">View the basic information of a resource group</a>.</para>
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
        /// <para>Specifies whether the instance tag label is displayed. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ShowTags")]
        [Validation(Required=false)]
        public bool? ShowTags { get; set; }

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
        /// <para>The ID of the virtual private cloud (VPC).</para>
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
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
