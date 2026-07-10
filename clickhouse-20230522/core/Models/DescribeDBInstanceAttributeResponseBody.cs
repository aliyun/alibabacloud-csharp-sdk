// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DescribeDBInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBInstanceAttributeResponseBodyData Data { get; set; }
        public class DescribeDBInstanceAttributeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID.</para>
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
            /// <para>The edition of the cluster. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><c>enterprise</c>: enterprise edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enterprise</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The billing method of the cluster.
            /// enterprise edition clusters are billed on a pay-as-you-go basis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POSTPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The status of the ClickObserve service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>activation</para>
            /// </summary>
            [NameInMap("ClickObserveServiceStatus")]
            [Validation(Required=false)]
            public string ClickObserveServiceStatus { get; set; }

            /// <summary>
            /// <para>The creation time of the cluster, in <c>YYYY-MM-DDTHH:mm:ssZ</c> format.</para>
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
            /// <para>Whether deletion protection is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0/1</para>
            /// </summary>
            [NameInMap("DeletionProtection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            /// <summary>
            /// <para>The deployment architecture of the cluster. Valid values: <c>single_az</c> and <c>multi_az</c>.</para>
            /// <list type="bullet">
            /// <item><description><para><c>single_az</c>: The nodes are deployed in the primary zone specified by <c>ZoneId</c>.</para>
            /// </description></item>
            /// <item><description><para><c>multi_az</c>: The nodes are deployed across the zones specified in <c>MultiZones</c>.</para>
            /// </description></item>
            /// </list>
            /// <para>Keeper nodes are always deployed across the zones specified in <c>MultiZones</c>.</para>
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
            /// <para>cluster test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>A comma-separated list of disabled database ports.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9001,8123</para>
            /// </summary>
            [NameInMap("DisabledPorts")]
            [Validation(Required=false)]
            public string DisabledPorts { get; set; }

            /// <summary>
            /// <para>The engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>clickhouse</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The minor version of the cluster engine.</para>
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
            /// <para>The expiration time of the cluster, in <c>YYYY-MM-DDTHH:mm:ssZ</c> format.</para>
            /// <remarks>
            /// <para>Pay-as-you-go clusters do not expire. An empty string is returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-17T08:14:48Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>A list of Langfuse instance IDs.</para>
            /// </summary>
            [NameInMap("LangfuseInstanceIds")]
            [Validation(Required=false)]
            public List<string> LangfuseInstanceIds { get; set; }

            /// <summary>
            /// <para>The latest minor version of the cluster engine.</para>
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
            /// <para>The reason for the lock.</para>
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
            /// <para>12:00Z</para>
            /// </summary>
            [NameInMap("MaintainEndTime")]
            [Validation(Required=false)]
            public string MaintainEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the maintenance window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11:00Z</para>
            /// </summary>
            [NameInMap("MaintainStartTime")]
            [Validation(Required=false)]
            public string MaintainStartTime { get; set; }

            /// <summary>
            /// <para>The zones for a multi-zone deployment.</para>
            /// </summary>
            [NameInMap("MultiZones")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceAttributeResponseBodyDataMultiZones> MultiZones { get; set; }
            public class DescribeDBInstanceAttributeResponseBodyDataMultiZones : TeaModel {
                /// <summary>
                /// <para>An array of vSwitch IDs.</para>
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
            /// <para>The number of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NodeCount")]
            [Validation(Required=false)]
            public string NodeCount { get; set; }

            /// <summary>
            /// <para>The maximum number of nodes for auto scaling of a serverless cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("NodeScaleMax")]
            [Validation(Required=false)]
            public string NodeScaleMax { get; set; }

            /// <summary>
            /// <para>The minimum number of nodes for auto scaling of a serverless cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("NodeScaleMin")]
            [Validation(Required=false)]
            public string NodeScaleMin { get; set; }

            /// <summary>
            /// <para>The cluster nodes.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceAttributeResponseBodyDataNodes> Nodes { get; set; }
            public class DescribeDBInstanceAttributeResponseBodyDataNodes : TeaModel {
                /// <summary>
                /// <para>The status of the node.</para>
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
            /// <para>The storage capacity of Object Storage Service (OSS).</para>
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
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmzygvt54****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The maximum value for serverless auto scaling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("ScaleMax")]
            [Validation(Required=false)]
            public int? ScaleMax { get; set; }

            /// <summary>
            /// <para>The minimum value for serverless auto scaling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("ScaleMin")]
            [Validation(Required=false)]
            public int? ScaleMin { get; set; }

            /// <summary>
            /// <para>The status of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVATION</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The provisioned storage, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("StorageQuota")]
            [Validation(Required=false)]
            public string StorageQuota { get; set; }

            /// <summary>
            /// <para>The storage space, in GB.</para>
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
            /// <para>The cluster tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceAttributeResponseBodyDataTags> Tags { get; set; }
            public class DescribeDBInstanceAttributeResponseBodyDataTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>id</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
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
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-wz9duj8xd6r1gzhsg*****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("WebUISnatStatus")]
            [Validation(Required=false)]
            public string WebUISnatStatus { get; set; }

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
