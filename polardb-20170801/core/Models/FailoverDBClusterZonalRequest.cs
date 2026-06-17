// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class FailoverDBClusterZonalRequest : TeaModel {
        /// <summary>
        /// <para>A client token to ensure the idempotence of the request. The client generates this token. It must be unique across requests. The token is case-sensitive and cannot exceed 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f54a343f1a4233c1e7d1c5******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
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
        /// <para>Specifies whether to fail back to the original primary zone after a failover. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Yes.</para>
        /// </description></item>
        /// <item><description><para>false: No.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RollBackForDisaster")]
        [Validation(Required=false)]
        public bool? RollBackForDisaster { get; set; }

        /// <summary>
        /// <para>The ID of the node to promote to the primary node. If you do not specify this parameter, the system automatically selects a node. Call the DescribeDBClusters operation to query node information, such as node IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pi-***********</para>
        /// </summary>
        [NameInMap("TargetDBNodeId")]
        [Validation(Required=false)]
        public string TargetDBNodeId { get; set; }

        /// <summary>
        /// <para>The type of failover. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Primary: A primary/secondary failover within the primary zone.</para>
        /// </description></item>
        /// <item><description><para>Standby: A switch to the hot standby storage cluster.</para>
        /// </description></item>
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
