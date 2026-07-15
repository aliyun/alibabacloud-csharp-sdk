// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAuditLogFilterResponseBody : TeaModel {
        /// <summary>
        /// <para>The type of the audit log entries. Valid values:</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>admin,slow,insert,query,update,delete,command</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7BAFB0B3-2A54-5B65-B13E-3937CF08FEE6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The role of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>logic</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

    }

}
