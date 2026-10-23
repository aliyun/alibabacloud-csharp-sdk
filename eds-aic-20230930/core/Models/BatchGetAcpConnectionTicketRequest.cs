// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class BatchGetAcpConnectionTicketRequest : TeaModel {
        /// <summary>
        /// <para>The connection mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("ConnectionMode")]
        [Validation(Required=false)]
        public string ConnectionMode { get; set; }

        /// <summary>
        /// <para>The ID of the assigned user. If you do not specify this parameter, the system user assigned in the background is used to obtain the ticket.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;
        /// The usage of this parameter varies based on the Cloud Phone edition and the instance streaming mode:</para>
        /// <list type="bullet">
        /// <item><description>Cloud Phone Instance Edition or Cloud Phone Matrix Edition (preemptive mode): You can obtain a <c>Ticket</c> only by using the same <c>EnduserId</c>.</description></item>
        /// <item><description>Cloud Phone Matrix Edition (collaborative mode): You can pass different <c>EnduserId</c> values to obtain <c>Ticket</c> values and stream for different users (up to 5) at the same time. You can pass only one <c>EnduserId</c> at a time.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can define the instance streaming mode by using the <c>StreamMode</c> parameter of the <c>ModifyCloudPhoneNode</c> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The instance group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ag-25nt4kk9whjh****</para>
        /// </summary>
        [NameInMap("InstanceGroupId")]
        [Validation(Required=false)]
        public string InstanceGroupId { get; set; }

        /// <summary>
        /// <para>The list of Cloud Phone instance IDs. You can specify 1 to 100 IDs.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The instance connection tasks. This parameter is used to query whether the ticket retrieval task is completed.</para>
        /// </summary>
        [NameInMap("InstanceTasks")]
        [Validation(Required=false)]
        public List<BatchGetAcpConnectionTicketRequestInstanceTasks> InstanceTasks { get; set; }
        public class BatchGetAcpConnectionTicketRequestInstanceTasks : TeaModel {
            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acp-fkuit0cmyfvzz****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou@c9f5c2e8-f5c4-4b01-8602-000cae94****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The list of custom connection ports.</para>
        /// </summary>
        [NameInMap("Ports")]
        [Validation(Required=false)]
        public List<string> Ports { get; set; }

    }

}
