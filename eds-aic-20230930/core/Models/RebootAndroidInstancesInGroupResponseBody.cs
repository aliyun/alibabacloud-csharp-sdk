// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class RebootAndroidInstancesInGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>227CBB4C-F5DC-589D-A667-C5CA3D52****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public RebootAndroidInstancesInGroupResponseBodyTasks Tasks { get; set; }
        public class RebootAndroidInstancesInGroupResponseBodyTasks : TeaModel {
            [NameInMap("ChildTasks")]
            [Validation(Required=false)]
            public List<RebootAndroidInstancesInGroupResponseBodyTasksChildTasks> ChildTasks { get; set; }
            public class RebootAndroidInstancesInGroupResponseBodyTasksChildTasks : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>acp-xxxx</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>t-xxxx</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>t-xxxx</para>
            /// </summary>
            [NameInMap("ParentTaskId")]
            [Validation(Required=false)]
            public string ParentTaskId { get; set; }

        }

    }

}
