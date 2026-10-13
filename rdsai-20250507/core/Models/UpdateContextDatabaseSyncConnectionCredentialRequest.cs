// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class UpdateContextDatabaseSyncConnectionCredentialRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>sync-connection-20260923-001</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400-e29b-41d4-a716-446655440000</para>
        /// </summary>
        [NameInMap("ConnectionId")]
        [Validation(Required=false)]
        public string ConnectionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;appKey&quot;:&quot;dingas1llqmkol****&quot;,&quot;appSecret&quot;:&quot;******&quot;}</para>
        /// </summary>
        [NameInMap("Credentials")]
        [Validation(Required=false)]
        public Dictionary<string, object> Credentials { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-as1llqmkol****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
