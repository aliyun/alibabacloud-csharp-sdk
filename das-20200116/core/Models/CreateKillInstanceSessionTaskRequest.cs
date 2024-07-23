// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class CreateKillInstanceSessionTaskRequest : TeaModel {
        /// <summary>
        /// <para>The database account that has the permissions to terminate sessions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testUser</para>
        /// </summary>
        [NameInMap("DbUser")]
        [Validation(Required=false)]
        public string DbUser { get; set; }

        /// <summary>
        /// <para>The password of the database account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testPassword</para>
        /// </summary>
        [NameInMap("DbUserPassword")]
        [Validation(Required=false)]
        public string DbUserPassword { get; set; }

        /// <summary>
        /// <para>The account whose sessions do not need to be terminated.</para>
        /// <remarks>
        /// <para> Set this parameter to a JSON array. Separate database accounts with commas (,). Example: [\&quot;Database account 1\&quot;,\&quot;Database account 2\&quot;].</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;db_user1\&quot;,\&quot;db_user2\&quot;]</para>
        /// </summary>
        [NameInMap("IgnoredUsers")]
        [Validation(Required=false)]
        public string IgnoredUsers { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze8g2am97624****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to terminate all sessions.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set this parameter to <b>true</b>, sessions of the accounts that are specified by <b>IgnoredUsers</b>, sessions of internal O\&amp;M accounts of Alibaba Cloud, and <b>Binlog Dump</b> sessions are not terminated.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("KillAllSessions")]
        [Validation(Required=false)]
        public bool? KillAllSessions { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <remarks>
        /// <para> This parameter must be specified if the database instance is a PolarDB for MySQL cluster. If you do not specify a node ID and set <b>KillAllSessions</b> to <b>true</b>, the system traverses all nodes in the PolarDB for MySQL cluster and terminates the active sessions on each node.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-bp1v203xzzh0a****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The IDs of sessions that need to be terminated.</para>
        /// <remarks>
        /// <para> Set this parameter to a JSON array. Separate session IDs with commas (,). Example: [\&quot;Session ID1\&quot;,\&quot;Session ID2\&quot;]. If <b>KillAllSessions</b> is set to <b>true</b>, this parameter does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[10805639,10805623,10805645,10805553,10805566,10805616]</para>
        /// </summary>
        [NameInMap("SessionIds")]
        [Validation(Required=false)]
        public string SessionIds { get; set; }

    }

}
