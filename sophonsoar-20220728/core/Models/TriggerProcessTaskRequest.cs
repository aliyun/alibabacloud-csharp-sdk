// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class TriggerProcessTaskRequest : TeaModel {
        /// <summary>
        /// <para>The type of the action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>remove</b>: cancels blocking or isolation.</description></item>
        /// <item><description><b>retry</b>: submits the task again.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>remove</para>
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// <para>The ID of the handling task.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeProcessTasks~~">DescribeProcessTasks</a> operation to query the IDs of handling tasks.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15355xxxxxx82894882</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
