// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class OperateJobRequest : TeaModel {
        /// <summary>
        /// <para>The description. The length is 0 to 128 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dasd</para>
        /// </summary>
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Task: regular task (default).</description></item>
        /// <item><description>SceneTestingTask: scenario-based testing task.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Task</para>
        /// </summary>
        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
