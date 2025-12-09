// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateDBNodesRequest : TeaModel {
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. The token is case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f54a343f1a4233c1e7d1c5c******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ENS</para>
        /// </summary>
        [NameInMap("CloudProvider")]
        [Validation(Required=false)]
        public string CloudProvider { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-*************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The details of the read-only node.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DBNode")]
        [Validation(Required=false)]
        public List<CreateDBNodesRequestDBNode> DBNode { get; set; }
        public class CreateDBNodesRequestDBNode : TeaModel {
            /// <summary>
            /// <para>The specifications of the read-only node that you want to add, which must be the same as the specifications of the existing nodes. For more information, see the following topics:</para>
            /// <list type="bullet">
            /// <item><description>PolarDB for MySQL: <a href="https://help.aliyun.com/document_detail/102542.html">Specifications of compute nodes</a></description></item>
            /// <item><description>PolarDB for PostgreSQL (Compatible with Oracle): <a href="https://help.aliyun.com/document_detail/207921.html">Specifications of compute nodes</a></description></item>
            /// <item><description>PolarDB for PostgreSQL: <a href="https://help.aliyun.com/document_detail/209380.html">Specifications of compute nodes</a></description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>You need to specify either DBNode.N.ZoneId or DBNode.N.TargetClass. N is an integer that starts from 1. The maximum value of N is equal to 16 minus the number of existing nodes.</description></item>
            /// <item><description>You can add multiple read-only nodes at the same time only to PolarDB for MySQL clusters, which can contain up to of 15 read-only nodes.</description></item>
            /// <item><description>This parameter is required for PolarDB for PostgreSQL (Compatible with Oracle) clusters or PolarDB for PostgreSQL clusters. This parameter is optional for PolarDB for MySQL clusters.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>polar.mysql.x4.medium</para>
            /// </summary>
            [NameInMap("TargetClass")]
            [Validation(Required=false)]
            public string TargetClass { get; set; }

            /// <summary>
            /// <para>The zone ID of the node that you want to add, which must be the same as the zone ID of existing nodes. You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query the IDs of zones.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>You need to specify either DBNode.N.ZoneId or DBNode.N.TargetClass. N is an integer that starts from 1. The maximum value of N is equal to 16 minus the number of existing nodes.</description></item>
            /// <item><description>You can add multiple read-only nodes at the same time only to PolarDB for MySQL clusters, which can contain up to of 15 read-only nodes.</description></item>
            /// <item><description>This parameter is required for PolarDB for PostgreSQL (Compatible with Oracle) clusters or PolarDB for PostgreSQL clusters. This parameter is optional for PolarDB for MySQL clusters.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-qingdao-c</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The node type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RO</description></item>
        /// <item><description>STANDBY</description></item>
        /// <item><description>DLNode</description></item>
        /// </list>
        /// <para>Enumerated values:</para>
        /// <list type="bullet">
        /// <item><description>DLNode: AI node</description></item>
        /// <item><description>STANDBY: standby node</description></item>
        /// <item><description>RO: read-only node</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RO</para>
        /// </summary>
        [NameInMap("DBNodeType")]
        [Validation(Required=false)]
        public string DBNodeType { get; set; }

        /// <summary>
        /// <para>The ID of the cluster endpoint to which the read-only node is added. If you want to add the read-only node to multiple endpoints at the same time, separate the endpoint IDs with commas (,).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/98205.html">DescribeDBClusterEndpoints</a> operation to query the details of cluster endpoints, including endpoint IDs.</description></item>
        /// <item><description>You can enter the ID of the default cluster endpoint or a custom cluster endpoint.</description></item>
        /// <item><description>If you leave this parameter empty, the read-only node is added to all cluster endpoints for which the <b>Automatically Associate New Nodes</b> feature is enabled. If you set <c>AutoAddNewNodes</c> to <c>Enable</c>, the Automatically Associate New Nodes feature is enabled.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pe-<b><b><b><b><b><b><b><b>,pe-</b></b></b></b></b></b></b></b></para>
        /// </summary>
        [NameInMap("EndpointBindList")]
        [Validation(Required=false)]
        public string EndpointBindList { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the In-Memory Column Index (IMCI) feature. Default value: OFF. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ON</b></description></item>
        /// <item><description><b>OFF</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is invalid for a PolarDB for Oracle or PolarDB for PostgreSQL cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("ImciSwitch")]
        [Validation(Required=false)]
        public string ImciSwitch { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The latest start time for upgrading the specifications within the scheduled time period. Specify the time in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The value of this parameter must be at least 30 minutes later than the value of PlannedStartTime.</description></item>
        /// <item><description>If you specify <c>PlannedStartTime</c> but do not specify PlannedEndTime, the latest start time of the task is set to a value that is calculated by using the following formula: <c>PlannedEndTime value + 30 minutes</c>. For example, if you set <c>PlannedStartTime</c> to <c>2021-01-14T09:00:00Z</c> and you do not specify PlannedEndTime, the latest start time of the task is set to <c>2021-01-14T09:30:00Z</c>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-14T09:30:00Z</para>
        /// </summary>
        [NameInMap("PlannedEndTime")]
        [Validation(Required=false)]
        public string PlannedEndTime { get; set; }

        /// <summary>
        /// <para>The earliest start time of the scheduled task for adding the read-only node. The scheduled task specifies that the task is run in the required period. Specify the time in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The earliest start time of the scheduled task can be a point in time within the next 24 hours. For example, if the current time is <c>2021-01-14T09:00:00Z</c>, you can specify a point in time between <c>2021-01-14T09:00:00Z</c> and <c>2021-01-15T09:00:00Z</c>.</description></item>
        /// <item><description>If you leave this parameter empty, the task for adding the read-only node is immediately run by default.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-14T09:00:00Z</para>
        /// </summary>
        [NameInMap("PlannedStartTime")]
        [Validation(Required=false)]
        public string PlannedStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>727xxxxxx934</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-************</para>
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

    }

}
