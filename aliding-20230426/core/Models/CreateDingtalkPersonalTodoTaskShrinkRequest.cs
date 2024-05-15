// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateDingtalkPersonalTodoTaskShrinkRequest : TeaModel {
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
        public string ExecutorIdsShrink { get; set; }

        [NameInMap("NotifyConfigs")]
        [Validation(Required=false)]
        public string NotifyConfigsShrink { get; set; }

        [NameInMap("ParticipantIds")]
        [Validation(Required=false)]
        public string ParticipantIdsShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

        [NameInMap("UserToken")]
        [Validation(Required=false)]
        public string UserToken { get; set; }

    }

}
