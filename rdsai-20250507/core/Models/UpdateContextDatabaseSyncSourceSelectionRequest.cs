// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class UpdateContextDatabaseSyncSourceSelectionRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sync-connection-20260923-001</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The list of selected node identifiers.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;doc:1234567890&quot;]</para>
        /// </summary>
        [NameInMap("SelectedNodeKeys")]
        [Validation(Required=false)]
        public List<string> SelectedNodeKeys { get; set; }

        /// <summary>
        /// <para>The selection policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>subtree</para>
        /// </summary>
        [NameInMap("SelectionPolicy")]
        [Validation(Required=false)]
        public string SelectionPolicy { get; set; }

        /// <summary>
        /// <para>The data source ID, which is a system-generated UUID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400-e29b-41d4-a716-446655440000</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
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
