// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class UpdateCloudPhoneNodeSystemImageResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-ehs0yoedj0xe9****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The task information.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public UpdateCloudPhoneNodeSystemImageResponseBodyTasks Tasks { get; set; }
        public class UpdateCloudPhoneNodeSystemImageResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The child tasks.</para>
            /// </summary>
            [NameInMap("ChildTasks")]
            [Validation(Required=false)]
            public List<UpdateCloudPhoneNodeSystemImageResponseBodyTasksChildTasks> ChildTasks { get; set; }
            public class UpdateCloudPhoneNodeSystemImageResponseBodyTasksChildTasks : TeaModel {
                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cpn-xxxx</para>
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
