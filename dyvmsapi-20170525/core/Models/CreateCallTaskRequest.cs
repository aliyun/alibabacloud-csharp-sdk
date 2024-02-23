// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CreateCallTaskRequest : TeaModel {
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

        /// <summary>
        /// The called numbers.
        /// 
        /// *   If you set DataType to LIST, the value of Data is in the LIST format.
        /// *   If you set DataType to JSON, the value of Data is in the JSON format.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// The type of called numbers. Valid values:
        /// 
        /// *   **LIST**: the called numbers that are separated by commas (,).
        /// *   **JSON**: a JSON-formatted list of called numbers with template parameters.
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// This parameter is unavailable.
        /// </summary>
        [NameInMap("FireTime")]
        [Validation(Required=false)]
        public string FireTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The calling number. Only virtual numbers are supported.
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The type of the calling number. Set the value to **LIST**.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// This parameter is unavailable.
        /// </summary>
        [NameInMap("ScheduleType")]
        [Validation(Required=false)]
        public string ScheduleType { get; set; }

        /// <summary>
        /// This parameter is unavailable.
        /// </summary>
        [NameInMap("StopTime")]
        [Validation(Required=false)]
        public string StopTime { get; set; }

        /// <summary>
        /// The task name.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// The template ID.
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// The template name.
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
