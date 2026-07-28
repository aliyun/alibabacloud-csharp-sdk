// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetJobRequest : TeaModel {
        /// <summary>
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Task: regular task (default)</description></item>
        /// <item><description>SceneTestingTask: scenario-based testing task</description></item>
        /// <item><description>Stack: resource stack.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SceneTestingTask</para>
        /// </summary>
        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
