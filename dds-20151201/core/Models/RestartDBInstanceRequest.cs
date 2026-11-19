// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class RestartDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. Before calling this operation, ensure that the instance is in the Running state. You can check the current status of the instance by checking the DBInstanceStatus field returned by the DescribeDBInstanceAttribute operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bpxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the shard or mongos node in the sharded cluster instance.</para>
        /// <remarks>
        /// <para>If the instance is a sharded cluster instance and this parameter is not specified, the entire sharded cluster instance is restarted.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>d-bpxxxxxxxx</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The type of the node to be restarted in the sharded cluster instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>db</b>: shard node.</description></item>
        /// <item><description><b>mongos</b>: mongos node.</description></item>
        /// <item><description><b>cs</b>: Configserver node.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>db</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to restart mongos nodes in parallel. This parameter takes effect only when multiple mongos nodes are restarted in a batch.</para>
        /// </summary>
        [NameInMap("ParallelRestartMongos")]
        [Validation(Required=false)]
        public bool? ParallelRestartMongos { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The time when the instance is restarted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Restarts the instance immediately.</description></item>
        /// <item><description>1: Restarts the instance within the O&amp;M window.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SwitchMode")]
        [Validation(Required=false)]
        public string SwitchMode { get; set; }

    }

}
