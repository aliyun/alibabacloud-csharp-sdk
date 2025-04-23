// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetTaskPolicyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0D797DC3-FF04-5C21-81EB-92C7799512E3</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("taskPolicy")]
        [Validation(Required=false)]
        public GetTaskPolicyResponseBodyTaskPolicy TaskPolicy { get; set; }
        public class GetTaskPolicyResponseBodyTaskPolicy : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>g-433aead7560571e66e31274ffd3</para>
            /// </summary>
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("taskPolicies")]
            [Validation(Required=false)]
            public List<GetTaskPolicyResponseBodyTaskPolicyTaskPolicies> TaskPolicies { get; set; }
            public class GetTaskPolicyResponseBodyTaskPolicyTaskPolicies : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("priority")]
                [Validation(Required=false)]
                public long? Priority { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>task-433aead7560571d0938bfbbe957</para>
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                [NameInMap("taskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SceneTestingTask</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
