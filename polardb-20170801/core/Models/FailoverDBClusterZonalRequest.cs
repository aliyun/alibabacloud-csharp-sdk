// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class FailoverDBClusterZonalRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate requests. You can generate the value of this parameter on the client side. The value must be unique across different requests and is case-sensitive. It can contain up to 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f54a343f1a4233c1e7d1c5******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the edge cloud cluster. Only the edge cluster IDs returned by DescribeDBClustersZonal are supported. Standard PolarDB cluster IDs are not supported. Note: Only edge cluster IDs are accepted. You can call DescribeDBClustersZonal to obtain available edge cluster IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to switch back to the original primary zone after a failover. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Yes.</description></item>
        /// <item><description>false: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RollBackForDisaster")]
        [Validation(Required=false)]
        public bool? RollBackForDisaster { get; set; }

        /// <summary>
        /// <para>The ID of the edge cluster node to be switched to the primary node. If you leave this parameter empty, the system automatically selects a primary node. You can call DescribeDbClusterAttributeZonal to query the node ID. Note: DescribeDbClusterAttributeZonal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pi-***********</para>
        /// </summary>
        [NameInMap("TargetDBNodeId")]
        [Validation(Required=false)]
        public string TargetDBNodeId { get; set; }

        /// <summary>
        /// <para>Specifies whether it is an active primary/secondary switchover within the primary zone. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Primary: Performs a primary/secondary switchover within the primary zone.</description></item>
        /// <item><description>Standby: Switches to the hot standby storage cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Primary</para>
        /// </summary>
        [NameInMap("TargetZoneType")]
        [Validation(Required=false)]
        public string TargetZoneType { get; set; }

    }

}
