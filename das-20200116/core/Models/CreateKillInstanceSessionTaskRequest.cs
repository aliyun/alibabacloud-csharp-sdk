// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class CreateKillInstanceSessionTaskRequest : TeaModel {
        /// <summary>
        /// <para>The database account that has the permission to terminate sessions.</para>
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
        /// <para>The list of accounts whose sessions will not be terminated.</para>
        /// <remarks>
        /// <para>The data is in JSONArray format, such as [\&quot;DatabaseAccount1\&quot;,\&quot;DatabaseAccount2\&quot;\]. Separate multiple database accounts with commas (,).</para>
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
        /// <item><description><para><b>true</b>: Yes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: No.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>When this parameter is set to <b>true</b>, sessions of accounts specified in the <b>IgnoredUsers</b> request parameter, sessions of Alibaba Cloud internal operations accounts, and <b>Binlog Dump</b> sessions are not terminated.</para>
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
        /// <para>For PolarDB for MySQL instances, provide the node ID. If no node ID is provided and the <b>KillAllSessions</b> request parameter is set to <b>true</b> (terminate all sessions), the system traverses all nodes of the PolarDB for MySQL instance and terminates ongoing sessions on each node.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-bp1v203xzzh0a****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The list of session IDs to be terminated.</para>
        /// <remarks>
        /// <para>The data is in JSONArray format, such as [SessionID1,SessionID2\]. Separate multiple session IDs with commas (,). If the <b>KillAllSessions</b> request parameter is set to <b>true</b> (terminate all sessions), this list is ignored.</para>
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
