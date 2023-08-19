// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateTranscodeTemplateGroupRequest : TeaModel {
        /// <summary>
        /// The lock status of the template group. Valid values:
        /// 
        /// *   **Enabled**: The template group is locked.
        /// *   **Disabled**: The template group is not locked.
        /// </summary>
        [NameInMap("Locked")]
        [Validation(Required=false)]
        public string Locked { get; set; }

        /// <summary>
        /// The name of the transcoding template group.
        /// 
        /// *   The name can be up to 128 bytes in length.
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
        /// The configurations of the transcoding template. The value is a JSON-formatted string. For more information about the data structure, see the "TranscodeTemplate" section of the [Basic data types](~~52839~~) topic.
        /// </summary>
        [NameInMap("TranscodeTemplateList")]
        [Validation(Required=false)]
        public string TranscodeTemplateList { get; set; }

    }

}
