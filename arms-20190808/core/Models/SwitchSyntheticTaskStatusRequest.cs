// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SwitchSyntheticTaskStatusRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to start or stop the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: stops the task</description></item>
        /// <item><description><b>1</b>: starts the task</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SwitchStatus")]
        [Validation(Required=false)]
        public long? SwitchStatus { get; set; }

        /// <summary>
        /// <para>The task IDs. You can specify up to 30 task IDs at a time.</para>
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public List<long?> TaskIds { get; set; }

    }

}
