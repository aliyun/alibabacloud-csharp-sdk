// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class UpdateWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>The workspace description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the workspace.</para>
        /// <list type="bullet">
        /// <item><description>The name must be 3 to 23 characters in length, and can contain letters, underscores (_), and digits.</description></item>
        /// <item><description>The name must start with a letter.</description></item>
        /// <item><description>The name must be unique in the current region.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-example</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

    }

}
