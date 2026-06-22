// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ProcessSoarStrategyTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the policy task.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeSoarStrategyTasks~~">DescribeSoarStrategyTasks</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("StrategyTaskId")]
        [Validation(Required=false)]
        public long? StrategyTaskId { get; set; }

        /// <summary>
        /// <para>The action status of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SCHEDULE: scheduling</description></item>
        /// <item><description>PAUSE: pause.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SCHEDULE</para>
        /// </summary>
        [NameInMap("TaskAction")]
        [Validation(Required=false)]
        public string TaskAction { get; set; }

    }

}
