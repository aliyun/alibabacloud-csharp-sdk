// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateSoftwarelibDistributeTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B608C6AE-623D-55C4-9454-601B88AE937E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the created task.</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public CreateSoftwarelibDistributeTaskResponseBodyTask Task { get; set; }
        public class CreateSoftwarelibDistributeTaskResponseBodyTask : TeaModel {
            /// <summary>
            /// <para>The time when the task was created. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1782268092</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The name of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_task</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The name of the software.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test software</para>
            /// </summary>
            [NameInMap("SoftwareName")]
            [Validation(Required=false)]
            public string SoftwareName { get; set; }

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>enabled</b>: Enabled.</description></item>
            /// <item><description><b>disabled</b>: Disabled.</description></item>
            /// </list>
            /// <para>After a task is created, its initial status is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The operating system to which the task applies. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Windows</b>: Windows.</description></item>
            /// <item><description><b>Mac(Apple)</b>: macOS on Apple silicon.</description></item>
            /// <item><description><b>Mac(Intel)</b>: macOS on Intel processors.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("SupportOs")]
            [Validation(Required=false)]
            public string SupportOs { get; set; }

            /// <summary>
            /// <para>The ID of the task. You can use the ID to query the task execution result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>softwarelib-distribute-task-911dd7898bc2****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
