// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class CreateDataAgentWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>The workspace configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{sql_config:null}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The current DMS unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DMSUnit")]
        [Validation(Required=false)]
        public string DMSUnit { get; set; }

        /// <summary>
        /// <para>Specifies whether sessions within the workspace are shared.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSessionShareEnabled")]
        [Validation(Required=false)]
        public bool? IsSessionShareEnabled { get; set; }

        /// <summary>
        /// <para>The description of the collaborative workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Space for test</para>
        /// </summary>
        [NameInMap("WorkspaceDesc")]
        [Validation(Required=false)]
        public string WorkspaceDesc { get; set; }

        /// <summary>
        /// <para>The name of the collaborative workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspaceTest</para>
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
