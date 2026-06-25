// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class UpdateWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>The description of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is an example workspace.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the workspace. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>The name must be 3 to 23 characters in length and can contain letters, underscores (_), and digits.</para>
        /// </description></item>
        /// <item><description><para>The name must start with a letter.</para>
        /// </description></item>
        /// <item><description><para>The name must be unique within the current region.</para>
        /// </description></item>
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
