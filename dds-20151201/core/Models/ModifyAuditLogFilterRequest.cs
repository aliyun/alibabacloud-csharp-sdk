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
        /// <para>The type of logs collected by the audit log feature of the instance. Separate multiple types with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>admin</b>: O\&amp;M and management operations</para>
        /// </description></item>
        /// <item><description><para><b>slow</b>: slow query logs</para>
        /// </description></item>
        /// <item><description><para><b>query</b>: query operations</para>
        /// </description></item>
        /// <item><description><para><b>insert</b>: insert operations</para>
        /// </description></item>
        /// <item><description><para><b>update</b>: update operations</para>
        /// </description></item>
        /// <item><description><para><b>delete</b>: delete operations</para>
        /// </description></item>
        /// <item><description><para><b>command</b>: protocol commands such as the aggregate method</para>
        /// </description></item>
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
        /// <item><description><para><b>primary</b></para>
        /// </description></item>
        /// <item><description><para><b>secondary</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>primary</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

    }

}
