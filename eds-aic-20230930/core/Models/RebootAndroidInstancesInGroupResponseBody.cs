// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class RebootAndroidInstancesInGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>227CBB4C-F5DC-589D-A667-C5CA3D52****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task information.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public RebootAndroidInstancesInGroupResponseBodyTasks Tasks { get; set; }
        public class RebootAndroidInstancesInGroupResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The child tasks.</para>
            /// </summary>
            [NameInMap("ChildTasks")]
            [Validation(Required=false)]
            public List<RebootAndroidInstancesInGroupResponseBodyTasksChildTasks> ChildTasks { get; set; }
            public class RebootAndroidInstancesInGroupResponseBodyTasksChildTasks : TeaModel {
                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acp-xxxx</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The child task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t-xxxx</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

            /// <summary>
            /// <para>The parent task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-xxxx</para>
            /// </summary>
            [NameInMap("ParentTaskId")]
            [Validation(Required=false)]
            public string ParentTaskId { get; set; }

        }

    }

}
