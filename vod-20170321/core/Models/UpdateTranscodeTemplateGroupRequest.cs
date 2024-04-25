// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateTranscodeTemplateGroupRequest : TeaModel {
        /// <summary>
        /// The lock status of the transcoding template group. Valid values:
        /// 
        /// *   **Enabled**: The transcoding template group is locked and cannot be modified.
        /// *   **Disabled** (default): The transcoding template group is not locked.
        /// </summary>
        [NameInMap("Locked")]
        [Validation(Required=false)]
        public string Locked { get; set; }

        /// <summary>
        /// The name of the transcoding template group.
        /// 
        /// *   The name cannot exceed 128 bytes.
        /// *   The value must be encoded in UTF-8.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the transcoding template group.
        /// </summary>
        [NameInMap("TranscodeTemplateGroupId")]
        [Validation(Required=false)]
        public string TranscodeTemplateGroupId { get; set; }

        /// <summary>
        /// The configurations of the transcoding template. The value must be a JSON string. For more information about the data structure, see [TranscodeTemplate](~~52839#title-9mb-8o2-uu6~~).
        /// </summary>
        [NameInMap("TranscodeTemplateList")]
        [Validation(Required=false)]
        public string TranscodeTemplateList { get; set; }

    }

}
