// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class UpdateTensorboardRequest : TeaModel {
        /// <summary>
        /// <para>Visibility of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PUBLIC: Visible to all users in this workspace.</para>
        /// </description></item>
        /// <item><description><para>PRIVATE: Visible only to you and administrators in this workspace.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>Maximum runtime. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("MaxRunningTimeMinutes")]
        [Validation(Required=false)]
        public long? MaxRunningTimeMinutes { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>Workspace ID. For more information about how to get a workspace ID, see <a href="">ListWorkspaces</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>380</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
