// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class CreateKillInstanceSessionTaskRequest : TeaModel {
        /// <summary>
        /// The database account that has the permissions to terminate sessions.
        /// </summary>
        [NameInMap("DbUser")]
        [Validation(Required=false)]
        public string DbUser { get; set; }

        /// <summary>
        /// The password of the database account.
        /// </summary>
        [NameInMap("DbUserPassword")]
        [Validation(Required=false)]
        public string DbUserPassword { get; set; }

        /// <summary>
        /// The account whose sessions do not need to be terminated.
        /// 
        /// >  Set this parameter to a JSON array. Separate database accounts with commas (,). Example: \[\"Database account 1\",\"Database account 2\"].
        /// </summary>
        [NameInMap("IgnoredUsers")]
        [Validation(Required=false)]
        public string IgnoredUsers { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Specifies whether to terminate all sessions.
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// >  If you set this parameter to **true**, sessions of the accounts that are specified by **IgnoredUsers**, sessions of internal O\&M accounts of Alibaba Cloud, and **Binlog Dump** sessions are not terminated.
        /// </summary>
        [NameInMap("KillAllSessions")]
        [Validation(Required=false)]
        public bool? KillAllSessions { get; set; }

        /// <summary>
        /// The node ID.
        /// 
        /// >  This parameter must be specified if the database instance is a PolarDB for MySQL cluster. If you do not specify a node ID and set **KillAllSessions** to **true**, the system traverses all nodes in the PolarDB for MySQL cluster and terminates the active sessions on each node.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// The IDs of sessions that need to be terminated.
        /// 
        /// >  Set this parameter to a JSON array. Separate session IDs with commas (,). Example: \[\"Session ID1\",\"Session ID2\"]. If **KillAllSessions** is set to **true**, this parameter does not take effect.
        /// </summary>
        [NameInMap("SessionIds")]
        [Validation(Required=false)]
        public string SessionIds { get; set; }

    }

}
