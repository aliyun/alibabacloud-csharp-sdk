// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class TriggerProcessTaskRequest : TeaModel {
        /// <summary>
        /// <para>The type of the handling action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>remove</b>: Removes a block or an asset from isolation.</para>
        /// </description></item>
        /// <item><description><para><b>retry</b>: Resubmits the task.</para>
        /// </description></item>
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
        /// <para>The unique ID of the handling task.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeProcessTasks~~">DescribeProcessTasks</a> operation to obtain this parameter.</para>
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
