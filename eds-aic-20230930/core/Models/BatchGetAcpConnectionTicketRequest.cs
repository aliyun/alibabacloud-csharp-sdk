// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class BatchGetAcpConnectionTicketRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ag-25nt4kk9whjh****</para>
        /// </summary>
        [NameInMap("InstanceGroupId")]
        [Validation(Required=false)]
        public string InstanceGroupId { get; set; }

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        [NameInMap("InstanceTasks")]
        [Validation(Required=false)]
        public List<BatchGetAcpConnectionTicketRequestInstanceTasks> InstanceTasks { get; set; }
        public class BatchGetAcpConnectionTicketRequestInstanceTasks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>acp-fkuit0cmyfvzz****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou@c9f5c2e8-f5c4-4b01-8602-000cae94****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
