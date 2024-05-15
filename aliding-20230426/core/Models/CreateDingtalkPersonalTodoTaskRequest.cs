// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateDingtalkPersonalTodoTaskRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DueTime")]
        [Validation(Required=false)]
        public long? DueTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExecutorIds")]
        [Validation(Required=false)]
        public List<string> ExecutorIds { get; set; }

        [NameInMap("NotifyConfigs")]
        [Validation(Required=false)]
        public CreateDingtalkPersonalTodoTaskRequestNotifyConfigs NotifyConfigs { get; set; }
        public class CreateDingtalkPersonalTodoTaskRequestNotifyConfigs : TeaModel {
            [NameInMap("DingNotify")]
            [Validation(Required=false)]
            public string DingNotify { get; set; }

        }

        [NameInMap("ParticipantIds")]
        [Validation(Required=false)]
        public List<string> ParticipantIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public CreateDingtalkPersonalTodoTaskRequestTenantContext TenantContext { get; set; }
        public class CreateDingtalkPersonalTodoTaskRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("UserToken")]
        [Validation(Required=false)]
        public string UserToken { get; set; }

    }

}
