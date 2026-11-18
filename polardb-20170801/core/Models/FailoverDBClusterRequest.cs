// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class FailoverDBClusterRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can use the client to generate the value, and you must ensure that the value is unique among different requests. The value is case-sensitive and can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f54a343f1a4233c1e7d1c5******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the database cluster.</para>
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
        /// <para>The ID of the node to be switched to the primary node. If you do not specify this parameter, the system automatically elects a primary node. You can call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to query the node ID and other information.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Automatic primary node election: The system identifies all read-only nodes that can be elected. It selects one or more read-only nodes with the highest priority. If the switchover to the first node fails (for example, due to network issues or abnormal replication status), the system attempts to switch to the next node until the switchover succeeds.</description></item>
        /// <item><description>This parameter is required when the cluster is a PolarDB for PostgreSQL (Compatible with Oracle) or PolarDB for PostgreSQL cluster. This parameter is optional when the cluster is a PolarDB for MySQL cluster.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-***********</para>
        /// </summary>
        [NameInMap("TargetDBNodeId")]
        [Validation(Required=false)]
        public string TargetDBNodeId { get; set; }

        /// <summary>
        /// <para>Specifies whether the primary/secondary switchover is performed within the primary zone. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Primary: primary/secondary switchover within the primary zone.</description></item>
        /// <item><description>Standby: switchover to the hot standby storage cluster.</description></item>
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
