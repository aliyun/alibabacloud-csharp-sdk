// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ListCallTaskRequest : TeaModel {
        /// <summary>
        /// The type of the task template. Valid values:
        /// 
        /// *   **VMS_VOICE_TTS**: the text-to-speech (TTS) notification template.
        /// *   **VMS_VOICE_CODE**: the voice notification template.
        /// *   **VMS_TTS**: the voice verification code template.
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The task state. Valid values:
        /// 
        /// *   **INIT**: The task is in the initial state.
        /// *   **RELEASE**: The task is being parsed.
        /// *   **RUNNING**: The task is running.
        /// *   **STOP**: The task is suspended.
        /// *   **SYSTEM_STOP**: The task is suspended by the system.
        /// *   **CANCEL**: The task is canceled.
        /// *   **SYSTEM_CANCEL**: The task is canceled by the system.
        /// *   **DONE**: The task is complete.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The task ID.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The task name.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// The template name.
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
