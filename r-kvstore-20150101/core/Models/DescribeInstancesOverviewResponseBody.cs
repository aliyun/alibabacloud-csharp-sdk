// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInstancesOverviewResponseBody : TeaModel {
        /// <summary>
        /// <para>An array of instances.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeInstancesOverviewResponseBodyInstances> Instances { get; set; }
        public class DescribeInstancesOverviewResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The architecture of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cluster</b>: cluster architecture</description></item>
            /// <item><description><b>standard</b>: standard architecture</description></item>
            /// <item><description><b>rwsplit</b>: read/write splitting architecture</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cluster</para>
            /// </summary>
            [NameInMap("ArchitectureType")]
            [Validation(Required=false)]
            public string ArchitectureType { get; set; }

            /// <summary>
            /// <para>The storage capacity of the instance. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4096</para>
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public long? Capacity { get; set; }

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
            /// <para>The internal endpoint of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>r-bp1zxszhcgatnx****.redis.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ConnectionDomain")]
            [Validation(Required=false)]
            public string ConnectionDomain { get; set; }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-11-07T08:49:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the subscription instance expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-06-13T16:00:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The database engine version of the instance. Valid values: <b>2.8</b>, <b>4.0</b>, and <b>5.0</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4.0</para>
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <para>The ID of the distributed instance.</para>
            /// <remarks>
            /// <para>This parameter is returned only when the instance is a child instance of a distributed instance.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>gr-bp14rkqrhac****</para>
            /// </summary>
            [NameInMap("GlobalInstanceId")]
            [Validation(Required=false)]
            public string GlobalInstanceId { get; set; }

            /// <summary>
            /// <para>The instance type of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>redis.logic.sharding.2g.2db.0rodb.4proxy.default</para>
            /// </summary>
            [NameInMap("InstanceClass")]
            [Validation(Required=false)]
            public string InstanceClass { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>r-bp1zxszhcgatnx****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apitest</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

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
            /// <para>The private IP address of the instance.</para>
            /// <remarks>
            /// <para>This parameter is not returned when the instance is deployed in the classic network.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.49.***</para>
            /// </summary>
            [NameInMap("PrivateIp")]
            [Validation(Required=false)]
            public string PrivateIp { get; set; }

            /// <summary>
            /// <para>The region ID of the instance.</para>
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
            /// <para>rg-acfmyiu4ekp****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Instance\&quot;s secondary zone id.</para>
            /// <remarks>
            /// <para>This parameter is only returned when the instance has a secondary zone ID.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-g</para>
            /// </summary>
            [NameInMap("SecondaryZoneId")]
            [Validation(Required=false)]
            public string SecondaryZoneId { get; set; }

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

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1E83311F-0EE4-4922-A3BF-730B312B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
