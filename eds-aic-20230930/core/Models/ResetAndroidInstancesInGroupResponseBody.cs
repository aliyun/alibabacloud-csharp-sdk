// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ResetAndroidInstancesInGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The order ID for storage reduction. This parameter is returned only when you reduce storage while resetting instances in a cloud phone matrix. It is not returned in other scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22365781890****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69BCBBE4-FCF2-59B8-AD9D-531EB422****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task information.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public ResetAndroidInstancesInGroupResponseBodyTasks Tasks { get; set; }
        public class ResetAndroidInstancesInGroupResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The child tasks.</para>
            /// </summary>
            [NameInMap("ChildTasks")]
            [Validation(Required=false)]
            public List<ResetAndroidInstancesInGroupResponseBodyTasksChildTasks> ChildTasks { get; set; }
            public class ResetAndroidInstancesInGroupResponseBodyTasksChildTasks : TeaModel {
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
