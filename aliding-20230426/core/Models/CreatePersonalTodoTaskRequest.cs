// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreatePersonalTodoTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>待办备注信息</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1703750708595</para>
        /// </summary>
        [NameInMap("DueTime")]
        [Validation(Required=false)]
        public long? DueTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ &quot;012345&quot; ]</para>
        /// </summary>
        [NameInMap("ExecutorIds")]
        [Validation(Required=false)]
        public List<string> ExecutorIds { get; set; }

        [NameInMap("NotifyConfigs")]
        [Validation(Required=false)]
        public CreatePersonalTodoTaskRequestNotifyConfigs NotifyConfigs { get; set; }
        public class CreatePersonalTodoTaskRequestNotifyConfigs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DingNotify")]
            [Validation(Required=false)]
            public string DingNotify { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[ &quot;012345&quot; ]</para>
        /// </summary>
        [NameInMap("ParticipantIds")]
        [Validation(Required=false)]
        public List<string> ParticipantIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>待办标题</para>
        /// </summary>
        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public CreatePersonalTodoTaskRequestTenantContext TenantContext { get; set; }
        public class CreatePersonalTodoTaskRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
