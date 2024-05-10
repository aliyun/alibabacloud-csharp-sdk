// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreatePersonalTodoTaskRequest : TeaModel {
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
        public CreatePersonalTodoTaskRequestNotifyConfigs NotifyConfigs { get; set; }
        public class CreatePersonalTodoTaskRequestNotifyConfigs : TeaModel {
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
        public CreatePersonalTodoTaskRequestTenantContext TenantContext { get; set; }
        public class CreatePersonalTodoTaskRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
