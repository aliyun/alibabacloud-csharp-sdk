// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateProjectBuildRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a65451293e64979ba7a4b573950217fe</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>refresh</para>
        /// </summary>
        [NameInMap("projectBuildAction")]
        [Validation(Required=false)]
        public string ProjectBuildAction { get; set; }

        [NameInMap("taskIds")]
        [Validation(Required=false)]
        public List<string> TaskIds { get; set; }

        [NameInMap("taskPolicies")]
        [Validation(Required=false)]
        public List<CreateProjectBuildRequestTaskPolicies> TaskPolicies { get; set; }
        public class CreateProjectBuildRequestTaskPolicies : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>destroyAfterExecution</para>
            /// </summary>
            [NameInMap("destroyAfterExecution")]
            [Validation(Required=false)]
            public bool? DestroyAfterExecution { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>task-60f24b4eb47f1135b7b14ddbdfd</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
