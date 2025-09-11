// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DescribeDBInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The result returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBInstanceAttributeResponseBodyData Data { get; set; }
        public class DescribeDBInstanceAttributeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>140692647406****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The channel ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PD39050615820269****</para>
            /// </summary>
            [NameInMap("Bid")]
            [Validation(Required=false)]
            public string Bid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>enterprise</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The billing method. Enterprise Edition clusters use the pay-as-you-go billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The time when the cluster was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-09-14T08:14:48Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc-bp100p4q1g9z3****</para>
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// <para>Indicates whether the release protection feature is enabled for the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0/1</para>
            /// </summary>
            [NameInMap("DeletionProtection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            /// <summary>
            /// <para>The deployment mode of the cluster. Valid values: single_az and multi_az.</para>
            /// <list type="bullet">
            /// <item><description>single_az: indicates that the server nodes are deployed in the primary zone. The ID of the primary zone is specified by the ZoneID parameter.</description></item>
            /// <item><description>multi_az: indicates that the server nodes are deployed in multiple zones. The information about the zones is specified by the MultiZones parameter.</description></item>
            /// </list>
            /// <para>The keeper nodes are deployed in multiple zones.</para>
            /// 
            /// <b>Example:</b>
            /// <para>single_az</para>
            /// </summary>
            [NameInMap("DeploySchema")]
            [Validation(Required=false)]
            public string DeploySchema { get; set; }

            /// <summary>
            /// <para>The cluster description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Used for test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The disabled database ports. Multiple database ports are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>9001,8123</para>
            /// </summary>
            [NameInMap("DisabledPorts")]
            [Validation(Required=false)]
            public string DisabledPorts { get; set; }

            /// <summary>
            /// <para>The engine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>clickhouse</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The minor engine version of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23.8.1.41495_6</para>
            /// </summary>
            [NameInMap("EngineMinorVersion")]
            [Validation(Required=false)]
            public string EngineMinorVersion { get; set; }

            /// <summary>
            /// <para>The engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23.8</para>
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <para>The time when the cluster expires. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// <remarks>
            /// <para> Pay-as-you-go clusters never expire. If the cluster is a pay-as-you-go cluster, an empty string is returned for this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-17T08:14:48Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The latest minor engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23.8.1.41495_6</para>
            /// </summary>
            [NameInMap("LatestEngineMinorVersion")]
            [Validation(Required=false)]
            public string LatestEngineMinorVersion { get; set; }

            /// <summary>
            /// <para>The lock mode of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            /// <summary>
            /// <para>The reason why the cluster was locked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nolock</para>
            /// </summary>
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public string LockReason { get; set; }

            /// <summary>
            /// <para>The end time of the maintenance window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21:00</para>
            /// </summary>
            [NameInMap("MaintainEndTime")]
            [Validation(Required=false)]
            public string MaintainEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the maintenance window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12:00</para>
            /// </summary>
            [NameInMap("MaintainStartTime")]
            [Validation(Required=false)]
            public string MaintainStartTime { get; set; }

            /// <summary>
            /// <para>The information about the zones.</para>
            /// </summary>
            [NameInMap("MultiZones")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceAttributeResponseBodyDataMultiZones> MultiZones { get; set; }
            public class DescribeDBInstanceAttributeResponseBodyDataMultiZones : TeaModel {
                /// <summary>
                /// <para>The vSwitch IDs.</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public List<string> VSwitchIds { get; set; }

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

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NodeCount")]
            [Validation(Required=false)]
            public string NodeCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("NodeScaleMax")]
            [Validation(Required=false)]
            public string NodeScaleMax { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("NodeScaleMin")]
            [Validation(Required=false)]
            public string NodeScaleMin { get; set; }

            /// <summary>
            /// <para>The nodes.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceAttributeResponseBodyDataNodes> Nodes { get; set; }
            public class DescribeDBInstanceAttributeResponseBodyDataNodes : TeaModel {
                /// <summary>
                /// <para>The node status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("NodeStatus")]
                [Validation(Required=false)]
                public string NodeStatus { get; set; }

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

            /// <summary>
            /// <para>The size of the object storage space.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("ObjectStoreSize")]
            [Validation(Required=false)]
            public string ObjectStoreSize { get; set; }

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
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmzygvt54****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The maximum capacity for elastic scaling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("ScaleMax")]
            [Validation(Required=false)]
            public int? ScaleMax { get; set; }

            /// <summary>
            /// <para>The minimum capacity for elastic scaling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("ScaleMin")]
            [Validation(Required=false)]
            public int? ScaleMin { get; set; }

            /// <summary>
            /// <para>The cluster status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("StorageQuota")]
            [Validation(Required=false)]
            public string StorageQuota { get; set; }

            /// <summary>
            /// <para>The size of the storage space. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("StorageSize")]
            [Validation(Required=false)]
            public int? StorageSize { get; set; }

            /// <summary>
            /// <para>The storage type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The details of the tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceAttributeResponseBodyDataTags> Tags { get; set; }
            public class DescribeDBInstanceAttributeResponseBodyDataTags : TeaModel {
                /// <summary>
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>id</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ck</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-uf67ij56zm9x4uc6hmilg</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The virtual private cloud (VPC) ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-wz9duj8xd6r1gzhsg*****</para>
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

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2FED790E-FB61-4721-8C1C-07C627FA5A19</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
