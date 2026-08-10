// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyAuditLogFilterRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp12c5b040dc****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The collection types of audit logs. Separate multiple collection types with commas (,).</para>
        /// <list type="bullet">
        /// <item><description><b>admin</b>: O&amp;M and management operations.</description></item>
        /// <item><description><b>slow</b>: Slow queries.</description></item>
        /// <item><description><b>query</b>: Query operations.</description></item>
        /// <item><description><b>insert</b>: Insert operations.  </description></item>
        /// <item><description><b>update</b>: Update operations.  </description></item>
        /// <item><description><b>delete</b>: Delete operations. </description></item>
        /// <item><description><b>command</b>: Protocol commands, such as the aggregate method.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>insert,query,update,delete</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

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
        /// <para>The role of the node in the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>db</b>: shard node</description></item>
        /// <item><description><b>mongos</b>: mongos node</description></item>
        /// </list>
        /// <remarks>
        /// <para>Metric description</para>
        /// <list type="bullet">
        /// <item><description>This parameter applies only to sharded cluster instances. If this parameter is left empty, the default value db is used. You do not need to specify this parameter for replica set instances.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>db</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

    }

}
