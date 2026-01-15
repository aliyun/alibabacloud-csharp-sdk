// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class BatchGetAcpConnectionTicketRequest : TeaModel {
        [NameInMap("ConnectionMode")]
        [Validation(Required=false)]
        public string ConnectionMode { get; set; }

        /// <summary>
        /// <para>The ID of the user to whom the cloud phone instance is assigned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The ID of the instance group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ag-25nt4kk9whjh****</para>
        /// </summary>
        [NameInMap("InstanceGroupId")]
        [Validation(Required=false)]
        public string InstanceGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of the cloud phone instances. You can specify 1 to 100 IDs of cloud phone instances.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The instance connection tasks.</para>
        /// </summary>
        [NameInMap("InstanceTasks")]
        [Validation(Required=false)]
        public List<BatchGetAcpConnectionTicketRequestInstanceTasks> InstanceTasks { get; set; }
        public class BatchGetAcpConnectionTicketRequestInstanceTasks : TeaModel {
            /// <summary>
            /// <para>The ID of the cloud phone instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acp-fkuit0cmyfvzz****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou@c9f5c2e8-f5c4-4b01-8602-000cae94****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
