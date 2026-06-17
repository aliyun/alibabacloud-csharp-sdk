// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateDBNodesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically use a coupon. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true (Default): An available coupon is automatically used.</para>
        /// </description></item>
        /// <item><description><para>false: A coupon is not automatically used.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>A unique, client-generated token to ensure the idempotence of the request. This token is case-sensitive and cannot exceed 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f54a343f1a4233c1e7d1c5c******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The cloud provider of the node.</para>
        /// 
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
        /// <para>Details of the nodes to add.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DBNode")]
        [Validation(Required=false)]
        public List<CreateDBNodesRequestDBNode> DBNode { get; set; }
        public class CreateDBNodesRequestDBNode : TeaModel {
            /// <summary>
            /// <para>The specifications of the new node. The specifications must be the same as those of the existing nodes in the cluster. For more information, see the following topics:</para>
            /// <list type="bullet">
            /// <item><description><para>PolarDB for MySQL: <a href="https://help.aliyun.com/document_detail/102542.html">compute node specifications</a>.</para>
            /// </description></item>
            /// <item><description><para>PolarDB for PostgreSQL (Oracle Compatible): <a href="https://help.aliyun.com/document_detail/207921.html">compute node specifications</a>.</para>
            /// </description></item>
            /// <item><description><para>PolarDB for PostgreSQL: <a href="https://help.aliyun.com/document_detail/209380.html">compute node specifications</a>.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>You must specify either <c>DBNode.N.ZoneId</c> or <c>DBNode.N.TargetClass</c>. <c>N</c> is an integer that starts from 1. The maximum value of <c>N</c> is 16 minus the number of existing nodes.</para>
            /// </description></item>
            /// <item><description><para>For PolarDB for MySQL clusters, you can add multiple read-only nodes in a single request, up to a total of 15 read-only nodes.</para>
            /// </description></item>
            /// <item><description><para>This parameter is required for PolarDB for PostgreSQL (Oracle Compatible) and PolarDB for PostgreSQL clusters, but optional for PolarDB for MySQL clusters.</para>
            /// </description></item>
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
            /// <para>The ID of the zone for the new node. This zone must be the same as the zone of the existing nodes. You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query zone IDs.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>You must specify either <c>DBNode.N.ZoneId</c> or <c>DBNode.N.TargetClass</c>. <c>N</c> is an integer that starts from 1. The maximum value of <c>N</c> is 16 minus the number of existing nodes.</para>
            /// </description></item>
            /// <item><description><para>For PolarDB for MySQL clusters, you can add multiple read-only nodes in a single request, up to a total of 15 read-only nodes.</para>
            /// </description></item>
            /// <item><description><para>This parameter is required for PolarDB for PostgreSQL (Oracle Compatible) and PolarDB for PostgreSQL clusters, but optional for PolarDB for MySQL clusters.</para>
            /// </description></item>
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
        /// <item><description><para>RO</para>
        /// </description></item>
        /// <item><description><para>STANDBY</para>
        /// </description></item>
        /// <item><description><para>DLNode</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RO</para>
        /// </summary>
        [NameInMap("DBNodeType")]
        [Validation(Required=false)]
        public string DBNodeType { get; set; }

        /// <summary>
        /// <para>The ID of the cluster endpoint to which you want to add the new nodes. If you want to add the nodes to multiple cluster endpoints, separate the endpoint IDs with a comma (,).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/98205.html">DescribeDBClusterEndpoints</a> operation to query the details of cluster endpoints, including their IDs.</para>
        /// </description></item>
        /// <item><description><para>You can specify the IDs of the default cluster endpoint and custom cluster endpoints.</para>
        /// </description></item>
        /// <item><description><para>If you leave this parameter empty, the new nodes are automatically added to all cluster endpoints where the <b>Auto Add New Nodes</b> feature is enabled (the <c>AutoAddNewNodes</c> parameter is set to <c>Enable</c>).</para>
        /// </description></item>
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
        /// <para>Specifies whether to enable In-Memory Column Index (IMCI). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ON</b>: The feature is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>OFF</b> (Default): The feature is disabled.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is not supported for PolarDB for PostgreSQL (Oracle Compatible) and PolarDB for PostgreSQL clusters.</para>
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
        /// <para>The latest time to start the scheduled task. The time is specified in the <c>YYYY-MM-DDThh:mm:ssZ</c> format and is in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This time must be at least 30 minutes later than the value of <c>PlannedStartTime</c>.</para>
        /// </description></item>
        /// <item><description><para>If you specify <c>PlannedStartTime</c> but not this parameter, the latest start time defaults to 30 minutes after the <c>PlannedStartTime</c>. For example, if you set <c>PlannedStartTime</c> to <c>2021-01-14T09:00:00Z</c> and leave this parameter empty, the task starts no later than <c>2021-01-14T09:30:00Z</c>.</para>
        /// </description></item>
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
        /// <para>The earliest time to start the scheduled task to add the nodes. The time must be in UTC and in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The start time must be within the next 24 hours. For example, if the current time is <c>2021-01-14T09:00:00Z</c>, you can set this parameter to a value between <c>2021-01-14T09:00:00Z</c> and <c>2021-01-15T09:00:00Z</c>.</para>
        /// </description></item>
        /// <item><description><para>If you omit this parameter, the nodes are added immediately.</para>
        /// </description></item>
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
        /// <para>The promotion code. If you omit this parameter, an applicable coupon is used by default.</para>
        /// 
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
