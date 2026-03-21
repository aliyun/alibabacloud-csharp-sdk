// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class UpdateInstanceImageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1A923337-44D9-5CAD-9A53-95084BD4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>t-1ljew7on6ay0j****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public UpdateInstanceImageResponseBodyTasks Tasks { get; set; }
        public class UpdateInstanceImageResponseBodyTasks : TeaModel {
            [NameInMap("ChildTasks")]
            [Validation(Required=false)]
            public List<UpdateInstanceImageResponseBodyTasksChildTasks> ChildTasks { get; set; }
            public class UpdateInstanceImageResponseBodyTasksChildTasks : TeaModel {
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
